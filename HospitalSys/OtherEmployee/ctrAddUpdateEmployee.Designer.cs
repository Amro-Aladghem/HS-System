namespace HospitalSys.OtherEmployee
{
    partial class ctrAddUpdateEmployee
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
            this.gbFullName = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbEmployeeID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbJobType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSection = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.numaricSalary = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimeBirth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNationalNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFullName.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numaricSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFullName
            // 
            this.gbFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbFullName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbFullName.Controls.Add(this.txtLastName);
            this.gbFullName.Controls.Add(this.label3);
            this.gbFullName.Controls.Add(this.txtSecondName);
            this.gbFullName.Controls.Add(this.label2);
            this.gbFullName.Controls.Add(this.txtFirstName);
            this.gbFullName.Controls.Add(this.label1);
            this.gbFullName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbFullName.Location = new System.Drawing.Point(13, 14);
            this.gbFullName.Name = "gbFullName";
            this.gbFullName.Size = new System.Drawing.Size(877, 123);
            this.gbFullName.TabIndex = 1;
            this.gbFullName.TabStop = false;
            this.gbFullName.Text = "Doctor Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(650, 68);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(189, 33);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(662, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // txtSecondName
            // 
            this.txtSecondName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName.Location = new System.Drawing.Point(340, 68);
            this.txtSecondName.Multiline = true;
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(189, 33);
            this.txtSecondName.TabIndex = 3;
            this.txtSecondName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSecondName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(334, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(34, 68);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(189, 33);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.lbEmployeeID);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbJobType);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbSection);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.rdFemale);
            this.groupBox2.Controls.Add(this.rdMale);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.numaricSalary);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dateTimeBirth);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNationalNum);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(13, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(877, 393);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(700, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(171, 55);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbEmployeeID
            // 
            this.lbEmployeeID.AutoSize = true;
            this.lbEmployeeID.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lbEmployeeID.ForeColor = System.Drawing.Color.White;
            this.lbEmployeeID.Location = new System.Drawing.Point(583, 257);
            this.lbEmployeeID.Name = "lbEmployeeID";
            this.lbEmployeeID.Size = new System.Drawing.Size(67, 31);
            this.lbEmployeeID.TabIndex = 25;
            this.lbEmployeeID.Text = "N/A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(433, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 31);
            this.label12.TabIndex = 24;
            this.label12.Text = "ID           :";
            // 
            // cbJobType
            // 
            this.cbJobType.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbJobType.FormattingEnabled = true;
            this.cbJobType.Location = new System.Drawing.Point(580, 192);
            this.cbJobType.Name = "cbJobType";
            this.cbJobType.Size = new System.Drawing.Size(256, 32);
            this.cbJobType.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(431, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 31);
            this.label8.TabIndex = 22;
            this.label8.Text = "Job Type :";
            // 
            // cbSection
            // 
            this.cbSection.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbSection.FormattingEnabled = true;
            this.cbSection.Location = new System.Drawing.Point(147, 312);
            this.cbSection.Name = "cbSection";
            this.cbSection.Size = new System.Drawing.Size(256, 32);
            this.cbSection.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(28, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 31);
            this.label11.TabIndex = 20;
            this.label11.Text = "Section:";
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.rdFemale.Location = new System.Drawing.Point(253, 257);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(108, 28);
            this.rdFemale.TabIndex = 19;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.rdMale.Location = new System.Drawing.Point(150, 257);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(83, 28);
            this.rdMale.TabIndex = 18;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Male";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(27, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 31);
            this.label10.TabIndex = 17;
            this.label10.Text = "Gendor:";
            // 
            // numaricSalary
            // 
            this.numaricSalary.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.numaricSalary.Location = new System.Drawing.Point(146, 188);
            this.numaricSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numaricSalary.Name = "numaricSalary";
            this.numaricSalary.Size = new System.Drawing.Size(257, 32);
            this.numaricSalary.TabIndex = 16;
            this.numaricSalary.Validating += new System.ComponentModel.CancelEventHandler(this.numaricSalary_Validating_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(28, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 31);
            this.label9.TabIndex = 15;
            this.label9.Text = "Salary :";
            // 
            // dateTimeBirth
            // 
            this.dateTimeBirth.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.dateTimeBirth.Location = new System.Drawing.Point(580, 113);
            this.dateTimeBirth.Name = "dateTimeBirth";
            this.dateTimeBirth.Size = new System.Drawing.Size(259, 32);
            this.dateTimeBirth.TabIndex = 12;
            this.dateTimeBirth.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimeBirth_Validating_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(431, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Birth       :";
            // 
            // txtNationalNum
            // 
            this.txtNationalNum.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalNum.Location = new System.Drawing.Point(580, 49);
            this.txtNationalNum.MaxLength = 100;
            this.txtNationalNum.Multiline = true;
            this.txtNationalNum.Name = "txtNationalNum";
            this.txtNationalNum.Size = new System.Drawing.Size(259, 33);
            this.txtNationalNum.TabIndex = 10;
            this.txtNationalNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalNum_KeyPress);
            this.txtNationalNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalNum_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(431, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "No.Num  :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(146, 111);
            this.txtEmail.MaxLength = 1000;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(257, 33);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(28, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email  :";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(147, 51);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(256, 33);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress_1);
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrAddUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbFullName);
            this.Name = "ctrAddUpdateEmployee";
            this.Size = new System.Drawing.Size(909, 564);
            this.Load += new System.EventHandler(this.ctrAddUpdateEmployee_Load);
            this.gbFullName.ResumeLayout(false);
            this.gbFullName.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numaricSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFullName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbEmployeeID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbJobType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbSection;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numaricSalary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimeBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNationalNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
