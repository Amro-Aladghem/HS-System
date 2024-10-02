namespace HospitalSys.Appointments
{
    partial class AddNewAppointment
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
            this.ctrAddNewAppointment1 = new HospitalSys.Appointments.ctrAddNewAppointment();
            this.SuspendLayout();
            // 
            // ctrAddNewAppointment1
            // 
            this.ctrAddNewAppointment1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ctrAddNewAppointment1.Location = new System.Drawing.Point(-1, 1);
            this.ctrAddNewAppointment1.Name = "ctrAddNewAppointment1";
            this.ctrAddNewAppointment1.Size = new System.Drawing.Size(874, 748);
            this.ctrAddNewAppointment1.TabIndex = 0;
            // 
            // AddNewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(875, 749);
            this.Controls.Add(this.ctrAddNewAppointment1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewAppointment";
            this.Load += new System.EventHandler(this.AddNewAppointment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrAddNewAppointment ctrAddNewAppointment1;
    }
}