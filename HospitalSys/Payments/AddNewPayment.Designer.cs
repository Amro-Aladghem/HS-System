namespace HospitalSys.Payments
{
    partial class AddNewPayment
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
            this.ctrAddNewPayment1 = new HospitalSys.Payments.ctrAddNewPayment();
            this.SuspendLayout();
            // 
            // ctrAddNewPayment1
            // 
            this.ctrAddNewPayment1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ctrAddNewPayment1.Location = new System.Drawing.Point(0, -4);
            this.ctrAddNewPayment1.Name = "ctrAddNewPayment1";
            this.ctrAddNewPayment1.Size = new System.Drawing.Size(831, 774);
            this.ctrAddNewPayment1.TabIndex = 0;
            this.ctrAddNewPayment1.Load += new System.EventHandler(this.ctrAddNewPayment1_Load);
            // 
            // AddNewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(833, 775);
            this.Controls.Add(this.ctrAddNewPayment1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewPayment";
            this.Load += new System.EventHandler(this.AddNewPayment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrAddNewPayment ctrAddNewPayment1;
    }
}