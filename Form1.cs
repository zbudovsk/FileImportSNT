using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace FileImportSNT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private string stCN = "Data Source=bl08;Initial Catalog=mch;Integrated Security=True";

        private void btGetData_Click(object sender, EventArgs e)
        {

            using SqlConnection sqlConn = new SqlConnection(stCN);

            string sqlExpression = "bpVendReceipt_ListViewDocs";   /* название процедуры */

            string dStart = dtPickerStart.Value.ToString("yyyy-MM-dd");
            string dEnd = dtPickerEnd.Value.ToString("yyyy-MM-dd");

            SqlCommand sqlCmd = new SqlCommand(sqlExpression, sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@CustNote_Object", "VendReceipt");
            sqlCmd.Parameters.AddWithValue("@WorkPeriodBegin", dStart);
            sqlCmd.Parameters.AddWithValue("@WorkPeriodEnd", dEnd);
            sqlCmd.Parameters.AddWithValue("@StatusList", "I");
            sqlCmd.Parameters.AddWithValue("@DocumentTypeId", "MaterialCurr");

            sqlConn.Open();

            SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();

            DataTable TempTable = new DataTable();
            TempTable.Load(sqlDataReader);

            //MessageBox.Show(TempTable.Columns.Count.ToString());
            string[] existingcol = { "CustNoteDate", "CustNoteNumber", "CurrentStatus" };
            List<DataColumn> columnsToDelete = new List<DataColumn>();
            foreach (DataColumn col in TempTable.Columns)
            {
                if (!(existingcol.Contains(col.ColumnName)))
                    columnsToDelete.Add(col);
            }
            foreach (DataColumn col in columnsToDelete)
                TempTable.Columns.Remove(col);

            //TempTable.Columns.Add("Check", typeof(bool));
            DataColumn colNew = new DataColumn("Check", typeof(bool));
            colNew.DefaultValue = false;
            TempTable.Columns.Add(colNew);

            dataGridView1.DataSource = TempTable;

            sqlConn.Close();
        }

        private void btMakeXML_Click(object sender, EventArgs e)
        {
            string stIn = "";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                string fNum = dataGridView1[1, i].Value.ToString();
                string fStatus = dataGridView1[2, i].Value.ToString();
                string fCheck = dataGridView1[3, i].Value.ToString();
                if (fCheck == "True" && fStatus == "I")
                    stIn += "'" + fNum.Trim() + "',";

            }

            int n = stIn.Length;
            if (n <= 0)
                return;  //-- 

            string stQry = "select DocNum, xLines from zb_tblTMP_XML where DocType = 'SNT_importM' and DocNum in (##)";
            stIn = stIn.Substring(0, n - 1);
            stQry = stQry.Replace("##", stIn);


            string stConteiner = @"<?xml version=""1.0"" encoding=""UTF-8""?><snt:sntInfoContainer xmlns:snt=""snt""><sntInfoSet>" + (char)13 + (char)10 + (char)13 + (char)10;

            string sntInfo = @"
    <sntInfo>
      <version>SntV1</version>
      <documentInfo>
        <sntBody><![CDATA[#]]></sntBody>
        <creatorLogin>691103000114</creatorLogin>
        <creatorTin>981040000728</creatorTin>
		<signatureValid>false</signatureValid>
        <errors/>
      </documentInfo>
    </sntInfo>";

            SqlConnection cnn = new SqlConnection(stCN);
            cnn.Open();

            textBox1.Clear();
            textBox1.AppendText("Номера документов:" + Environment.NewLine);
            //textBox1.AppendText(Environment.NewLine);

            int n1 = 0;
            SqlCommand command = new SqlCommand(stQry, cnn);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                n1++;
                string DocNum = dataReader.GetValue("DocNum").ToString();
                string xLines = dataReader.GetValue("xLines").ToString();

                stConteiner += sntInfo.Replace("#", xLines) + (char)13 + (char)10;

                textBox1.AppendText(n1.ToString() + " - " + DocNum);
                textBox1.AppendText(Environment.NewLine);
            }
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            stConteiner += "</sntInfoSet></snt:sntInfoContainer>";

            // --------------------------------------------   
            //string fName = "C:\\TEMP\\_sntImp_" + DateTime.Now.ToString("yyyyMMdd HHmmss") + ".xml";
            string fName = tbFolderForSave.Text + "\\_sntImp_" + DateTime.Now.ToString("yyyyMMdd") + ".xml";
            if (File.Exists(fName))
                File.Delete(fName);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(stConteiner);
            xmlDoc.Save(fName);

            textBox1.AppendText("------------------------" + Environment.NewLine);
            textBox1.AppendText("Сохранено в файл:" + Environment.NewLine);
            textBox1.AppendText(fName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtPickerStart.Value = DateTime.Now;
            dtPickerEnd.Value = DateTime.Now;
        }

        private void btCheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
                dataGridView1[3, i].Value = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
                dataGridView1[3, i].Value = false;
        }

        private void btSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderName = new FolderBrowserDialog();
            folderName.ShowNewFolderButton = false;

            if (folderName.ShowDialog() == DialogResult.OK)
                tbFolderForSave.Text = folderName.SelectedPath;
        }

        private void btRunProc_Click(object sender, EventArgs e)
        {
            using SqlConnection sqlConn = new SqlConnection(stCN);

            string sqlExpression = "zb_FillXMLCommingImport";   /* название процедуры */
            string dStart = dtPickerStart.Value.ToString("yyyy-MM-dd");
            string dEnd = dtPickerEnd.Value.ToString("yyyy-MM-dd");

            SqlCommand sqlCmd = new SqlCommand(sqlExpression, sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@dateBegin", dStart);
            sqlCmd.Parameters.AddWithValue("@dateEnd", dEnd);

            sqlConn.Open();
            SqlDataReader sqlDataReader = sqlCmd.ExecuteReader();

            DataTable TempTable = new DataTable();
            TempTable.Load(sqlDataReader);

            textBox1.Clear();
            foreach (DataRow row in TempTable.Rows)
            {
                foreach (DataColumn column in TempTable.Columns)
                {
                    textBox1.AppendText(row[column].ToString());
                    textBox1.AppendText("  ");
                }
                textBox1.AppendText(Environment.NewLine);
            }
            textBox1.AppendText("------------------");
            sqlConn.Close();
                       
        }
    }
}
