namespace HospitalSys.Payments
{
    partial class PaymentInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPaymentID = new System.Windows.Forms.Label();
            this.lbRecordID = new System.Windows.Forms.Label();
            this.lbPatientID = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbPaidAmount = new System.Windows.Forms.Label();
            this.lbReturnAmount = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1136, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Info:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = global::HospitalSys.Properties.Resources.cancel;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1007, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 100);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::HospitalSys.Properties.Resources.check_mark;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(494, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.lbUserID);
            this.panel2.Controls.Add(this.lbReturnAmount);
            this.panel2.Controls.Add(this.lbPaidAmount);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbDate);
            this.panel2.Controls.Add(this.lbPatientID);
            this.panel2.Controls.Add(this.lbRecordID);
            this.panel2.Controls.Add(this.lbPaymentID);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(20, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1106, 476);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(32, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "PaymentID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(32, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "PatientRecordID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(32, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 39);
            this.label4.TabIndex = 2;
            this.label4.Text = "PatientID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(32, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 39);
            this.label5.TabIndex = 3;
            this.label5.Text = "Date:";
            // 
            // lbPaymentID
            // 
            this.lbPaymentID.AutoSize = true;
            this.lbPaymentID.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lbPaymentID.Location = new System.Drawing.Point(329, 41);
            this.lbPaymentID.Name = "lbPaymentID";
            this.lbPaymentID.Size = new System.Drawing.Size(101, 39);
            this.lbPaymentID.TabIndex = 4;
            this.lbPaymentID.Text = "[???]";
            // 
            // lbRecordID
            // 
            this.lbRecordID.AutoSize = true;
            this.lbRecordID.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lbRecordID.Location = new System.Drawing.Point(329, 141);
            this.lbRecordID.Name = "lbRecordID";
            this.lbRecordID.Size = new System.Drawing.Size(101, 39);
            this.lbRecordID.TabIndex = 5;
            this.lbRecordID.Text = "[???]";
            // 
            // lbPatientID
            // 
            this.lbPatientID.AutoSize = true;
            this.lbPatientID.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lbPatientID.Location = new System.Drawing.Point(329, 233);
            this.lbPatientID.Name = "lbPatientID";
            this.lbPatientID.Size = new System.Drawing.Size(101, 39);
            this.lbPatientID.TabIndex = 6;
            this.lbPatientID.Text = "[???]";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lbDate.Location = new System.Drawing.Point(329, 323);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(101, 39);
            this.lbDate.TabIndex = 7;
            this.lbDate.Text = "[???]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(569, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 39);
            this.label6.TabIndex = 8;
            this.label6.Text = "PaidAmount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(569, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 39);
            this.label7.TabIndex = 9;
            this.label7.Text = "ReturnAmount:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(569, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 39);
            this.label8.TabIndex = 10;
            this.label8.Text = "UserID:";
            // 
            // lbPaidAmount
            // 
            this.lbPaidAmount.AutoSize = true;
            this.lbPaidAmount.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lbPaidAmount.Location = new System.Drawing.Point(842, 41);
            this.lbPaidAmount.Name = "lbPaidAmount";
            this.lbPaidAmount.Size = new System.Drawing.Size(101, 39);
            this.lbPaidAmount.TabIndex = 11;
            this.lbPaidAmount.Text = "[???]";
            // 
            // lbReturnAmount
            // 
            this.lbReturnAmount.AutoSize = true;
            this.lbReturnAmount.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lbReturnAmount.Location = new System.Drawing.Point(842, 141);
            this.lbReturnAmount.Name = "lbReturnAmount";
            this.lbReturnAmount.Size = new System.Drawing.Size(101, 39);
            this.lbReturnAmount.TabIndex = 12;
            this.lbReturnAmount.Text = "[???]";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lbUserID.Location = new System.Drawing.Point(842, 233);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(101, 39);
            this.lbUserID.TabIndex = 13;
            this.lbUserID.Text = "[???]";
            // 
            // PaymentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1138, 606);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentInfo";
            this.Load += new System.EventHandler(this.PaymentInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbPatientID;
        private System.Windows.Forms.Label lbRecordID;
        private System.Windows.Forms.Label lbPaymentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label lbReturnAmount;
        private System.Windows.Forms.Label lbPaidAmount;
        private System.Windows.Forms.Label label8;
    }
}