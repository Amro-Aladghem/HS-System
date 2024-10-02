namespace HospitalSys.OtherEmployee
{
    partial class ctrFindEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrFindEmployee));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdName = new System.Windows.Forms.RadioButton();
            this.rdNurseID = new System.Windows.Forms.RadioButton();
            this.gbEmployeeID = new System.Windows.Forms.GroupBox();
            this.txtIDSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrEmployeInfo1 = new HospitalSys.OtherEmployee.ctrEmployeInfo();
            this.btnNameSearch = new System.Windows.Forms.Button();
            this.btnIDSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbEmployeeID.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.btnNameSearch);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1205, 104);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
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
            // rdName
            // 
            this.rdName.AutoSize = true;
            this.rdName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.rdName.Location = new System.Drawing.Point(1148, 0);
            this.rdName.Name = "rdName";
            this.rdName.Size = new System.Drawing.Size(81, 23);
            this.rdName.TabIndex = 11;
            this.rdName.TabStop = true;
            this.rdName.Text = "Name";
            this.rdName.UseVisualStyleBackColor = true;
            this.rdName.CheckedChanged += new System.EventHandler(this.rdName_CheckedChanged);
            // 
            // rdNurseID
            // 
            this.rdNurseID.AutoSize = true;
            this.rdNurseID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.rdNurseID.Location = new System.Drawing.Point(999, 0);
            this.rdNurseID.Name = "rdNurseID";
            this.rdNurseID.Size = new System.Drawing.Size(137, 23);
            this.rdNurseID.TabIndex = 9;
            this.rdNurseID.TabStop = true;
            this.rdNurseID.Text = "Employee ID";
            this.rdNurseID.UseVisualStyleBackColor = true;
            this.rdNurseID.CheckedChanged += new System.EventHandler(this.rdNurseID_CheckedChanged);
            // 
            // gbEmployeeID
            // 
            this.gbEmployeeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbEmployeeID.Controls.Add(this.btnIDSearch);
            this.gbEmployeeID.Controls.Add(this.txtIDSearch);
            this.gbEmployeeID.Controls.Add(this.label1);
            this.gbEmployeeID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbEmployeeID.Location = new System.Drawing.Point(18, 23);
            this.gbEmployeeID.Name = "gbEmployeeID";
            this.gbEmployeeID.Size = new System.Drawing.Size(1205, 110);
            this.gbEmployeeID.TabIndex = 8;
            this.gbEmployeeID.TabStop = false;
            this.gbEmployeeID.Text = "By NurseID";
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
            this.label1.Location = new System.Drawing.Point(84, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID :";
            // 
            // ctrEmployeInfo1
            // 
            this.ctrEmployeInfo1.BackColor = System.Drawing.Color.Red;
            this.ctrEmployeInfo1.Location = new System.Drawing.Point(80, 139);
            this.ctrEmployeInfo1.Name = "ctrEmployeInfo1";
            this.ctrEmployeInfo1.Size = new System.Drawing.Size(1085, 412);
            this.ctrEmployeInfo1.TabIndex = 0;
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
            // ctrFindEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdName);
            this.Controls.Add(this.rdNurseID);
            this.Controls.Add(this.gbEmployeeID);
            this.Controls.Add(this.ctrEmployeInfo1);
            this.Name = "ctrFindEmployee";
            this.Size = new System.Drawing.Size(1240, 568);
            this.Load += new System.EventHandler(this.ctrFindEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEmployeeID.ResumeLayout(false);
            this.gbEmployeeID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrEmployeInfo ctrEmployeInfo1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNameSearch;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdName;
        private System.Windows.Forms.RadioButton rdNurseID;
        private System.Windows.Forms.GroupBox gbEmployeeID;
        private System.Windows.Forms.Button btnIDSearch;
        private System.Windows.Forms.TextBox txtIDSearch;
        private System.Windows.Forms.Label label1;
    }
}
