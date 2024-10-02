namespace HospitalSys.PateintsRecords
{
    partial class ctrAddNewPatientRecordHS
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
            this.gbFindPatient = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrPatientInfo1 = new HospitalSys.Patients.ctrPatientInfo();
            this.cbWithRoom = new System.Windows.Forms.CheckBox();
            this.gbRoom = new System.Windows.Forms.GroupBox();
            this.cbxRoomNum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbInformations = new System.Windows.Forms.GroupBox();
            this.lbChoosingDoctor = new System.Windows.Forms.LinkLabel();
            this.lbDoctorID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiagnosis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSymptoms = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFindPatient.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbRoom.SuspendLayout();
            this.gbInformations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFindPatient
            // 
            this.gbFindPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbFindPatient.Controls.Add(this.btnSearch);
            this.gbFindPatient.Controls.Add(this.txtPatientID);
            this.gbFindPatient.Controls.Add(this.label1);
            this.gbFindPatient.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbFindPatient.Location = new System.Drawing.Point(17, 12);
            this.gbFindPatient.Name = "gbFindPatient";
            this.gbFindPatient.Size = new System.Drawing.Size(857, 100);
            this.gbFindPatient.TabIndex = 0;
            this.gbFindPatient.TabStop = false;
            this.gbFindPatient.Text = "Find Patient";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(629, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 69);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPatientID
            // 
            this.txtPatientID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtPatientID.Location = new System.Drawing.Point(264, 43);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(317, 32);
            this.txtPatientID.TabIndex = 1;
            this.txtPatientID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(63, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient ID:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.ctrPatientInfo1);
            this.panel1.Location = new System.Drawing.Point(17, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 428);
            this.panel1.TabIndex = 1;
            // 
            // ctrPatientInfo1
            // 
            this.ctrPatientInfo1.BackColor = System.Drawing.Color.Red;
            this.ctrPatientInfo1.Location = new System.Drawing.Point(-30, 0);
            this.ctrPatientInfo1.Name = "ctrPatientInfo1";
            this.ctrPatientInfo1.Size = new System.Drawing.Size(1049, 495);
            this.ctrPatientInfo1.TabIndex = 0;
            // 
            // cbWithRoom
            // 
            this.cbWithRoom.AutoSize = true;
            this.cbWithRoom.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.cbWithRoom.Location = new System.Drawing.Point(17, 575);
            this.cbWithRoom.Name = "cbWithRoom";
            this.cbWithRoom.Size = new System.Drawing.Size(136, 26);
            this.cbWithRoom.TabIndex = 2;
            this.cbWithRoom.Text = "With Room";
            this.cbWithRoom.UseVisualStyleBackColor = true;
            this.cbWithRoom.CheckedChanged += new System.EventHandler(this.cbWithRoom_CheckedChanged);
            // 
            // gbRoom
            // 
            this.gbRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbRoom.Controls.Add(this.cbxRoomNum);
            this.gbRoom.Controls.Add(this.label2);
            this.gbRoom.Enabled = false;
            this.gbRoom.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbRoom.Location = new System.Drawing.Point(17, 610);
            this.gbRoom.Name = "gbRoom";
            this.gbRoom.Size = new System.Drawing.Size(857, 80);
            this.gbRoom.TabIndex = 3;
            this.gbRoom.TabStop = false;
            this.gbRoom.Text = "Choose Room";
            // 
            // cbxRoomNum
            // 
            this.cbxRoomNum.FormattingEnabled = true;
            this.cbxRoomNum.Location = new System.Drawing.Point(370, 35);
            this.cbxRoomNum.Name = "cbxRoomNum";
            this.cbxRoomNum.Size = new System.Drawing.Size(260, 27);
            this.cbxRoomNum.TabIndex = 1;
            this.cbxRoomNum.SelectedIndexChanged += new System.EventHandler(this.cbxRoomNum_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(153, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Room Number:";
            // 
            // gbInformations
            // 
            this.gbInformations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbInformations.Controls.Add(this.lbChoosingDoctor);
            this.gbInformations.Controls.Add(this.lbDoctorID);
            this.gbInformations.Controls.Add(this.label5);
            this.gbInformations.Controls.Add(this.txtDiagnosis);
            this.gbInformations.Controls.Add(this.label4);
            this.gbInformations.Controls.Add(this.txtSymptoms);
            this.gbInformations.Controls.Add(this.label3);
            this.gbInformations.Enabled = false;
            this.gbInformations.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbInformations.Location = new System.Drawing.Point(902, 22);
            this.gbInformations.Name = "gbInformations";
            this.gbInformations.Size = new System.Drawing.Size(604, 537);
            this.gbInformations.TabIndex = 4;
            this.gbInformations.TabStop = false;
            this.gbInformations.Text = "Informations";
            // 
            // lbChoosingDoctor
            // 
            this.lbChoosingDoctor.AutoSize = true;
            this.lbChoosingDoctor.BackColor = System.Drawing.Color.Black;
            this.lbChoosingDoctor.LinkColor = System.Drawing.Color.Transparent;
            this.lbChoosingDoctor.Location = new System.Drawing.Point(23, 396);
            this.lbChoosingDoctor.Name = "lbChoosingDoctor";
            this.lbChoosingDoctor.Size = new System.Drawing.Size(436, 19);
            this.lbChoosingDoctor.TabIndex = 6;
            this.lbChoosingDoctor.TabStop = true;
            this.lbChoosingDoctor.Text = "Click Here To Add Available Doctor with this Patient";
            this.lbChoosingDoctor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbChoosingDoctor_LinkClicked);
            // 
            // lbDoctorID
            // 
            this.lbDoctorID.AutoSize = true;
            this.lbDoctorID.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lbDoctorID.Location = new System.Drawing.Point(287, 336);
            this.lbDoctorID.Name = "lbDoctorID";
            this.lbDoctorID.Size = new System.Drawing.Size(67, 31);
            this.lbDoctorID.TabIndex = 5;
            this.lbDoctorID.Text = "N/A";
            this.lbDoctorID.TextChanged += new System.EventHandler(this.lbDoctorID_TextChanged);
            this.lbDoctorID.Validating += new System.ComponentModel.CancelEventHandler(this.lbDoctorID_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(21, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "DoctorAssignedID:\r\n";
            // 
            // txtDiagnosis
            // 
            this.txtDiagnosis.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtDiagnosis.Location = new System.Drawing.Point(187, 178);
            this.txtDiagnosis.Multiline = true;
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(351, 87);
            this.txtDiagnosis.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(21, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Diagnosis:";
            // 
            // txtSymptoms
            // 
            this.txtSymptoms.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtSymptoms.Location = new System.Drawing.Point(187, 38);
            this.txtSymptoms.Multiline = true;
            this.txtSymptoms.Name = "txtSymptoms";
            this.txtSymptoms.Size = new System.Drawing.Size(351, 87);
            this.txtSymptoms.TabIndex = 1;
            this.txtSymptoms.Validating += new System.ComponentModel.CancelEventHandler(this.txtSymptoms_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Symptoms:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(1066, 625);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(313, 65);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrAddNewPatientRecordHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbInformations);
            this.Controls.Add(this.gbRoom);
            this.Controls.Add(this.cbWithRoom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbFindPatient);
            this.Name = "ctrAddNewPatientRecordHS";
            this.Size = new System.Drawing.Size(1527, 710);
            this.Load += new System.EventHandler(this.ctrAddNewPatientRecordHS_Load);
            this.gbFindPatient.ResumeLayout(false);
            this.gbFindPatient.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbRoom.ResumeLayout(false);
            this.gbRoom.PerformLayout();
            this.gbInformations.ResumeLayout(false);
            this.gbInformations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFindPatient;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private Patients.ctrPatientInfo ctrPatientInfo1;
        private System.Windows.Forms.CheckBox cbWithRoom;
        private System.Windows.Forms.GroupBox gbRoom;
        private System.Windows.Forms.ComboBox cbxRoomNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbInformations;
        private System.Windows.Forms.TextBox txtSymptoms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lbChoosingDoctor;
        private System.Windows.Forms.Label lbDoctorID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiagnosis;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
