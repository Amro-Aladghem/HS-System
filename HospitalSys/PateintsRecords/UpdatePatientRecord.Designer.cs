namespace HospitalSys.PateintsRecords
{
    partial class UpdatePatientRecord
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrUpdatePatientRecordHS1 = new HospitalSys.PateintsRecords.ctrUpdatePatientRecordHS();
            this.SuspendLayout();
            // 
            // ctrUpdatePatientRecordHS1
            // 
            this.ctrUpdatePatientRecordHS1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ctrUpdatePatientRecordHS1.Location = new System.Drawing.Point(-3, -3);
            this.ctrUpdatePatientRecordHS1.Name = "ctrUpdatePatientRecordHS1";
            this.ctrUpdatePatientRecordHS1.Size = new System.Drawing.Size(726, 728);
            this.ctrUpdatePatientRecordHS1.TabIndex = 0;
            this.ctrUpdatePatientRecordHS1.OnSaveClick += new System.EventHandler<HospitalSys.PateintsRecords.ctrUpdatePatientRecordHS.clsAfterChanging>(this.ctrUpdatePatientRecordHS1_OnSaveClick);
            // 
            // UpdatePatientRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(725, 727);
            this.Controls.Add(this.ctrUpdatePatientRecordHS1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdatePatientRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePatientRecord";
            this.Load += new System.EventHandler(this.UpdatePatientRecord_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrUpdatePatientRecordHS ctrUpdatePatientRecordHS1;
    }
}