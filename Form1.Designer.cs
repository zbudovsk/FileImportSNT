
namespace FileImportSNT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSelectFolder = new System.Windows.Forms.Button();
            this.tbFolderForSave = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btCheckAll = new System.Windows.Forms.Button();
            this.dtPickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dtPickerStart = new System.Windows.Forms.DateTimePicker();
            this.btMakeXML = new System.Windows.Forms.Button();
            this.btGetData = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btRunProc = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btRunProc);
            this.panel2.Controls.Add(this.btSelectFolder);
            this.panel2.Controls.Add(this.tbFolderForSave);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btCheckAll);
            this.panel2.Controls.Add(this.dtPickerEnd);
            this.panel2.Controls.Add(this.dtPickerStart);
            this.panel2.Controls.Add(this.btMakeXML);
            this.panel2.Controls.Add(this.btGetData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 101);
            this.panel2.TabIndex = 1;
            // 
            // btSelectFolder
            // 
            this.btSelectFolder.Location = new System.Drawing.Point(844, 15);
            this.btSelectFolder.Name = "btSelectFolder";
            this.btSelectFolder.Size = new System.Drawing.Size(26, 24);
            this.btSelectFolder.TabIndex = 7;
            this.btSelectFolder.Text = "...";
            this.btSelectFolder.UseVisualStyleBackColor = true;
            this.btSelectFolder.Click += new System.EventHandler(this.btSelectFolder_Click);
            // 
            // tbFolderForSave
            // 
            this.tbFolderForSave.Location = new System.Drawing.Point(488, 15);
            this.tbFolderForSave.Name = "tbFolderForSave";
            this.tbFolderForSave.Size = new System.Drawing.Size(350, 23);
            this.tbFolderForSave.TabIndex = 6;
            this.tbFolderForSave.Text = "C:\\TEMP";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "UnCkeck All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCheckAll
            // 
            this.btCheckAll.Location = new System.Drawing.Point(337, 54);
            this.btCheckAll.Name = "btCheckAll";
            this.btCheckAll.Size = new System.Drawing.Size(89, 33);
            this.btCheckAll.TabIndex = 4;
            this.btCheckAll.Text = "Ckeck";
            this.btCheckAll.UseVisualStyleBackColor = true;
            this.btCheckAll.Click += new System.EventHandler(this.btCheckAll_Click);
            // 
            // dtPickerEnd
            // 
            this.dtPickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerEnd.Location = new System.Drawing.Point(158, 12);
            this.dtPickerEnd.Name = "dtPickerEnd";
            this.dtPickerEnd.Size = new System.Drawing.Size(109, 23);
            this.dtPickerEnd.TabIndex = 3;
            // 
            // dtPickerStart
            // 
            this.dtPickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerStart.Location = new System.Drawing.Point(32, 12);
            this.dtPickerStart.Name = "dtPickerStart";
            this.dtPickerStart.Size = new System.Drawing.Size(109, 23);
            this.dtPickerStart.TabIndex = 2;
            // 
            // btMakeXML
            // 
            this.btMakeXML.Location = new System.Drawing.Point(632, 46);
            this.btMakeXML.Name = "btMakeXML";
            this.btMakeXML.Size = new System.Drawing.Size(111, 33);
            this.btMakeXML.TabIndex = 1;
            this.btMakeXML.Text = "XML";
            this.btMakeXML.UseVisualStyleBackColor = true;
            this.btMakeXML.Click += new System.EventHandler(this.btMakeXML_Click);
            // 
            // btGetData
            // 
            this.btGetData.Location = new System.Drawing.Point(286, 12);
            this.btGetData.Name = "btGetData";
            this.btGetData.Size = new System.Drawing.Size(141, 33);
            this.btGetData.TabIndex = 0;
            this.btGetData.Text = "Показать документы";
            this.btGetData.UseVisualStyleBackColor = true;
            this.btGetData.Click += new System.EventHandler(this.btGetData_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 440);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(881, 25);
            this.panel4.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(406, 339);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(881, 339);
            this.dataGridView1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(475, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 339);
            this.panel1.TabIndex = 5;
            // 
            // btRunProc
            // 
            this.btRunProc.Location = new System.Drawing.Point(28, 51);
            this.btRunProc.Name = "btRunProc";
            this.btRunProc.Size = new System.Drawing.Size(87, 27);
            this.btRunProc.TabIndex = 8;
            this.btRunProc.Text = "run";
            this.btRunProc.UseVisualStyleBackColor = true;
            this.btRunProc.Click += new System.EventHandler(this.btRunProc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 465);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "SNT Import";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btGetData;
        private System.Windows.Forms.Button btMakeXML;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtPickerEnd;
        private System.Windows.Forms.DateTimePicker dtPickerStart;
        private System.Windows.Forms.Button btCheckAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbFolderForSave;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btSelectFolder;
        private System.Windows.Forms.Button btRunProc;
    }
}

