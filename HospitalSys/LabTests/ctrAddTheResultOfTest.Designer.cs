namespace HospitalSys.LabTests
{
    partial class ctrAddTheResultOfTest
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
            this.gbSetFile = new System.Windows.Forms.GroupBox();
            this.lbFilePath = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctrTestLapInfoWithFilter1 = new HospitalSys.LabTests.ctrTestLapInfoWithFilter();
            this.gbSetFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSetFile
            // 
            this.gbSetFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbSetFile.Controls.Add(this.lbFilePath);
            this.gbSetFile.Controls.Add(this.label1);
            this.gbSetFile.Controls.Add(this.btnSelectFile);
            this.gbSetFile.Enabled = false;
            this.gbSetFile.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbSetFile.Location = new System.Drawing.Point(3, 628);
            this.gbSetFile.Name = "gbSetFile";
            this.gbSetFile.Size = new System.Drawing.Size(935, 121);
            this.gbSetFile.TabIndex = 0;
            this.gbSetFile.TabStop = false;
            this.gbSetFile.Text = "Set File";
            // 
            // lbFilePath
            // 
            this.lbFilePath.AutoSize = true;
            this.lbFilePath.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbFilePath.Location = new System.Drawing.Point(405, 84);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(82, 24);
            this.lbFilePath.TabIndex = 2;
            this.lbFilePath.TabStop = true;
            this.lbFilePath.Text = "No Set ";
            this.lbFilePath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbFilePath_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(404, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Path:";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.White;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnSelectFile.Location = new System.Drawing.Point(62, 37);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(223, 65);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.White;
            this.btnPay.Enabled = false;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.btnPay.Location = new System.Drawing.Point(969, 29);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(370, 79);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(969, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(370, 79);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrTestLapInfoWithFilter1
            // 
            this.ctrTestLapInfoWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ctrTestLapInfoWithFilter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrTestLapInfoWithFilter1.Location = new System.Drawing.Point(3, 9);
            this.ctrTestLapInfoWithFilter1.Name = "ctrTestLapInfoWithFilter1";
            this.ctrTestLapInfoWithFilter1.Size = new System.Drawing.Size(935, 613);
            this.ctrTestLapInfoWithFilter1.TabIndex = 1;
            this.ctrTestLapInfoWithFilter1.OnSearchClick += new System.EventHandler<HospitalSys.LabTests.ctrTestLapInfoWithFilter.AfterSearchClick>(this.ctrTestLapInfoWithFilter1_OnSearchClick);
            // 
            // ctrAddTheResultOfTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.ctrTestLapInfoWithFilter1);
            this.Controls.Add(this.gbSetFile);
            this.Name = "ctrAddTheResultOfTest";
            this.Size = new System.Drawing.Size(1378, 764);
            this.Load += new System.EventHandler(this.ctrAddTheResultOfTest_Load);
            this.gbSetFile.ResumeLayout(false);
            this.gbSetFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSetFile;
        private System.Windows.Forms.LinkLabel lbFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectFile;
        private ctrTestLapInfoWithFilter ctrTestLapInfoWithFilter1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnSave;
    }
}
