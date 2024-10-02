namespace HospitalSys.SurgeryProcedures
{
    partial class FindSurgeryProcedure
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
            this.ctrSurgeryInfoWithFilter1 = new HospitalSys.SurgeryProcedures.ctrSurgeryInfoWithFilter();
            this.SuspendLayout();
            // 
            // ctrSurgeryInfoWithFilter1
            // 
            this.ctrSurgeryInfoWithFilter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ctrSurgeryInfoWithFilter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrSurgeryInfoWithFilter1.Location = new System.Drawing.Point(-1, 0);
            this.ctrSurgeryInfoWithFilter1.Name = "ctrSurgeryInfoWithFilter1";
            this.ctrSurgeryInfoWithFilter1.Size = new System.Drawing.Size(1311, 726);
            this.ctrSurgeryInfoWithFilter1.TabIndex = 0;
            // 
            // FindSurgeryProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1311, 725);
            this.Controls.Add(this.ctrSurgeryInfoWithFilter1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindSurgeryProcedure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindSurgeryProcedure";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrSurgeryInfoWithFilter ctrSurgeryInfoWithFilter1;
    }
}