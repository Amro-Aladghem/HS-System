namespace HospitalSys.PateintsRecords
{
    partial class PatientsRecordHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExits = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbNationaNum = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.recordInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.gbPatient = new System.Windows.Forms.GroupBox();
            this.btnPatientIDSearch = new System.Windows.Forms.Button();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdNationalNum = new System.Windows.Forms.RadioButton();
            this.rdPatientID = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbNationaNum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnExits);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1422, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnExits
            // 
            this.btnExits.BackColor = System.Drawing.Color.White;
            this.btnExits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExits.Location = new System.Drawing.Point(1304, 0);
            this.btnExits.Name = "btnExits";
            this.btnExits.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExits.Size = new System.Drawing.Size(118, 100);
            this.btnExits.TabIndex = 2;
            this.btnExits.UseVisualStyleBackColor = false;
            this.btnExits.Click += new System.EventHandler(this.btnExits_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(611, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Record History:";
            // 
            // gbNationaNum
            // 
            this.gbNationaNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbNationaNum.Controls.Add(this.btnSearch);
            this.gbNationaNum.Controls.Add(this.textBox1);
            this.gbNationaNum.Controls.Add(this.label2);
            this.gbNationaNum.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbNationaNum.Location = new System.Drawing.Point(4, 154);
            this.gbNationaNum.Name = "gbNationaNum";
            this.gbNationaNum.Size = new System.Drawing.Size(1419, 100);
            this.gbNationaNum.TabIndex = 1;
            this.gbNationaNum.TabStop = false;
            this.gbNationaNum.Text = "Find Records For Patient:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(961, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 76);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(548, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 32);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(292, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "National Num:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1422, 298);
            this.dataGridView1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 36);
            // 
            // recordInfoToolStripMenuItem
            // 
            this.recordInfoToolStripMenuItem.Name = "recordInfoToolStripMenuItem";
            this.recordInfoToolStripMenuItem.Size = new System.Drawing.Size(184, 32);
            this.recordInfoToolStripMenuItem.Text = "Record Info";
            this.recordInfoToolStripMenuItem.Click += new System.EventHandler(this.recordInfoToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Patient Record History:";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.White;
            this.btnAddPatient.Enabled = false;
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatient.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.Location = new System.Drawing.Point(813, 598);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(341, 66);
            this.btnAddPatient.TabIndex = 4;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.BackColor = System.Drawing.Color.White;
            this.btnAddRecord.Enabled = false;
            this.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRecord.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecord.Location = new System.Drawing.Point(277, 598);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(333, 66);
            this.btnAddRecord.TabIndex = 5;
            this.btnAddRecord.Text = "Add New Record";
            this.btnAddRecord.UseVisualStyleBackColor = false;
            // 
            // gbPatient
            // 
            this.gbPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbPatient.Controls.Add(this.btnPatientIDSearch);
            this.gbPatient.Controls.Add(this.txtPatientID);
            this.gbPatient.Controls.Add(this.label4);
            this.gbPatient.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbPatient.Location = new System.Drawing.Point(4, 148);
            this.gbPatient.Name = "gbPatient";
            this.gbPatient.Size = new System.Drawing.Size(1419, 100);
            this.gbPatient.TabIndex = 3;
            this.gbPatient.TabStop = false;
            this.gbPatient.Text = "Find Records For Patient:";
            // 
            // btnPatientIDSearch
            // 
            this.btnPatientIDSearch.BackColor = System.Drawing.Color.White;
            this.btnPatientIDSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPatientIDSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientIDSearch.Location = new System.Drawing.Point(959, 14);
            this.btnPatientIDSearch.Name = "btnPatientIDSearch";
            this.btnPatientIDSearch.Size = new System.Drawing.Size(105, 76);
            this.btnPatientIDSearch.TabIndex = 2;
            this.btnPatientIDSearch.UseVisualStyleBackColor = false;
            this.btnPatientIDSearch.Click += new System.EventHandler(this.btnPatientIDSearch_Click);
            // 
            // txtPatientID
            // 
            this.txtPatientID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtPatientID.Location = new System.Drawing.Point(546, 46);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(371, 32);
            this.txtPatientID.TabIndex = 1;
            this.txtPatientID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientID_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(300, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "PatientID:";
            // 
            // rdNationalNum
            // 
            this.rdNationalNum.AutoSize = true;
            this.rdNationalNum.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNationalNum.Location = new System.Drawing.Point(4, 107);
            this.rdNationalNum.Name = "rdNationalNum";
            this.rdNationalNum.Size = new System.Drawing.Size(146, 23);
            this.rdNationalNum.TabIndex = 6;
            this.rdNationalNum.TabStop = true;
            this.rdNationalNum.Text = "NationalNum:";
            this.rdNationalNum.UseVisualStyleBackColor = true;
            this.rdNationalNum.CheckedChanged += new System.EventHandler(this.rdNationalNum_CheckedChanged);
            // 
            // rdPatientID
            // 
            this.rdPatientID.AutoSize = true;
            this.rdPatientID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPatientID.Location = new System.Drawing.Point(156, 107);
            this.rdPatientID.Name = "rdPatientID";
            this.rdPatientID.Size = new System.Drawing.Size(113, 23);
            this.rdPatientID.TabIndex = 7;
            this.rdPatientID.TabStop = true;
            this.rdPatientID.Text = "PatientID";
            this.rdPatientID.UseVisualStyleBackColor = true;
            this.rdPatientID.CheckedChanged += new System.EventHandler(this.rdPatientID_CheckedChanged);
            // 
            // PatientsRecordHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1424, 668);
            this.Controls.Add(this.rdPatientID);
            this.Controls.Add(this.rdNationalNum);
            this.Controls.Add(this.gbPatient);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbNationaNum);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PatientsRecordHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientsRecordHistory";
            this.Load += new System.EventHandler(this.PatientsRecordHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbNationaNum.ResumeLayout(false);
            this.gbNationaNum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbPatient.ResumeLayout(false);
            this.gbPatient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExits;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbNationaNum;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recordInfoToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbPatient;
        private System.Windows.Forms.Button btnPatientIDSearch;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdNationalNum;
        private System.Windows.Forms.RadioButton rdPatientID;
    }
}