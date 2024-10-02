namespace HospitalSys.Users
{
    partial class ctrUserInfoByFilter
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
            this.ctrUserInfo1 = new HospitalSys.Users.ctrUserInfo();
            this.gbFinde = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbFinde.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrUserInfo1
            // 
            this.ctrUserInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ctrUserInfo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrUserInfo1.Location = new System.Drawing.Point(13, 133);
            this.ctrUserInfo1.Name = "ctrUserInfo1";
            this.ctrUserInfo1.Size = new System.Drawing.Size(1059, 448);
            this.ctrUserInfo1.TabIndex = 0;
            // 
            // gbFinde
            // 
            this.gbFinde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gbFinde.Controls.Add(this.btnSearch);
            this.gbFinde.Controls.Add(this.txtSearch);
            this.gbFinde.Controls.Add(this.label1);
            this.gbFinde.Location = new System.Drawing.Point(13, 17);
            this.gbFinde.Name = "gbFinde";
            this.gbFinde.Size = new System.Drawing.Size(1059, 100);
            this.gbFinde.TabIndex = 1;
            this.gbFinde.TabStop = false;
            this.gbFinde.Text = "Find";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(64, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter UserID :";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(348, 48);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(350, 32);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(730, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 76);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ctrUserInfoByFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.gbFinde);
            this.Controls.Add(this.ctrUserInfo1);
            this.Name = "ctrUserInfoByFilter";
            this.Size = new System.Drawing.Size(1089, 595);
            this.gbFinde.ResumeLayout(false);
            this.gbFinde.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrUserInfo ctrUserInfo1;
        private System.Windows.Forms.GroupBox gbFinde;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}
