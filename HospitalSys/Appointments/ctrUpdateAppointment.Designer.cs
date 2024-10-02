namespace HospitalSys.Appointments
{
    partial class ctrUpdateAppointment
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
            this.btnSave = new System.Windows.Forms.Button();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.gbAppInfo = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbAppError = new System.Windows.Forms.LinkLabel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.TimeOfAppointment = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateOfAppointment = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.lbChooseDoctor = new System.Windows.Forms.LinkLabel();
            this.lbDoctorID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbPersonInfo = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAppointmentID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAppInfo.SuspendLayout();
            this.gbPersonInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(321, 634);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(258, 59);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActive.Location = new System.Drawing.Point(21, 607);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(156, 38);
            this.cbIsActive.TabIndex = 20;
            this.cbIsActive.Text = "IsActive";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // gbAppInfo
            // 
            this.gbAppInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbAppInfo.Controls.Add(this.lbAppError);
            this.gbAppInfo.Controls.Add(this.btnReset);
            this.gbAppInfo.Controls.Add(this.btnCheck);
            this.gbAppInfo.Controls.Add(this.TimeOfAppointment);
            this.gbAppInfo.Controls.Add(this.label6);
            this.gbAppInfo.Controls.Add(this.dateOfAppointment);
            this.gbAppInfo.Controls.Add(this.label7);
            this.gbAppInfo.Controls.Add(this.lbChooseDoctor);
            this.gbAppInfo.Controls.Add(this.lbDoctorID);
            this.gbAppInfo.Controls.Add(this.label5);
            this.gbAppInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbAppInfo.Location = new System.Drawing.Point(21, 300);
            this.gbAppInfo.Name = "gbAppInfo";
            this.gbAppInfo.Size = new System.Drawing.Size(839, 288);
            this.gbAppInfo.TabIndex = 19;
            this.gbAppInfo.TabStop = false;
            this.gbAppInfo.Text = "Appointment Info:";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(358, 14);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(108, 38);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.btnCheck.Enabled = false;
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
            this.TimeOfAppointment.ValueChanged += new System.EventHandler(this.TimeOfAppointment_ValueChanged);
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
            this.dateOfAppointment.ValueChanged += new System.EventHandler(this.dateOfAppointment_ValueChanged);
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
            this.gbPersonInfo.Location = new System.Drawing.Point(21, 25);
            this.gbPersonInfo.Name = "gbPersonInfo";
            this.gbPersonInfo.Size = new System.Drawing.Size(839, 257);
            this.gbPersonInfo.TabIndex = 18;
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
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(249, 32);
            this.txtLastName.TabIndex = 3;
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
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(249, 32);
            this.txtFirstName.TabIndex = 1;
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
            // lbAppointmentID
            // 
            this.lbAppointmentID.AutoSize = true;
            this.lbAppointmentID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbAppointmentID.Location = new System.Drawing.Point(801, 607);
            this.lbAppointmentID.Name = "lbAppointmentID";
            this.lbAppointmentID.Size = new System.Drawing.Size(51, 24);
            this.lbAppointmentID.TabIndex = 23;
            this.lbAppointmentID.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(626, 607);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "AppointmentID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrUpdateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.lbAppointmentID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.gbAppInfo);
            this.Controls.Add(this.gbPersonInfo);
            this.Name = "ctrUpdateAppointment";
            this.Size = new System.Drawing.Size(878, 705);
            this.Load += new System.EventHandler(this.ctrUpdateAppointment_Load);
            this.gbAppInfo.ResumeLayout(false);
            this.gbAppInfo.PerformLayout();
            this.gbPersonInfo.ResumeLayout(false);
            this.gbPersonInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.GroupBox gbAppInfo;
        private System.Windows.Forms.LinkLabel lbAppError;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DateTimePicker TimeOfAppointment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateOfAppointment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel lbChooseDoctor;
        private System.Windows.Forms.Label lbDoctorID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbPersonInfo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAppointmentID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnReset;
    }
}
