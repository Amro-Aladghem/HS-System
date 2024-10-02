﻿namespace HospitalSys.Medicals
{
    partial class ctrAddNewMedicalsInStorage
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
            this.components = new System.ComponentModel.Container();
            this.gbSearching = new System.Windows.Forms.GroupBox();
            this.btnMedicalQR = new System.Windows.Forms.Button();
            this.txtMedicalQR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbRecordInfo = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateExpired = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.numaricPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numaricQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMedicalQR = new System.Windows.Forms.Label();
            this.lbMedicalID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbAddNewMedical = new System.Windows.Forms.LinkLabel();
            this.gbSearching.SuspendLayout();
            this.gbRecordInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numaricPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaricQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearching
            // 
            this.gbSearching.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbSearching.Controls.Add(this.lbAddNewMedical);
            this.gbSearching.Controls.Add(this.btnMedicalQR);
            this.gbSearching.Controls.Add(this.txtMedicalQR);
            this.gbSearching.Controls.Add(this.label1);
            this.gbSearching.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbSearching.Location = new System.Drawing.Point(17, 21);
            this.gbSearching.Name = "gbSearching";
            this.gbSearching.Size = new System.Drawing.Size(821, 95);
            this.gbSearching.TabIndex = 0;
            this.gbSearching.TabStop = false;
            this.gbSearching.Text = "Searching Medical:";
            // 
            // btnMedicalQR
            // 
            this.btnMedicalQR.BackColor = System.Drawing.Color.White;
            this.btnMedicalQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMedicalQR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicalQR.Location = new System.Drawing.Point(606, 24);
            this.btnMedicalQR.Name = "btnMedicalQR";
            this.btnMedicalQR.Size = new System.Drawing.Size(57, 45);
            this.btnMedicalQR.TabIndex = 2;
            this.btnMedicalQR.UseVisualStyleBackColor = false;
            this.btnMedicalQR.Click += new System.EventHandler(this.btnMedicalQR_Click);
            // 
            // txtMedicalQR
            // 
            this.txtMedicalQR.Location = new System.Drawing.Point(252, 34);
            this.txtMedicalQR.Multiline = true;
            this.txtMedicalQR.Name = "txtMedicalQR";
            this.txtMedicalQR.Size = new System.Drawing.Size(323, 29);
            this.txtMedicalQR.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(91, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medical QR:";
            // 
            // gbRecordInfo
            // 
            this.gbRecordInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbRecordInfo.Controls.Add(this.btnSave);
            this.gbRecordInfo.Controls.Add(this.dateExpired);
            this.gbRecordInfo.Controls.Add(this.label7);
            this.gbRecordInfo.Controls.Add(this.dateTimePicker1);
            this.gbRecordInfo.Controls.Add(this.label6);
            this.gbRecordInfo.Controls.Add(this.numaricPrice);
            this.gbRecordInfo.Controls.Add(this.label5);
            this.gbRecordInfo.Controls.Add(this.numaricQuantity);
            this.gbRecordInfo.Controls.Add(this.label4);
            this.gbRecordInfo.Controls.Add(this.lbMedicalQR);
            this.gbRecordInfo.Controls.Add(this.lbMedicalID);
            this.gbRecordInfo.Controls.Add(this.label3);
            this.gbRecordInfo.Controls.Add(this.label2);
            this.gbRecordInfo.Enabled = false;
            this.gbRecordInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbRecordInfo.Location = new System.Drawing.Point(17, 122);
            this.gbRecordInfo.Name = "gbRecordInfo";
            this.gbRecordInfo.Size = new System.Drawing.Size(821, 344);
            this.gbRecordInfo.TabIndex = 1;
            this.gbRecordInfo.TabStop = false;
            this.gbRecordInfo.Text = "Record Info";
            this.gbRecordInfo.Enter += new System.EventHandler(this.gbRecordInfo_Enter);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(630, 286);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(185, 52);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateExpired
            // 
            this.dateExpired.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.dateExpired.Location = new System.Drawing.Point(392, 195);
            this.dateExpired.Name = "dateExpired";
            this.dateExpired.Size = new System.Drawing.Size(293, 32);
            this.dateExpired.TabIndex = 14;
            this.dateExpired.Validating += new System.ComponentModel.CancelEventHandler(this.dateExpired_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(387, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Expired Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(392, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 32);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker1_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(387, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Prouced Date:";
            // 
            // numaricPrice
            // 
            this.numaricPrice.DecimalPlaces = 2;
            this.numaricPrice.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.numaricPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numaricPrice.Location = new System.Drawing.Point(159, 269);
            this.numaricPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numaricPrice.Name = "numaricPrice";
            this.numaricPrice.Size = new System.Drawing.Size(120, 32);
            this.numaricPrice.TabIndex = 10;
            this.numaricPrice.Validating += new System.ComponentModel.CancelEventHandler(this.numaricPrice_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(21, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price:";
            // 
            // numaricQuantity
            // 
            this.numaricQuantity.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.numaricQuantity.Location = new System.Drawing.Point(159, 195);
            this.numaricQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numaricQuantity.Name = "numaricQuantity";
            this.numaricQuantity.Size = new System.Drawing.Size(120, 32);
            this.numaricQuantity.TabIndex = 8;
            this.numaricQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.numaricQuantity_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(21, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantitiy:";
            // 
            // lbMedicalQR
            // 
            this.lbMedicalQR.AutoSize = true;
            this.lbMedicalQR.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbMedicalQR.Location = new System.Drawing.Point(199, 125);
            this.lbMedicalQR.Name = "lbMedicalQR";
            this.lbMedicalQR.Size = new System.Drawing.Size(62, 29);
            this.lbMedicalQR.TabIndex = 6;
            this.lbMedicalQR.Text = "N/A";
            // 
            // lbMedicalID
            // 
            this.lbMedicalID.AutoSize = true;
            this.lbMedicalID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbMedicalID.Location = new System.Drawing.Point(199, 51);
            this.lbMedicalID.Name = "lbMedicalID";
            this.lbMedicalID.Size = new System.Drawing.Size(62, 29);
            this.lbMedicalID.TabIndex = 5;
            this.lbMedicalID.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Medical QR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Medical ID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbAddNewMedical
            // 
            this.lbAddNewMedical.AutoSize = true;
            this.lbAddNewMedical.BackColor = System.Drawing.Color.Black;
            this.lbAddNewMedical.LinkColor = System.Drawing.Color.White;
            this.lbAddNewMedical.Location = new System.Drawing.Point(655, 76);
            this.lbAddNewMedical.Name = "lbAddNewMedical";
            this.lbAddNewMedical.Size = new System.Drawing.Size(166, 19);
            this.lbAddNewMedical.TabIndex = 3;
            this.lbAddNewMedical.TabStop = true;
            this.lbAddNewMedical.Text = "Click Here if it New";
            this.lbAddNewMedical.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbAddNewMedical_LinkClicked);
            // 
            // ctrAddNewMedicalsInStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.gbRecordInfo);
            this.Controls.Add(this.gbSearching);
            this.Name = "ctrAddNewMedicalsInStorage";
            this.Size = new System.Drawing.Size(855, 485);
            this.Load += new System.EventHandler(this.ctrAddNewMedicalsInStorage_Load);
            this.gbSearching.ResumeLayout(false);
            this.gbSearching.PerformLayout();
            this.gbRecordInfo.ResumeLayout(false);
            this.gbRecordInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numaricPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaricQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearching;
        private System.Windows.Forms.TextBox txtMedicalQR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMedicalQR;
        private System.Windows.Forms.GroupBox gbRecordInfo;
        private System.Windows.Forms.DateTimePicker dateExpired;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numaricPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numaricQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMedicalQR;
        private System.Windows.Forms.Label lbMedicalID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel lbAddNewMedical;
    }
}
