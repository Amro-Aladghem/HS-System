namespace HospitalSys.Appointments
{
    partial class UpdateAppointment
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
            this.ctrUpdateAppointment1 = new HospitalSys.Appointments.ctrUpdateAppointment();
            this.SuspendLayout();
            // 
            // ctrUpdateAppointment1
            // 
            this.ctrUpdateAppointment1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ctrUpdateAppointment1.Location = new System.Drawing.Point(-7, 0);
            this.ctrUpdateAppointment1.Name = "ctrUpdateAppointment1";
            this.ctrUpdateAppointment1.Size = new System.Drawing.Size(878, 705);
            this.ctrUpdateAppointment1.TabIndex = 0;
            this.ctrUpdateAppointment1.OnSaveClick += new System.EventHandler(this.ctrUpdateAppointment1_OnSaveClick);
            // 
            // UpdateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(870, 698);
            this.Controls.Add(this.ctrUpdateAppointment1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateAppointment";
            this.Load += new System.EventHandler(this.UpdateAppointment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrUpdateAppointment ctrUpdateAppointment1;
    }
}