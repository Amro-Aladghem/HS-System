namespace HospitalSys.LabTests
{
    partial class ctrBookANewLabTest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRecordIDSearch = new System.Windows.Forms.Button();
            this.txtPatientRecordID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbLapTest = new System.Windows.Forms.GroupBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lbIsPaid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxTestsTypes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateRequirdDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPatientID = new System.Windows.Forms.Label();
            this.lbPaitentRecordID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbLapTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.btnRecordIDSearch);
            this.groupBox1.Controls.Add(this.txtPatientRecordID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1065, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Patient Record";
            // 
            // btnRecordIDSearch
            // 
            this.btnRecordIDSearch.BackColor = System.Drawing.Color.White;
            this.btnRecordIDSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecordIDSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordIDSearch.Location = new System.Drawing.Point(844, 26);
            this.btnRecordIDSearch.Name = "btnRecordIDSearch";
            this.btnRecordIDSearch.Size = new System.Drawing.Size(76, 60);
            this.btnRecordIDSearch.TabIndex = 2;
            this.btnRecordIDSearch.UseVisualStyleBackColor = false;
            this.btnRecordIDSearch.Click += new System.EventHandler(this.btnRecordIDSearch_Click);
            // 
            // txtPatientRecordID
            // 
            this.txtPatientRecordID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientRecordID.Location = new System.Drawing.Point(420, 44);
            this.txtPatientRecordID.Name = "txtPatientRecordID";
            this.txtPatientRecordID.Size = new System.Drawing.Size(397, 32);
            this.txtPatientRecordID.TabIndex = 1;
            this.txtPatientRecordID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientRecordID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(68, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Record ID:";
            // 
            // gbLapTest
            // 
            this.gbLapTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbLapTest.Controls.Add(this.btnPay);
            this.gbLapTest.Controls.Add(this.lbIsPaid);
            this.gbLapTest.Controls.Add(this.label8);
            this.gbLapTest.Controls.Add(this.btnSave);
            this.gbLapTest.Controls.Add(this.cbxTestsTypes);
            this.gbLapTest.Controls.Add(this.label7);
            this.gbLapTest.Controls.Add(this.dateRequirdDate);
            this.gbLapTest.Controls.Add(this.label6);
            this.gbLapTest.Controls.Add(this.lbPatientID);
            this.gbLapTest.Controls.Add(this.lbPaitentRecordID);
            this.gbLapTest.Controls.Add(this.label3);
            this.gbLapTest.Controls.Add(this.label2);
            this.gbLapTest.Enabled = false;
            this.gbLapTest.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLapTest.Location = new System.Drawing.Point(14, 128);
            this.gbLapTest.Name = "gbLapTest";
            this.gbLapTest.Size = new System.Drawing.Size(1065, 377);
            this.gbLapTest.TabIndex = 1;
            this.gbLapTest.TabStop = false;
            this.gbLapTest.Text = "Book Lap Test";
            this.gbLapTest.Enter += new System.EventHandler(this.gbLapTest_Enter);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.White;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnPay.Location = new System.Drawing.Point(197, 290);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(258, 66);
            this.btnPay.TabIndex = 14;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lbIsPaid
            // 
            this.lbIsPaid.AutoSize = true;
            this.lbIsPaid.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lbIsPaid.Location = new System.Drawing.Point(697, 129);
            this.lbIsPaid.Name = "lbIsPaid";
            this.lbIsPaid.Size = new System.Drawing.Size(54, 34);
            this.lbIsPaid.TabIndex = 13;
            this.lbIsPaid.Text = "No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(536, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 34);
            this.label8.TabIndex = 12;
            this.label8.Text = "IsPaid:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(662, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(258, 66);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxTestsTypes
            // 
            this.cbxTestsTypes.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTestsTypes.FormattingEnabled = true;
            this.cbxTestsTypes.Location = new System.Drawing.Point(703, 56);
            this.cbxTestsTypes.Name = "cbxTestsTypes";
            this.cbxTestsTypes.Size = new System.Drawing.Size(315, 32);
            this.cbxTestsTypes.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(536, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 34);
            this.label7.TabIndex = 9;
            this.label7.Text = "Test Type:";
            // 
            // dateRequirdDate
            // 
            this.dateRequirdDate.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.dateRequirdDate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.dateRequirdDate.Location = new System.Drawing.Point(248, 208);
            this.dateRequirdDate.Name = "dateRequirdDate";
            this.dateRequirdDate.Size = new System.Drawing.Size(282, 32);
            this.dateRequirdDate.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(17, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 34);
            this.label6.TabIndex = 7;
            this.label6.Text = "Required date:";
            // 
            // lbPatientID
            // 
            this.lbPatientID.AutoSize = true;
            this.lbPatientID.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lbPatientID.Location = new System.Drawing.Point(300, 129);
            this.lbPatientID.Name = "lbPatientID";
            this.lbPatientID.Size = new System.Drawing.Size(89, 34);
            this.lbPatientID.TabIndex = 6;
            this.lbPatientID.Text = "[???]";
            // 
            // lbPaitentRecordID
            // 
            this.lbPaitentRecordID.AutoSize = true;
            this.lbPaitentRecordID.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lbPaitentRecordID.Location = new System.Drawing.Point(300, 51);
            this.lbPaitentRecordID.Name = "lbPaitentRecordID";
            this.lbPaitentRecordID.Size = new System.Drawing.Size(89, 34);
            this.lbPaitentRecordID.TabIndex = 5;
            this.lbPaitentRecordID.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(17, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patient ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient Record ID:";
            // 
            // ctrBookANewLabTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.gbLapTest);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrBookANewLabTest";
            this.Size = new System.Drawing.Size(1094, 524);
            this.Load += new System.EventHandler(this.ctrBookANewLabTest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbLapTest.ResumeLayout(false);
            this.gbLapTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPatientRecordID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRecordIDSearch;
        private System.Windows.Forms.GroupBox gbLapTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbPatientID;
        private System.Windows.Forms.Label lbPaitentRecordID;
        private System.Windows.Forms.ComboBox cbxTestsTypes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateRequirdDate;
        private System.Windows.Forms.Label lbIsPaid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPay;
    }
}
