namespace HospitalSys.PateintsRecords
{
    partial class AddNewPatientRecordHS
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
            this.ctrAddNewPatientRecordHS1 = new HospitalSys.PateintsRecords.ctrAddNewPatientRecordHS();
            this.SuspendLayout();
            // 
            // ctrAddNewPatientRecordHS1
            // 
            this.ctrAddNewPatientRecordHS1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ctrAddNewPatientRecordHS1.Location = new System.Drawing.Point(0, 0);
            this.ctrAddNewPatientRecordHS1.Name = "ctrAddNewPatientRecordHS1";
            this.ctrAddNewPatientRecordHS1.Size = new System.Drawing.Size(1527, 710);
            this.ctrAddNewPatientRecordHS1.TabIndex = 0;
            this.ctrAddNewPatientRecordHS1.AfterSaveClick += new System.EventHandler<HospitalSys.PateintsRecords.ctrAddNewPatientRecordHS.OnSaveClick>(this.ctrAddNewPatientRecordHS1_AfterSaveClick);
            this.ctrAddNewPatientRecordHS1.Load += new System.EventHandler(this.ctrAddNewPatientRecordHS1_Load);
            // 
            // AddNewPatientRecordHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1530, 703);
            this.Controls.Add(this.ctrAddNewPatientRecordHS1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewPatientRecordHS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddNewPatientRecordHS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrAddNewPatientRecordHS ctrAddNewPatientRecordHS1;
    }
}