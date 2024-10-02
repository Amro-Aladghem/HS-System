namespace HospitalSys.Patients
{
    partial class ctrPatientInfoWithFilter
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
            this.ctrPatientInfo1 = new HospitalSys.Patients.ctrPatientInfo();
            this.gbPatientID = new System.Windows.Forms.GroupBox();
            this.btnPatientSearch = new System.Windows.Forms.Button();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdPatientID = new System.Windows.Forms.RadioButton();
            this.rdNationalNum = new System.Windows.Forms.RadioButton();
            this.gbNationalNum = new System.Windows.Forms.GroupBox();
            this.btnNationalSearch = new System.Windows.Forms.Button();
            this.txtNationalNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPatientID.SuspendLayout();
            this.gbNationalNum.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrPatientInfo1
            // 
            this.ctrPatientInfo1.BackColor = System.Drawing.Color.Red;
            this.ctrPatientInfo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrPatientInfo1.Location = new System.Drawing.Point(29, 156);
            this.ctrPatientInfo1.Name = "ctrPatientInfo1";
            this.ctrPatientInfo1.Size = new System.Drawing.Size(1049, 495);
            this.ctrPatientInfo1.TabIndex = 0;
            // 
            // gbPatientID
            // 
            this.gbPatientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gbPatientID.Controls.Add(this.btnPatientSearch);
            this.gbPatientID.Controls.Add(this.txtPatientID);
            this.gbPatientID.Controls.Add(this.label1);
            this.gbPatientID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbPatientID.Location = new System.Drawing.Point(29, 25);
            this.gbPatientID.Name = "gbPatientID";
            this.gbPatientID.Size = new System.Drawing.Size(1049, 100);
            this.gbPatientID.TabIndex = 1;
            this.gbPatientID.TabStop = false;
            this.gbPatientID.Text = "Find By:";
            // 
            // btnPatientSearch
            // 
            this.btnPatientSearch.BackColor = System.Drawing.Color.White;
            this.btnPatientSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientSearch.Location = new System.Drawing.Point(788, 23);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(104, 70);
            this.btnPatientSearch.TabIndex = 2;
            this.btnPatientSearch.UseVisualStyleBackColor = false;
            this.btnPatientSearch.Click += new System.EventHandler(this.btnPatientSearch_Click);
            // 
            // txtPatientID
            // 
            this.txtPatientID.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.txtPatientID.Location = new System.Drawing.Point(380, 36);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(359, 41);
            this.txtPatientID.TabIndex = 1;
            this.txtPatientID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(135, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "PatientID:";
            // 
            // rdPatientID
            // 
            this.rdPatientID.AutoSize = true;
            this.rdPatientID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.rdPatientID.Location = new System.Drawing.Point(817, 3);
            this.rdPatientID.Name = "rdPatientID";
            this.rdPatientID.Size = new System.Drawing.Size(113, 23);
            this.rdPatientID.TabIndex = 2;
            this.rdPatientID.TabStop = true;
            this.rdPatientID.Text = "PatientID";
            this.rdPatientID.UseVisualStyleBackColor = true;
            this.rdPatientID.CheckedChanged += new System.EventHandler(this.rdPatientID_CheckedChanged);
            // 
            // rdNationalNum
            // 
            this.rdNationalNum.AutoSize = true;
            this.rdNationalNum.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.rdNationalNum.Location = new System.Drawing.Point(938, 3);
            this.rdNationalNum.Name = "rdNationalNum";
            this.rdNationalNum.Size = new System.Drawing.Size(140, 23);
            this.rdNationalNum.TabIndex = 3;
            this.rdNationalNum.TabStop = true;
            this.rdNationalNum.Text = "NationalNum";
            this.rdNationalNum.UseVisualStyleBackColor = true;
            this.rdNationalNum.CheckedChanged += new System.EventHandler(this.rdNationalNum_CheckedChanged);
            // 
            // gbNationalNum
            // 
            this.gbNationalNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gbNationalNum.Controls.Add(this.btnNationalSearch);
            this.gbNationalNum.Controls.Add(this.txtNationalNum);
            this.gbNationalNum.Controls.Add(this.label2);
            this.gbNationalNum.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbNationalNum.Location = new System.Drawing.Point(23, 32);
            this.gbNationalNum.Name = "gbNationalNum";
            this.gbNationalNum.Size = new System.Drawing.Size(1049, 100);
            this.gbNationalNum.TabIndex = 2;
            this.gbNationalNum.TabStop = false;
            this.gbNationalNum.Text = "Find By:";
            // 
            // btnNationalSearch
            // 
            this.btnNationalSearch.BackColor = System.Drawing.Color.White;
            this.btnNationalSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNationalSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNationalSearch.Location = new System.Drawing.Point(797, 23);
            this.btnNationalSearch.Name = "btnNationalSearch";
            this.btnNationalSearch.Size = new System.Drawing.Size(104, 70);
            this.btnNationalSearch.TabIndex = 5;
            this.btnNationalSearch.UseVisualStyleBackColor = false;
            this.btnNationalSearch.Click += new System.EventHandler(this.btnNationalSearch_Click);
            // 
            // txtNationalNum
            // 
            this.txtNationalNum.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.txtNationalNum.Location = new System.Drawing.Point(381, 35);
            this.txtNationalNum.Name = "txtNationalNum";
            this.txtNationalNum.Size = new System.Drawing.Size(359, 41);
            this.txtNationalNum.TabIndex = 4;
            this.txtNationalNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNationalNum_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(47, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 53);
            this.label2.TabIndex = 3;
            this.label2.Text = "NationalNum:";
            // 
            // ctrPatientInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.gbNationalNum);
            this.Controls.Add(this.rdNationalNum);
            this.Controls.Add(this.rdPatientID);
            this.Controls.Add(this.gbPatientID);
            this.Controls.Add(this.ctrPatientInfo1);
            this.Name = "ctrPatientInfoWithFilter";
            this.Size = new System.Drawing.Size(1102, 678);
            this.Load += new System.EventHandler(this.ctrPatientInfoWithFilter_Load);
            this.gbPatientID.ResumeLayout(false);
            this.gbPatientID.PerformLayout();
            this.gbNationalNum.ResumeLayout(false);
            this.gbNationalNum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrPatientInfo ctrPatientInfo1;
        private System.Windows.Forms.GroupBox gbPatientID;
        private System.Windows.Forms.RadioButton rdPatientID;
        private System.Windows.Forms.RadioButton rdNationalNum;
        private System.Windows.Forms.Button btnPatientSearch;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbNationalNum;
        private System.Windows.Forms.Button btnNationalSearch;
        private System.Windows.Forms.TextBox txtNationalNum;
        private System.Windows.Forms.Label label2;
    }
}
