namespace HospitalSys.Payments
{
    partial class ctrAddNewPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalNotPaidTest = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSurgeryProcedure = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNumberOfDaysInRoom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTestAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSurgeryAmount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbRoomAmount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTotalAmount = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnMakeInvoice = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient ID:";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txtPatientID.Location = new System.Drawing.Point(264, 62);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(363, 32);
            this.txtPatientID.TabIndex = 2;
            this.txtPatientID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientID_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(801, 128);
            this.dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Not Paid Test:";
            // 
            // lbTotalNotPaidTest
            // 
            this.lbTotalNotPaidTest.AutoSize = true;
            this.lbTotalNotPaidTest.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbTotalNotPaidTest.Location = new System.Drawing.Point(203, 157);
            this.lbTotalNotPaidTest.Name = "lbTotalNotPaidTest";
            this.lbTotalNotPaidTest.Size = new System.Drawing.Size(21, 22);
            this.lbTotalNotPaidTest.TabIndex = 7;
            this.lbTotalNotPaidTest.Text = "0";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 361);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(801, 128);
            this.dataGridView2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(11, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Surgery Procedure:";
            // 
            // lbSurgeryProcedure
            // 
            this.lbSurgeryProcedure.AutoSize = true;
            this.lbSurgeryProcedure.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbSurgeryProcedure.Location = new System.Drawing.Point(203, 336);
            this.lbSurgeryProcedure.Name = "lbSurgeryProcedure";
            this.lbSurgeryProcedure.Size = new System.Drawing.Size(46, 22);
            this.lbSurgeryProcedure.TabIndex = 10;
            this.lbSurgeryProcedure.Text = "N/A";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(15, 522);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(801, 128);
            this.dataGridView3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(11, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Number Of Day In Room:";
            // 
            // lbNumberOfDaysInRoom
            // 
            this.lbNumberOfDaysInRoom.AutoSize = true;
            this.lbNumberOfDaysInRoom.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbNumberOfDaysInRoom.Location = new System.Drawing.Point(247, 497);
            this.lbNumberOfDaysInRoom.Name = "lbNumberOfDaysInRoom";
            this.lbNumberOfDaysInRoom.Size = new System.Drawing.Size(21, 22);
            this.lbNumberOfDaysInRoom.TabIndex = 13;
            this.lbNumberOfDaysInRoom.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(11, 667);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "TestAmount:";
            // 
            // lbTestAmount
            // 
            this.lbTestAmount.AutoSize = true;
            this.lbTestAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbTestAmount.Location = new System.Drawing.Point(155, 669);
            this.lbTestAmount.Name = "lbTestAmount";
            this.lbTestAmount.Size = new System.Drawing.Size(21, 22);
            this.lbTestAmount.TabIndex = 15;
            this.lbTestAmount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(260, 667);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "SurgeryAmount:";
            // 
            // lbSurgeryAmount
            // 
            this.lbSurgeryAmount.AutoSize = true;
            this.lbSurgeryAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbSurgeryAmount.Location = new System.Drawing.Point(443, 669);
            this.lbSurgeryAmount.Name = "lbSurgeryAmount";
            this.lbSurgeryAmount.Size = new System.Drawing.Size(21, 22);
            this.lbSurgeryAmount.TabIndex = 17;
            this.lbSurgeryAmount.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(563, 667);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "RoomAmount:";
            // 
            // lbRoomAmount
            // 
            this.lbRoomAmount.AutoSize = true;
            this.lbRoomAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbRoomAmount.Location = new System.Drawing.Point(714, 669);
            this.lbRoomAmount.Name = "lbRoomAmount";
            this.lbRoomAmount.Size = new System.Drawing.Size(21, 22);
            this.lbRoomAmount.TabIndex = 19;
            this.lbRoomAmount.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(10, 710);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 29);
            this.label8.TabIndex = 20;
            this.label8.Text = "TotalAmount:";
            // 
            // lbTotalAmount
            // 
            this.lbTotalAmount.AutoSize = true;
            this.lbTotalAmount.BackColor = System.Drawing.Color.Yellow;
            this.lbTotalAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotalAmount.Location = new System.Drawing.Point(10, 744);
            this.lbTotalAmount.Name = "lbTotalAmount";
            this.lbTotalAmount.Size = new System.Drawing.Size(28, 29);
            this.lbTotalAmount.TabIndex = 21;
            this.lbTotalAmount.Text = "0";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.White;
            this.btnPay.Enabled = false;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btnPay.Location = new System.Drawing.Point(567, 723);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(249, 50);
            this.btnPay.TabIndex = 22;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.White;
            this.btnCalculate.Enabled = false;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.Location = new System.Drawing.Point(312, 723);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(249, 50);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnMakeInvoice
            // 
            this.btnMakeInvoice.BackColor = System.Drawing.Color.White;
            this.btnMakeInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeInvoice.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btnMakeInvoice.Location = new System.Drawing.Point(567, 132);
            this.btnMakeInvoice.Name = "btnMakeInvoice";
            this.btnMakeInvoice.Size = new System.Drawing.Size(249, 50);
            this.btnMakeInvoice.TabIndex = 24;
            this.btnMakeInvoice.Text = "Make Invoice";
            this.btnMakeInvoice.UseVisualStyleBackColor = false;
            this.btnMakeInvoice.Visible = false;
            this.btnMakeInvoice.Click += new System.EventHandler(this.btnMakeInvoice_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = global::HospitalSys.Properties.Resources.search__1_;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(657, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 79);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 104);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ctrAddNewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnMakeInvoice);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lbTotalAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbRoomAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbSurgeryAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbTestAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbNumberOfDaysInRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.lbSurgeryProcedure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.lbTotalNotPaidTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ctrAddNewPayment";
            this.Size = new System.Drawing.Size(831, 790);
            this.Load += new System.EventHandler(this.ctrAddNewPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalNotPaidTest;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSurgeryProcedure;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbNumberOfDaysInRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTestAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbSurgeryAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbRoomAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTotalAmount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnMakeInvoice;
    }
}
