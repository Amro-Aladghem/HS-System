namespace HospitalSys.Medicals
{
    partial class UpdateMedicalInStorage
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
            this.ctrEditMedicalRecordInStorage1 = new HospitalSys.Medicals.ctrEditMedicalRecordInStorage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExsits = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrEditMedicalRecordInStorage1
            // 
            this.ctrEditMedicalRecordInStorage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ctrEditMedicalRecordInStorage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrEditMedicalRecordInStorage1.Location = new System.Drawing.Point(12, 123);
            this.ctrEditMedicalRecordInStorage1.Name = "ctrEditMedicalRecordInStorage1";
            this.ctrEditMedicalRecordInStorage1.Size = new System.Drawing.Size(846, 371);
            this.ctrEditMedicalRecordInStorage1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnExsits);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Medical Record:";
            // 
            // btnExsits
            // 
            this.btnExsits.BackColor = System.Drawing.Color.White;
            this.btnExsits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExsits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExsits.Location = new System.Drawing.Point(761, 0);
            this.btnExsits.Name = "btnExsits";
            this.btnExsits.Size = new System.Drawing.Size(109, 100);
            this.btnExsits.TabIndex = 3;
            this.btnExsits.UseVisualStyleBackColor = false;
            this.btnExsits.Click += new System.EventHandler(this.btnExsits_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(370, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateMedicalInStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(871, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctrEditMedicalRecordInStorage1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateMedicalInStorage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateMedicalInStorage";
            this.Load += new System.EventHandler(this.UpdateMedicalInStorage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrEditMedicalRecordInStorage ctrEditMedicalRecordInStorage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExsits;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}