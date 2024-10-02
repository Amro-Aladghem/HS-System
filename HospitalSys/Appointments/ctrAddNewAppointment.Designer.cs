namespace HospitalSys.Appointments
{
    partial class ctrAddNewAppointment
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
            this.gbPersonInfo = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAppInfo = new System.Windows.Forms.GroupBox();
            this.lbAppError = new System.Windows.Forms.LinkLabel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.TimeOfAppointment = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateOfAppointment = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lbChooseDoctor = new System.Windows.Forms.LinkLabel();
            this.lbDoctorID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.lbAppointmentID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNationalNum = new System.Windows.Forms.TextBox();
            this.lbNotFound = new System.Windows.Forms.LinkLabel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbPersonInfo.SuspendLayout();
            this.gbAppInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPersonInfo
            // 
            this.gbPersonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbPersonInfo.Controls.Add(this.txtAddress);
            this.gbPersonInfo.Controls.Add(this.label4);
            this.gbPersonInfo.Controls.Add(this.txtPhone);
            this.gbPersonInfo.Controls.Add(this.label3);
            this.gbPersonInfo.Controls.Add(this.txtLastName);
            this.gbPersonInfo.Controls.Add(this.label2);
            this.gbPersonInfo.Controls.Add(this.txtFirstName);
            this.gbPersonInfo.Controls.Add(this.label1);
            this.gbPersonInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbPersonInfo.Location = new System.Drawing.Point(15, 63);
            this.gbPersonInfo.Name = "gbPersonInfo";
            this.gbPersonInfo.Size = new System.Drawing.Size(839, 257);
            this.gbPersonInfo.TabIndex = 0;
            this.gbPersonInfo.TabStop = false;
            this.gbPersonInfo.Text = "Person Info:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtAddress.Location = new System.Drawing.Point(575, 47);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(249, 169);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Addres:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtPhone.Location = new System.Drawing.Point(201, 182);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(249, 32);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "PhoneNum:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtLastName.Location = new System.Drawing.Point(201, 114);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(249, 32);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtFirstName.Location = new System.Drawing.Point(201, 47);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(249, 32);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // gbAppInfo
            // 
            this.gbAppInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbAppInfo.Controls.Add(this.lbAppError);
            this.gbAppInfo.Controls.Add(this.btnCheck);
            this.gbAppInfo.Controls.Add(this.TimeOfAppointment);
            this.gbAppInfo.Controls.Add(this.label6);
            this.gbAppInfo.Controls.Add(this.dateOfAppointment);
            this.gbAppInfo.Controls.Add(this.label7);
            this.gbAppInfo.Controls.Add(this.lbChooseDoctor);
            this.gbAppInfo.Controls.Add(this.lbDoctorID);
            this.gbAppInfo.Controls.Add(this.label5);
            this.gbAppInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbAppInfo.Location = new System.Drawing.Point(15, 338);
            this.gbAppInfo.Name = "gbAppInfo";
            this.gbAppInfo.Size = new System.Drawing.Size(839, 288);
            this.gbAppInfo.TabIndex = 8;
            this.gbAppInfo.TabStop = false;
            this.gbAppInfo.Text = "Appointment Info:";
            // 
            // lbAppError
            // 
            this.lbAppError.AutoSize = true;
            this.lbAppError.BackColor = System.Drawing.Color.Gold;
            this.lbAppError.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppError.LinkColor = System.Drawing.Color.Red;
            this.lbAppError.Location = new System.Drawing.Point(419, 224);
            this.lbAppError.Name = "lbAppError";
            this.lbAppError.Size = new System.Drawing.Size(378, 58);
            this.lbAppError.TabIndex = 17;
            this.lbAppError.TabStop = true;
            this.lbAppError.Text = "There is An Appointment With \r\nSame Date And Time";
            this.lbAppError.Visible = false;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.White;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnCheck.Location = new System.Drawing.Point(28, 234);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(189, 48);
            this.btnCheck.TabIndex = 16;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // TimeOfAppointment
            // 
            this.TimeOfAppointment.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOfAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeOfAppointment.Location = new System.Drawing.Point(369, 176);
            this.TimeOfAppointment.Name = "TimeOfAppointment";
            this.TimeOfAppointment.ShowUpDown = true;
            this.TimeOfAppointment.Size = new System.Drawing.Size(409, 32);
            this.TimeOfAppointment.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(327, 34);
            this.label6.TabIndex = 14;
            this.label6.Text = "Time Of Appointment:";
            // 
            // dateOfAppointment
            // 
            this.dateOfAppointment.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfAppointment.Location = new System.Drawing.Point(369, 109);
            this.dateOfAppointment.Name = "dateOfAppointment";
            this.dateOfAppointment.Size = new System.Drawing.Size(409, 32);
            this.dateOfAppointment.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(325, 34);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date Of Appointment:";
            // 
            // lbChooseDoctor
            // 
            this.lbChooseDoctor.AutoSize = true;
            this.lbChooseDoctor.BackColor = System.Drawing.Color.Black;
            this.lbChooseDoctor.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbChooseDoctor.LinkColor = System.Drawing.Color.White;
            this.lbChooseDoctor.Location = new System.Drawing.Point(497, 57);
            this.lbChooseDoctor.Name = "lbChooseDoctor";
            this.lbChooseDoctor.Size = new System.Drawing.Size(281, 24);
            this.lbChooseDoctor.TabIndex = 10;
            this.lbChooseDoctor.TabStop = true;
            this.lbChooseDoctor.Text = "Click Here To Choos Doctor";
            this.lbChooseDoctor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbChooseDoctor_LinkClicked);
            // 
            // lbDoctorID
            // 
            this.lbDoctorID.AutoSize = true;
            this.lbDoctorID.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoctorID.Location = new System.Drawing.Point(182, 47);
            this.lbDoctorID.Name = "lbDoctorID";
            this.lbDoctorID.Size = new System.Drawing.Size(72, 34);
            this.lbDoctorID.TabIndex = 9;
            this.lbDoctorID.Text = "N/A";
            this.lbDoctorID.Validating += new System.ComponentModel.CancelEventHandler(this.lbDoctorID_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "DoctorID:";
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Checked = true;
            this.cbIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsActive.Enabled = false;
            this.cbIsActive.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActive.Location = new System.Drawing.Point(15, 645);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(156, 38);
            this.cbIsActive.TabIndex = 9;
            this.cbIsActive.Text = "IsActive";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(317, 673);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(258, 59);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(628, 645);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "AppointmentID:";
            // 
            // lbAppointmentID
            // 
            this.lbAppointmentID.AutoSize = true;
            this.lbAppointmentID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbAppointmentID.Location = new System.Drawing.Point(803, 645);
            this.lbAppointmentID.Name = "lbAppointmentID";
            this.lbAppointmentID.Size = new System.Drawing.Size(51, 24);
            this.lbAppointmentID.TabIndex = 19;
            this.lbAppointmentID.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "National.Num:";
            // 
            // txtNationalNum
            // 
            this.txtNationalNum.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.txtNationalNum.Location = new System.Drawing.Point(192, 23);
            this.txtNationalNum.Name = "txtNationalNum";
            this.txtNationalNum.Size = new System.Drawing.Size(288, 29);
            this.txtNationalNum.TabIndex = 0;
            this.txtNationalNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNationalNum_KeyDown);
            this.txtNationalNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalNum_KeyPress);
            // 
            // lbNotFound
            // 
            this.lbNotFound.AutoSize = true;
            this.lbNotFound.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotFound.LinkColor = System.Drawing.Color.Red;
            this.lbNotFound.Location = new System.Drawing.Point(535, 21);
            this.lbNotFound.Name = "lbNotFound";
            this.lbNotFound.Size = new System.Drawing.Size(344, 38);
            this.lbNotFound.TabIndex = 23;
            this.lbNotFound.TabStop = true;
            this.lbNotFound.Text = "This Patient Not Found,Click here to add \r\nor You can skip";
            this.lbNotFound.Visible = false;
            this.lbNotFound.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbNotFound_LinkClicked);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;

            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(486, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(43, 30);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ctrAddNewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.lbNotFound);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtNationalNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbAppointmentID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.gbAppInfo);
            this.Controls.Add(this.gbPersonInfo);
            this.Name = "ctrAddNewAppointment";
            this.Size = new System.Drawing.Size(874, 737);
            this.Load += new System.EventHandler(this.ctrAddNewAppointment_Load);
            this.gbPersonInfo.ResumeLayout(false);
            this.gbPersonInfo.PerformLayout();
            this.gbAppInfo.ResumeLayout(false);
            this.gbAppInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersonInfo;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbAppInfo;
        private System.Windows.Forms.Label lbDoctorID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DateTimePicker TimeOfAppointment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateOfAppointment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel lbChooseDoctor;
        private System.Windows.Forms.LinkLabel lbAppError;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbAppointmentID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel lbNotFound;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtNationalNum;
        private System.Windows.Forms.Label label9;
    }
}
