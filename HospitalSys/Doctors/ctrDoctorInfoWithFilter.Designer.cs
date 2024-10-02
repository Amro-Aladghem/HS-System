namespace HospitalSys.Doctors
{
    partial class ctrDoctorInfoWithFilter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrDoctorInfoWithFilter));
            this.gbDoctorID = new System.Windows.Forms.GroupBox();
            this.btnIDSearch = new System.Windows.Forms.Button();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdDoctorID = new System.Windows.Forms.RadioButton();
            this.rdName = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNameSearch = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrDoctorInfo1 = new HospitalSys.Doctors.ctrDoctorInfo();
            this.gbDoctorID.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDoctorID
            // 
            this.gbDoctorID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbDoctorID.Controls.Add(this.btnIDSearch);
            this.gbDoctorID.Controls.Add(this.txtIDSearch);
            this.gbDoctorID.Controls.Add(this.label1);
            this.gbDoctorID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbDoctorID.Location = new System.Drawing.Point(15, 26);
            this.gbDoctorID.Name = "gbDoctorID";
            this.gbDoctorID.Size = new System.Drawing.Size(1205, 110);
            this.gbDoctorID.TabIndex = 1;
            this.gbDoctorID.TabStop = false;
            this.gbDoctorID.Text = "By DoctorID";
            // 
            // btnIDSearch
            // 
            this.btnIDSearch.BackColor = System.Drawing.Color.White;
            this.btnIDSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIDSearch.BackgroundImage")));
            this.btnIDSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIDSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIDSearch.Location = new System.Drawing.Point(845, 26);
            this.btnIDSearch.Name = "btnIDSearch";
            this.btnIDSearch.Size = new System.Drawing.Size(89, 69);
            this.btnIDSearch.TabIndex = 2;
            this.btnIDSearch.UseVisualStyleBackColor = false;
            this.btnIDSearch.Click += new System.EventHandler(this.btnIDSearch_Click);
            // 
            // txtIDSearch
            // 
            this.txtIDSearch.Location = new System.Drawing.Point(394, 45);
            this.txtIDSearch.Multiline = true;
            this.txtIDSearch.Name = "txtIDSearch";
            this.txtIDSearch.Size = new System.Drawing.Size(401, 37);
            this.txtIDSearch.TabIndex = 1;
            this.txtIDSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDSearch_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(145, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor ID :";
            // 
            // rdDoctorID
            // 
            this.rdDoctorID.AutoSize = true;
            this.rdDoctorID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.rdDoctorID.Location = new System.Drawing.Point(932, 3);
            this.rdDoctorID.Name = "rdDoctorID";
            this.rdDoctorID.Size = new System.Drawing.Size(107, 23);
            this.rdDoctorID.TabIndex = 2;
            this.rdDoctorID.TabStop = true;
            this.rdDoctorID.Text = "DoctorID";
            this.rdDoctorID.UseVisualStyleBackColor = true;
            this.rdDoctorID.CheckedChanged += new System.EventHandler(this.rdDoctorID_CheckedChanged);
            // 
            // rdName
            // 
            this.rdName.AutoSize = true;
            this.rdName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.rdName.Location = new System.Drawing.Point(1064, 3);
            this.rdName.Name = "rdName";
            this.rdName.Size = new System.Drawing.Size(81, 23);
            this.rdName.TabIndex = 3;
            this.rdName.TabStop = true;
            this.rdName.Text = "Name";
            this.rdName.UseVisualStyleBackColor = true;
            this.rdName.CheckedChanged += new System.EventHandler(this.rdName_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.btnNameSearch);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1205, 104);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // btnNameSearch
            // 
            this.btnNameSearch.BackColor = System.Drawing.Color.White;
            this.btnNameSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNameSearch.BackgroundImage")));
            this.btnNameSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNameSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNameSearch.Location = new System.Drawing.Point(1061, 23);
            this.btnNameSearch.Name = "btnNameSearch";
            this.btnNameSearch.Size = new System.Drawing.Size(89, 69);
            this.btnNameSearch.TabIndex = 3;
            this.btnNameSearch.UseVisualStyleBackColor = false;
            this.btnNameSearch.Click += new System.EventHandler(this.btnNameSearch_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(717, 48);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(259, 27);
            this.txtLastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(544, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "LastName:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(236, 45);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(259, 27);
            this.txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(60, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "FirstName:";
            // 
            // ctrDoctorInfo1
            // 
            this.ctrDoctorInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ctrDoctorInfo1.Location = new System.Drawing.Point(15, 142);
            this.ctrDoctorInfo1.Name = "ctrDoctorInfo1";
            this.ctrDoctorInfo1.Size = new System.Drawing.Size(1205, 546);
            this.ctrDoctorInfo1.TabIndex = 4;
            // 
            // ctrDoctorInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.ctrDoctorInfo1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdName);
            this.Controls.Add(this.rdDoctorID);
            this.Controls.Add(this.gbDoctorID);
            this.Name = "ctrDoctorInfoWithFilter";
            this.Size = new System.Drawing.Size(1233, 700);
            this.Load += new System.EventHandler(this.ctrDoctorInfoWithFilter_Load);
            this.gbDoctorID.ResumeLayout(false);
            this.gbDoctorID.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDoctorID;
        private System.Windows.Forms.Button btnIDSearch;
        private System.Windows.Forms.TextBox txtIDSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdDoctorID;
        private System.Windows.Forms.RadioButton rdName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNameSearch;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private ctrDoctorInfo ctrDoctorInfo1;
    }
}
