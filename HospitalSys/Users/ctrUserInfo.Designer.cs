namespace HospitalSys.Users
{
    partial class ctrUserInfo
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
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.lbUserID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.gbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUser
            // 
            this.gbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbUser.Controls.Add(this.lbUserID);
            this.gbUser.Controls.Add(this.label7);
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
            this.gbUser.Location = new System.Drawing.Point(13, 13);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(1030, 414);
            this.gbUser.TabIndex = 3;
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
            this.cbPermision.SelectedIndexChanged += new System.EventHandler(this.cbPermision_SelectedIndexChanged);
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
            this.cbActive.Enabled = false;
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
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPassword.Location = new System.Drawing.Point(667, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(259, 32);
            this.txtPassword.TabIndex = 10;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtUserName.Location = new System.Drawing.Point(212, 63);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(259, 32);
            this.txtUserName.TabIndex = 9;
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
            // ctrUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.gbUser);
            this.Name = "ctrUserInfo";
            this.Size = new System.Drawing.Size(1059, 448);
            this.Load += new System.EventHandler(this.ctrUserInfo_Load);
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox cbPermision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Label lbPerson;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}
