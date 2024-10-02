namespace HospitalSys.PateintsRecords
{
    partial class ctrUpdatePatientRecordHS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbChangeRoom = new System.Windows.Forms.CheckBox();
            this.cbxRoomsNumber = new System.Windows.Forms.ComboBox();
            this.lbRoomNum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbChangingDoctor = new System.Windows.Forms.LinkLabel();
            this.lbDoctorID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSymptoms = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDateOfArraivel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPatientID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRecordID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbIsLeaved = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.cbChangeRoom);
            this.groupBox1.Controls.Add(this.cbxRoomsNumber);
            this.groupBox1.Controls.Add(this.lbRoomNum);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbChangingDoctor);
            this.groupBox1.Controls.Add(this.lbDoctorID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDiagnosis);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSymptoms);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbDateOfArraivel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbPatientID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbRecordID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 609);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Record Info";
            // 
            // cbChangeRoom
            // 
            this.cbChangeRoom.AutoSize = true;
            this.cbChangeRoom.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbChangeRoom.Location = new System.Drawing.Point(500, 559);
            this.cbChangeRoom.Name = "cbChangeRoom";
            this.cbChangeRoom.Size = new System.Drawing.Size(186, 23);
            this.cbChangeRoom.TabIndex = 16;
            this.cbChangeRoom.Text = "Click here To Change";
            this.cbChangeRoom.UseVisualStyleBackColor = true;
            this.cbChangeRoom.CheckedChanged += new System.EventHandler(this.cbChangeRoom_CheckedChanged);
            // 
            // cbxRoomsNumber
            // 
            this.cbxRoomsNumber.Enabled = false;
            this.cbxRoomsNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.cbxRoomsNumber.FormattingEnabled = true;
            this.cbxRoomsNumber.Location = new System.Drawing.Point(373, 523);
            this.cbxRoomsNumber.Name = "cbxRoomsNumber";
            this.cbxRoomsNumber.Size = new System.Drawing.Size(313, 30);
            this.cbxRoomsNumber.TabIndex = 15;
            this.cbxRoomsNumber.SelectedIndexChanged += new System.EventHandler(this.cbxRoomsNumber_SelectedIndexChanged);
            // 
            // lbRoomNum
            // 
            this.lbRoomNum.AutoSize = true;
            this.lbRoomNum.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lbRoomNum.Location = new System.Drawing.Point(199, 523);
            this.lbRoomNum.Name = "lbRoomNum";
            this.lbRoomNum.Size = new System.Drawing.Size(72, 34);
            this.lbRoomNum.TabIndex = 14;
            this.lbRoomNum.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(20, 523);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 34);
            this.label8.TabIndex = 13;
            this.label8.Text = "RoomNum:";
            // 
            // lbChangingDoctor
            // 
            this.lbChangingDoctor.AutoSize = true;
            this.lbChangingDoctor.BackColor = System.Drawing.Color.Black;
            this.lbChangingDoctor.LinkColor = System.Drawing.Color.White;
            this.lbChangingDoctor.Location = new System.Drawing.Point(369, 457);
            this.lbChangingDoctor.Name = "lbChangingDoctor";
            this.lbChangingDoctor.Size = new System.Drawing.Size(214, 19);
            this.lbChangingDoctor.TabIndex = 12;
            this.lbChangingDoctor.TabStop = true;
            this.lbChangingDoctor.Text = "Click Here To Change Doctor";
            this.lbChangingDoctor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbChangingDoctor_LinkClicked);
            // 
            // lbDoctorID
            // 
            this.lbDoctorID.AutoSize = true;
            this.lbDoctorID.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lbDoctorID.Location = new System.Drawing.Point(199, 448);
            this.lbDoctorID.Name = "lbDoctorID";
            this.lbDoctorID.Size = new System.Drawing.Size(72, 34);
            this.lbDoctorID.TabIndex = 11;
            this.lbDoctorID.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(20, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 34);
            this.label7.TabIndex = 10;
            this.label7.Text = "DoctorID:";
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtDiagnosis.Location = new System.Drawing.Point(373, 306);
            this.txtDiagnosis.Multiline = true;
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(294, 95);
            this.txtDiagnosis.TabIndex = 9;
            this.txtDiagnosis.Validating += new System.ComponentModel.CancelEventHandler(this.txtDiagnosis_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(367, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 34);
            this.label6.TabIndex = 8;
            this.label6.Text = "Diagnosis:";
            // 
            // txtSymptoms
            // 
            this.txtSymptoms.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtSymptoms.Location = new System.Drawing.Point(23, 306);
            this.txtSymptoms.Multiline = true;
            this.txtSymptoms.Name = "txtSymptoms";
            this.txtSymptoms.Size = new System.Drawing.Size(294, 95);
            this.txtSymptoms.TabIndex = 7;
            this.txtSymptoms.Validating += new System.ComponentModel.CancelEventHandler(this.txtSymptoms_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(17, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 34);
            this.label5.TabIndex = 6;
            this.label5.Text = "Symptoms:";
            // 
            // lbDateOfArraivel
            // 
            this.lbDateOfArraivel.AutoSize = true;
            this.lbDateOfArraivel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lbDateOfArraivel.Location = new System.Drawing.Point(245, 181);
            this.lbDateOfArraivel.Name = "lbDateOfArraivel";
            this.lbDateOfArraivel.Size = new System.Drawing.Size(72, 34);
            this.lbDateOfArraivel.TabIndex = 5;
            this.lbDateOfArraivel.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(17, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "DateOfArriavle:";
            // 
            // lbPatientID
            // 
            this.lbPatientID.AutoSize = true;
            this.lbPatientID.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lbPatientID.Location = new System.Drawing.Point(245, 111);
            this.lbPatientID.Name = "lbPatientID";
            this.lbPatientID.Size = new System.Drawing.Size(72, 34);
            this.lbPatientID.TabIndex = 3;
            this.lbPatientID.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(17, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "PatientID:";
            // 
            // lbRecordID
            // 
            this.lbRecordID.AutoSize = true;
            this.lbRecordID.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lbRecordID.Location = new System.Drawing.Point(245, 43);
            this.lbRecordID.Name = "lbRecordID";
            this.lbRecordID.Size = new System.Drawing.Size(72, 34);
            this.lbRecordID.TabIndex = 1;
            this.lbRecordID.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "RecordID:";
            // 
            // cbIsLeaved
            // 
            this.cbIsLeaved.AutoSize = true;
            this.cbIsLeaved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cbIsLeaved.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsLeaved.Location = new System.Drawing.Point(16, 643);
            this.cbIsLeaved.Name = "cbIsLeaved";
            this.cbIsLeaved.Size = new System.Drawing.Size(162, 33);
            this.cbIsLeaved.TabIndex = 1;
            this.cbIsLeaved.Text = "Is Leaved ";
            this.cbIsLeaved.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(492, 659);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(210, 54);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // ctrUpdatePatientRecordHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbIsLeaved);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrUpdatePatientRecordHS";
            this.Size = new System.Drawing.Size(726, 728);
            this.Load += new System.EventHandler(this.ctrUpdatePatientRecordHS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDateOfArraivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPatientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRecordID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSymptoms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lbChangingDoctor;
        private System.Windows.Forms.Label lbDoctorID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbChangeRoom;
        private System.Windows.Forms.ComboBox cbxRoomsNumber;
        private System.Windows.Forms.Label lbRoomNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbIsLeaved;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}
