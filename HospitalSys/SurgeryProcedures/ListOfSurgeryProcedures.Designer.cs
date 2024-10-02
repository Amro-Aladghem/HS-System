namespace HospitalSys.SurgeryProcedures
{
    partial class ListOfSurgeryProcedures
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
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateProcedureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procedureInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProcedureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeItFinishedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paientInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docotr1InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctor2InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctor3InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nurse1InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nurse2InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payProcedureCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientsProceduresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxActive = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbxFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRecords = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1812, 103);
            this.panel1.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.White;
            this.btnFind.BackgroundImage = global::HospitalSys.Properties.Resources.research;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Location = new System.Drawing.Point(1436, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 78);
            this.btnFind.TabIndex = 4;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.BackgroundImage = global::HospitalSys.Properties.Resources.updated__2_;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(1567, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 78);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = global::HospitalSys.Properties.Resources.psychic_surgery;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(1698, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 78);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::HospitalSys.Properties.Resources.robotic_surgery;
            this.pictureBox1.Location = new System.Drawing.Point(892, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Of Surgery Procedures:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1812, 523);
            this.dataGridView1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateProcedureToolStripMenuItem,
            this.procedureInfoToolStripMenuItem,
            this.deleteProcedureToolStripMenuItem,
            this.makeItFinishedToolStripMenuItem,
            this.paientInfoToolStripMenuItem,
            this.docotr1InfoToolStripMenuItem,
            this.doctor2InfoToolStripMenuItem,
            this.doctor3InfoToolStripMenuItem,
            this.nurse1InfoToolStripMenuItem,
            this.nurse2InfoToolStripMenuItem,
            this.payProcedureCostToolStripMenuItem,
            this.patientsProceduresToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(251, 421);
            // 
            // updateProcedureToolStripMenuItem
            // 
            this.updateProcedureToolStripMenuItem.Image = global::HospitalSys.Properties.Resources.circular_arrow;
            this.updateProcedureToolStripMenuItem.Name = "updateProcedureToolStripMenuItem";
            this.updateProcedureToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.updateProcedureToolStripMenuItem.Text = "Update Procedure";
            this.updateProcedureToolStripMenuItem.Click += new System.EventHandler(this.updateProcedureToolStripMenuItem_Click);
            // 
            // procedureInfoToolStripMenuItem
            // 
            this.procedureInfoToolStripMenuItem.Image = global::HospitalSys.Properties.Resources.information;
            this.procedureInfoToolStripMenuItem.Name = "procedureInfoToolStripMenuItem";
            this.procedureInfoToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.procedureInfoToolStripMenuItem.Text = "Procedure Info";
            this.procedureInfoToolStripMenuItem.Click += new System.EventHandler(this.procedureInfoToolStripMenuItem_Click);
            // 
            // deleteProcedureToolStripMenuItem
            // 
            this.deleteProcedureToolStripMenuItem.Image = global::HospitalSys.Properties.Resources.cancel;
            this.deleteProcedureToolStripMenuItem.Name = "deleteProcedureToolStripMenuItem";
            this.deleteProcedureToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.deleteProcedureToolStripMenuItem.Text = "Delete Procedure";
            this.deleteProcedureToolStripMenuItem.Click += new System.EventHandler(this.deleteProcedureToolStripMenuItem_Click);
            // 
            // makeItFinishedToolStripMenuItem
            // 
            this.makeItFinishedToolStripMenuItem.Image = global::HospitalSys.Properties.Resources.appointment__1_;
            this.makeItFinishedToolStripMenuItem.Name = "makeItFinishedToolStripMenuItem";
            this.makeItFinishedToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.makeItFinishedToolStripMenuItem.Text = "Make it Finished";
            this.makeItFinishedToolStripMenuItem.Click += new System.EventHandler(this.makeItFinishedToolStripMenuItem_Click);
            // 
            // paientInfoToolStripMenuItem
            // 
            this.paientInfoToolStripMenuItem.Image = global::HospitalSys.Properties.Resources.examination;
            this.paientInfoToolStripMenuItem.Name = "paientInfoToolStripMenuItem";
            this.paientInfoToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.paientInfoToolStripMenuItem.Text = "PaientInfo";
            this.paientInfoToolStripMenuItem.Click += new System.EventHandler(this.paientInfoToolStripMenuItem_Click);
            // 
            // docotr1InfoToolStripMenuItem
            // 
            this.docotr1InfoToolStripMenuItem.Image = global::HospitalSys.Properties.Resources.medical__3_;
            this.docotr1InfoToolStripMenuItem.Name = "docotr1InfoToolStripMenuItem";
            this.docotr1InfoToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.docotr1InfoToolStripMenuItem.Text = "Docotr 1 Info";
            this.docotr1InfoToolStripMenuItem.Click += new System.EventHandler(this.docotr1InfoToolStripMenuItem_Click);
            // 
            // doctor2InfoToolStripMenuItem
            // 
            this.doctor2InfoToolStripMenuItem.Image = global::HospitalSys.Properties.Resources.medical__3_;
            this.doctor2InfoToolStripMenuItem.Name = "doctor2InfoToolStripMenuItem";
            this.doctor2InfoToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.doctor2InfoToolStripMenuItem.Text = "Doctor 2 Info";
            this.doctor2InfoToolStripMenuItem.Click += new System.EventHandler(this.doctor2InfoToolStripMenuItem_Click);
            // 
            // doctor3InfoToolStripMenuItem
            // 
            this.doctor3InfoToolStripMenuItem.Image = global::HospitalSys.Properties.Resources.medical__3_;
            this.doctor3InfoToolStripMenuItem.Name = "doctor3InfoToolStripMenuItem";
            this.doctor3InfoToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.doctor3InfoToolStripMenuItem.Text = "Doctor 3 Info";
            this.doctor3InfoToolStripMenuItem.Click += new System.EventHandler(this.doctor3InfoToolStripMenuItem_Click);
            // 
            // nurse1InfoToolStripMenuItem
            // 
            this.nurse1InfoToolStripMenuItem.Image = global::HospitalSys.Properties.Resources.medical_center;
            this.nurse1InfoToolStripMenuItem.Name = "nurse1InfoToolStripMenuItem";
            this.nurse1InfoToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.nurse1InfoToolStripMenuItem.Text = "Nurse 1 Info";
            this.nurse1InfoToolStripMenuItem.Click += new System.EventHandler(this.nurse1InfoToolStripMenuItem_Click);
            // 
            // nurse2InfoToolStripMenuItem
            // 
            this.nurse2InfoToolStripMenuItem.Image = global::HospitalSys.Properties.Resources.medical_center;
            this.nurse2InfoToolStripMenuItem.Name = "nurse2InfoToolStripMenuItem";
            this.nurse2InfoToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.nurse2InfoToolStripMenuItem.Text = "Nurse  2 Info";
            this.nurse2InfoToolStripMenuItem.Click += new System.EventHandler(this.nurse2InfoToolStripMenuItem_Click);
            // 
            // payProcedureCostToolStripMenuItem
            // 
            this.payProcedureCostToolStripMenuItem.Image = global::HospitalSys.Properties.Resources.pay_card;
            this.payProcedureCostToolStripMenuItem.Name = "payProcedureCostToolStripMenuItem";
            this.payProcedureCostToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.payProcedureCostToolStripMenuItem.Text = "Pay Procedure Cost";
            this.payProcedureCostToolStripMenuItem.Click += new System.EventHandler(this.payProcedureCostToolStripMenuItem_Click);
            // 
            // patientsProceduresToolStripMenuItem
            // 
            this.patientsProceduresToolStripMenuItem.Image = global::HospitalSys.Properties.Resources.nurses;
            this.patientsProceduresToolStripMenuItem.Name = "patientsProceduresToolStripMenuItem";
            this.patientsProceduresToolStripMenuItem.Size = new System.Drawing.Size(250, 32);
            this.patientsProceduresToolStripMenuItem.Text = "Patient\'s Procedures";
            this.patientsProceduresToolStripMenuItem.Click += new System.EventHandler(this.patientsProceduresToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.cbxActive);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Controls.Add(this.cbxFilter);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(1, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter:";
            // 
            // cbxActive
            // 
            this.cbxActive.FormattingEnabled = true;
            this.cbxActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbxActive.Location = new System.Drawing.Point(192, 26);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(115, 27);
            this.cbxActive.TabIndex = 2;
            this.cbxActive.Visible = false;
            this.cbxActive.SelectedIndexChanged += new System.EventHandler(this.cbxActive_SelectedIndexChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtFilter.Location = new System.Drawing.Point(192, 26);
            this.txtFilter.Multiline = true;
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(261, 27);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.Visible = false;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cbxFilter
            // 
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.Items.AddRange(new object[] {
            "None",
            "SurgeryProcedureID",
            "FirstDoctorID",
            "SecondDoctorID",
            "ThirdDoctorID",
            "FirstNurseID",
            "SecondNurseID",
            "PatientID",
            "RoomID",
            "IsFinish"});
            this.cbxFilter.Location = new System.Drawing.Point(11, 26);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(175, 27);
            this.cbxFilter.TabIndex = 0;
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1283, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(1422, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(377, 27);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(513, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "#Records:";
            // 
            // lbRecords
            // 
            this.lbRecords.AutoSize = true;
            this.lbRecords.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbRecords.Location = new System.Drawing.Point(634, 147);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(23, 24);
            this.lbRecords.TabIndex = 9;
            this.lbRecords.Text = "0";
            // 
            // ListOfSurgeryProcedures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1815, 718);
            this.Controls.Add(this.lbRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListOfSurgeryProcedures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListOfSurgeryProcedures";
            this.Load += new System.EventHandler(this.ListOfSurgeryProcedures_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxActive;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbxFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRecords;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateProcedureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procedureInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProcedureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeItFinishedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paientInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docotr1InfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctor2InfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctor3InfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nurse1InfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nurse2InfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payProcedureCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsProceduresToolStripMenuItem;
    }
}