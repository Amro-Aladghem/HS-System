﻿namespace HospitalSys.Users
{
    partial class ctrAddUser
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtEnterID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPositions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbPermision = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.lbPerson = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.gbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtEnterID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxPositions);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Person";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = global::HospitalSys.Properties.Resources.recent;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(931, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 71);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEnterID
            // 
            this.txtEnterID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtEnterID.Location = new System.Drawing.Point(598, 51);
            this.txtEnterID.Name = "txtEnterID";
            this.txtEnterID.Size = new System.Drawing.Size(301, 32);
            this.txtEnterID.TabIndex = 3;
            this.txtEnterID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnterID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(458, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter ID:";
            // 
            // cbxPositions
            // 
            this.cbxPositions.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.cbxPositions.FormattingEnabled = true;
            this.cbxPositions.Items.AddRange(new object[] {
            "Doctor",
            "Nurse",
            "OtherEmployee"});
            this.cbxPositions.Location = new System.Drawing.Point(150, 47);
            this.cbxPositions.Name = "cbxPositions";
            this.cbxPositions.Size = new System.Drawing.Size(251, 32);
            this.cbxPositions.TabIndex = 1;
            this.cbxPositions.SelectedIndexChanged += new System.EventHandler(this.cbxPositions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Position:";
            // 
            // gbUser
            // 
            this.gbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbUser.Controls.Add(this.lbUserID);
            this.gbUser.Controls.Add(this.label7);
            this.gbUser.Controls.Add(this.btnSave);
            this.gbUser.Controls.Add(this.cbPermision);
            this.gbUser.Controls.Add(this.label8);
            this.gbUser.Controls.Add(this.cbActive);
            this.gbUser.Controls.Add(this.lbPerson);
            this.gbUser.Controls.Add(this.txtPassword);
            this.gbUser.Controls.Add(this.txtUserName);
            this.gbUser.Controls.Add(this.label6);
            this.gbUser.Controls.Add(this.label5);
            this.gbUser.Controls.Add(this.label4);
            this.gbUser.Controls.Add(this.label3);
            this.gbUser.Enabled = false;
            this.gbUser.Location = new System.Drawing.Point(16, 130);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(1030, 414);
            this.gbUser.TabIndex = 1;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "User Info";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbUserID.Location = new System.Drawing.Point(634, 226);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(76, 36);
            this.lbUserID.TabIndex = 18;
            this.lbUserID.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(489, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 36);
            this.label7.TabIndex = 17;
            this.label7.Text = "UserID:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(798, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(214, 61);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbPermision
            // 
            this.cbPermision.FormattingEnabled = true;
            this.cbPermision.Items.AddRange(new object[] {
            "Appointment",
            "Patinet",
            "Doctors",
            "Employees",
            "Invoices",
            "Medicals",
            "Laps",
            "Rooms",
            "Users",
            "Seugery ",
            "Ware House",
            "Managment"});
            this.cbPermision.Location = new System.Drawing.Point(228, 236);
            this.cbPermision.Name = "cbPermision";
            this.cbPermision.Size = new System.Drawing.Size(173, 172);
            this.cbPermision.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(15, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 36);
            this.label8.TabIndex = 13;
            this.label8.Text = "Permisisons:";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Checked = true;
            this.cbActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbActive.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActive.Location = new System.Drawing.Point(667, 155);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(99, 28);
            this.cbActive.TabIndex = 12;
            this.cbActive.Text = "Active";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // lbPerson
            // 
            this.lbPerson.AutoSize = true;
            this.lbPerson.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbPerson.Location = new System.Drawing.Point(206, 142);
            this.lbPerson.Name = "lbPerson";
            this.lbPerson.Size = new System.Drawing.Size(94, 36);
            this.lbPerson.TabIndex = 11;
            this.lbPerson.Text = "[???]";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPassword.Location = new System.Drawing.Point(667, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(259, 32);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtUserName.Location = new System.Drawing.Point(212, 63);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(259, 32);
            this.txtUserName.TabIndex = 9;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(489, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "IsActive:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(489, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "PersonID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "User Name:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.gbUser);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrAddUser";
            this.Size = new System.Drawing.Size(1064, 566);
            this.Load += new System.EventHandler(this.ctrAddUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPositions;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtEnterID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckedListBox cbPermision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Label lbPerson;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label7;
    }
}
