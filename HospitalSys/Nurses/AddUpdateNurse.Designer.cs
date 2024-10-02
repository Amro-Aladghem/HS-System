namespace HospitalSys.Nurses
{
    partial class AddUpdateNurse
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
            this.ctrAddUpdateNurse1 = new HospitalSys.Nurses.ctrAddUpdateNurse();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExits = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrAddUpdateNurse1
            // 
            this.ctrAddUpdateNurse1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ctrAddUpdateNurse1.Location = new System.Drawing.Point(12, 125);
            this.ctrAddUpdateNurse1.Name = "ctrAddUpdateNurse1";
            this.ctrAddUpdateNurse1.Size = new System.Drawing.Size(914, 567);
            this.ctrAddUpdateNurse1.TabIndex = 0;
            this.ctrAddUpdateNurse1.OnSaveClick += new System.EventHandler<HospitalSys.Nurses.ctrAddUpdateNurse.clsOnSaveClick>(this.ctrAddUpdateNurse1_OnSaveClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnExits);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbHeader);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 94);
            this.panel1.TabIndex = 1;
            // 
            // btnExits
            // 
            this.btnExits.BackColor = System.Drawing.Color.White;
            this.btnExits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExits.Location = new System.Drawing.Point(836, 0);
            this.btnExits.Name = "btnExits";
            this.btnExits.Size = new System.Drawing.Size(102, 94);
            this.btnExits.TabIndex = 2;
            this.btnExits.UseVisualStyleBackColor = false;
            this.btnExits.Click += new System.EventHandler(this.btnExits_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(407, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.White;
            this.lbHeader.Location = new System.Drawing.Point(4, 27);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(336, 39);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Add/Update Nurse :\r\n";
            // 
            // AddUpdateNurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(939, 707);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctrAddUpdateNurse1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUpdateNurse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Update Nurse:";
            this.Load += new System.EventHandler(this.AddUpdateNurse_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrAddUpdateNurse ctrAddUpdateNurse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExits;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbHeader;
    }
}