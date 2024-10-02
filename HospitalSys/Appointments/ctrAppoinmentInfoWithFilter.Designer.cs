namespace HospitalSys.Appointments
{
    partial class ctrAppoinmentInfoWithFilter
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
            this.gbSearchID = new System.Windows.Forms.GroupBox();
            this.btnAppointmentID = new System.Windows.Forms.Button();
            this.txtAppoinmentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrAppointmentInfo1 = new HospitalSys.Appointments.ctrAppointmentInfo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdName = new System.Windows.Forms.RadioButton();
            this.rdID = new System.Windows.Forms.RadioButton();
            this.gbSearchID.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearchID
            // 
            this.gbSearchID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbSearchID.Controls.Add(this.btnAppointmentID);
            this.gbSearchID.Controls.Add(this.txtAppoinmentID);
            this.gbSearchID.Controls.Add(this.label1);
            this.gbSearchID.Location = new System.Drawing.Point(13, 38);
            this.gbSearchID.Name = "gbSearchID";
            this.gbSearchID.Size = new System.Drawing.Size(1090, 100);
            this.gbSearchID.TabIndex = 0;
            this.gbSearchID.TabStop = false;
            this.gbSearchID.Text = "Search ID";
            // 
            // btnAppointmentID
            // 
            this.btnAppointmentID.BackColor = System.Drawing.Color.White;
            this.btnAppointmentID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAppointmentID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointmentID.Location = new System.Drawing.Point(831, 26);
            this.btnAppointmentID.Name = "btnAppointmentID";
            this.btnAppointmentID.Size = new System.Drawing.Size(82, 68);
            this.btnAppointmentID.TabIndex = 2;
            this.btnAppointmentID.UseVisualStyleBackColor = false;
            this.btnAppointmentID.Click += new System.EventHandler(this.btnAppointmentID_Click);
            // 
            // txtAppoinmentID
            // 
            this.txtAppoinmentID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppoinmentID.Location = new System.Drawing.Point(403, 41);
            this.txtAppoinmentID.Name = "txtAppoinmentID";
            this.txtAppoinmentID.Size = new System.Drawing.Size(410, 36);
            this.txtAppoinmentID.TabIndex = 1;
            this.txtAppoinmentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAppoinmentID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(131, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "AppointmentID:";
            // 
            // ctrAppointmentInfo1
            // 
            this.ctrAppointmentInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ctrAppointmentInfo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrAppointmentInfo1.Location = new System.Drawing.Point(13, 155);
            this.ctrAppointmentInfo1.Name = "ctrAppointmentInfo1";
            this.ctrAppointmentInfo1.Size = new System.Drawing.Size(1090, 463);
            this.ctrAppointmentInfo1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSearchName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1090, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search ID";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(682, 38);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(253, 36);
            this.txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(487, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "LastName:";
            // 
            // btnSearchName
            // 
            this.btnSearchName.BackColor = System.Drawing.Color.White;
            this.btnSearchName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchName.Location = new System.Drawing.Point(967, 24);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(82, 68);
            this.btnSearchName.TabIndex = 2;
            this.btnSearchName.UseVisualStyleBackColor = false;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(212, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(253, 36);
            this.txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "FirstName:";
            // 
            // rdName
            // 
            this.rdName.AutoSize = true;
            this.rdName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdName.Location = new System.Drawing.Point(963, 3);
            this.rdName.Name = "rdName";
            this.rdName.Size = new System.Drawing.Size(81, 23);
            this.rdName.TabIndex = 4;
            this.rdName.TabStop = true;
            this.rdName.Text = "Name";
            this.rdName.UseVisualStyleBackColor = true;
            this.rdName.CheckedChanged += new System.EventHandler(this.rdName_CheckedChanged);
            // 
            // rdID
            // 
            this.rdID.AutoSize = true;
            this.rdID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdID.Location = new System.Drawing.Point(1050, 3);
            this.rdID.Name = "rdID";
            this.rdID.Size = new System.Drawing.Size(53, 23);
            this.rdID.TabIndex = 5;
            this.rdID.TabStop = true;
            this.rdID.Text = "ID";
            this.rdID.UseVisualStyleBackColor = true;
            this.rdID.CheckedChanged += new System.EventHandler(this.rdID_CheckedChanged);
            // 
            // ctrAppoinmentInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.rdID);
            this.Controls.Add(this.rdName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrAppointmentInfo1);
            this.Controls.Add(this.gbSearchID);
            this.Name = "ctrAppoinmentInfoWithFilter";
            this.Size = new System.Drawing.Size(1119, 635);
            this.gbSearchID.ResumeLayout(false);
            this.gbSearchID.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchID;
        private ctrAppointmentInfo ctrAppointmentInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAppointmentID;
        private System.Windows.Forms.TextBox txtAppoinmentID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdName;
        private System.Windows.Forms.RadioButton rdID;
    }
}
