namespace HospitalSys.Medicals
{
    partial class ctrFindMedicalRecordInStorage
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
            this.ctrMedicalRecordInfo1 = new HospitalSys.Medicals.ctrMedicalRecordInfo();
            this.gbQR = new System.Windows.Forms.GroupBox();
            this.btnDateSearch = new System.Windows.Forms.Button();
            this.dateProduced = new System.Windows.Forms.DateTimePicker();
            this.lbDate = new System.Windows.Forms.Label();
            this.btnQRSearch = new System.Windows.Forms.Button();
            this.txtMedicalQR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rdMedicalQR = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gbID = new System.Windows.Forms.GroupBox();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.txtMedicalID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbQR.SuspendLayout();
            this.gbID.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrMedicalRecordInfo1
            // 
            this.ctrMedicalRecordInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ctrMedicalRecordInfo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrMedicalRecordInfo1.Location = new System.Drawing.Point(14, 179);
            this.ctrMedicalRecordInfo1.Name = "ctrMedicalRecordInfo1";
            this.ctrMedicalRecordInfo1.Size = new System.Drawing.Size(847, 370);
            this.ctrMedicalRecordInfo1.TabIndex = 0;
            // 
            // gbQR
            // 
            this.gbQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbQR.Controls.Add(this.btnDateSearch);
            this.gbQR.Controls.Add(this.dateProduced);
            this.gbQR.Controls.Add(this.lbDate);
            this.gbQR.Controls.Add(this.btnQRSearch);
            this.gbQR.Controls.Add(this.txtMedicalQR);
            this.gbQR.Controls.Add(this.label1);
            this.gbQR.Location = new System.Drawing.Point(14, 48);
            this.gbQR.Name = "gbQR";
            this.gbQR.Size = new System.Drawing.Size(847, 114);
            this.gbQR.TabIndex = 1;
            this.gbQR.TabStop = false;
            this.gbQR.Text = "Searching";
            // 
            // btnDateSearch
            // 
            this.btnDateSearch.BackColor = System.Drawing.Color.White;
            this.btnDateSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDateSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateSearch.Location = new System.Drawing.Point(563, 75);
            this.btnDateSearch.Name = "btnDateSearch";
            this.btnDateSearch.Size = new System.Drawing.Size(40, 33);
            this.btnDateSearch.TabIndex = 5;
            this.btnDateSearch.UseVisualStyleBackColor = false;
            this.btnDateSearch.Visible = false;
            this.btnDateSearch.Click += new System.EventHandler(this.btnDateSearch_Click);
            // 
            // dateProduced
            // 
            this.dateProduced.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.dateProduced.Location = new System.Drawing.Point(268, 81);
            this.dateProduced.Name = "dateProduced";
            this.dateProduced.Size = new System.Drawing.Size(289, 27);
            this.dateProduced.TabIndex = 4;
            this.dateProduced.Visible = false;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lbDate.Location = new System.Drawing.Point(178, 81);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(93, 27);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "P.Date:";
            this.lbDate.Visible = false;
            // 
            // btnQRSearch
            // 
            this.btnQRSearch.BackColor = System.Drawing.Color.White;
            this.btnQRSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQRSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQRSearch.Location = new System.Drawing.Point(622, 15);
            this.btnQRSearch.Name = "btnQRSearch";
            this.btnQRSearch.Size = new System.Drawing.Size(61, 48);
            this.btnQRSearch.TabIndex = 2;
            this.btnQRSearch.UseVisualStyleBackColor = false;
            this.btnQRSearch.Click += new System.EventHandler(this.btnQRSearch_Click);
            // 
            // txtMedicalQR
            // 
            this.txtMedicalQR.Location = new System.Drawing.Point(268, 27);
            this.txtMedicalQR.Name = "txtMedicalQR";
            this.txtMedicalQR.Size = new System.Drawing.Size(332, 27);
            this.txtMedicalQR.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(101, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medical QR:";
            // 
            // rdMedicalQR
            // 
            this.rdMedicalQR.AutoSize = true;
            this.rdMedicalQR.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.rdMedicalQR.Location = new System.Drawing.Point(614, 6);
            this.rdMedicalQR.Name = "rdMedicalQR";
            this.rdMedicalQR.Size = new System.Drawing.Size(125, 23);
            this.rdMedicalQR.TabIndex = 2;
            this.rdMedicalQR.TabStop = true;
            this.rdMedicalQR.Text = "Medical QR";
            this.rdMedicalQR.UseVisualStyleBackColor = true;
            this.rdMedicalQR.CheckedChanged += new System.EventHandler(this.rdMedicalQR_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.radioButton1.Location = new System.Drawing.Point(740, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(120, 23);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Medical ID";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gbID
            // 
            this.gbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbID.Controls.Add(this.btnSearchID);
            this.gbID.Controls.Add(this.txtMedicalID);
            this.gbID.Controls.Add(this.label3);
            this.gbID.Location = new System.Drawing.Point(14, 42);
            this.gbID.Name = "gbID";
            this.gbID.Size = new System.Drawing.Size(847, 114);
            this.gbID.TabIndex = 6;
            this.gbID.TabStop = false;
            this.gbID.Text = "Searching";
            // 
            // btnSearchID
            // 
            this.btnSearchID.BackColor = System.Drawing.Color.White;
            this.btnSearchID.BackgroundImage = global::HospitalSys.Properties.Resources.research;
            this.btnSearchID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchID.Location = new System.Drawing.Point(648, 44);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(61, 48);
            this.btnSearchID.TabIndex = 2;
            this.btnSearchID.UseVisualStyleBackColor = false;
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // txtMedicalID
            // 
            this.txtMedicalID.Location = new System.Drawing.Point(310, 56);
            this.txtMedicalID.Name = "txtMedicalID";
            this.txtMedicalID.Size = new System.Drawing.Size(332, 27);
            this.txtMedicalID.TabIndex = 1;
            this.txtMedicalID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedicalID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(54, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Medical Record ID:";
            // 
            // ctrFindMedicalRecordInStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.gbID);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rdMedicalQR);
            this.Controls.Add(this.gbQR);
            this.Controls.Add(this.ctrMedicalRecordInfo1);
            this.Name = "ctrFindMedicalRecordInStorage";
            this.Size = new System.Drawing.Size(879, 570);
            this.Load += new System.EventHandler(this.ctrFindMedicalRecordInStorage_Load);
            this.gbQR.ResumeLayout(false);
            this.gbQR.PerformLayout();
            this.gbID.ResumeLayout(false);
            this.gbID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrMedicalRecordInfo ctrMedicalRecordInfo1;
        private System.Windows.Forms.GroupBox gbQR;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDateSearch;
        private System.Windows.Forms.DateTimePicker dateProduced;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Button btnQRSearch;
        private System.Windows.Forms.TextBox txtMedicalQR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdMedicalQR;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox gbID;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.TextBox txtMedicalID;
        private System.Windows.Forms.Label label3;
    }
}
