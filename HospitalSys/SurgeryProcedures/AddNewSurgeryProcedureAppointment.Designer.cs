namespace HospitalSys.SurgeryProcedures
{
    partial class AddNewSurgeryProcedureAppointment
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbHeader = new System.Windows.Forms.Label();
            this.dateOfProcedure = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TimeOfProcedure = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxRoomNum = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxSurgeryTypes = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelChoosing = new System.Windows.Forms.Panel();
            this.btnDeleteNurse2 = new System.Windows.Forms.Button();
            this.btnDeleteDoctor3 = new System.Windows.Forms.Button();
            this.btnDeleteDoctor2 = new System.Windows.Forms.Button();
            this.btnFinishNurse = new System.Windows.Forms.Button();
            this.btnEditNurse = new System.Windows.Forms.Button();
            this.btnChooseNurse2 = new System.Windows.Forms.Button();
            this.lbNurse2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnChooseNurse1 = new System.Windows.Forms.Button();
            this.lbNurse1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnFinishDoctors = new System.Windows.Forms.Button();
            this.btnEditDoctors = new System.Windows.Forms.Button();
            this.btnChooseDoctor3 = new System.Windows.Forms.Button();
            this.lbDoctor3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnChooseDoctor2 = new System.Windows.Forms.Button();
            this.lbDoctor2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnChooseDoctor1 = new System.Windows.Forms.Button();
            this.lbDoctor1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.PanelChoosing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbHeader);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(919, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(243, 71);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = global::HospitalSys.Properties.Resources.cancel;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1276, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 100);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::HospitalSys.Properties.Resources.robotic_surgery;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(618, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 100);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.White;
            this.lbHeader.Location = new System.Drawing.Point(10, 27);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(432, 48);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "Add New Procedure:\r\n";
            // 
            // dateOfProcedure
            // 
            this.dateOfProcedure.Enabled = false;
            this.dateOfProcedure.Location = new System.Drawing.Point(803, 28);
            this.dateOfProcedure.MinDate = new System.DateTime(2024, 9, 29, 0, 0, 0, 0);
            this.dateOfProcedure.Name = "dateOfProcedure";
            this.dateOfProcedure.Size = new System.Drawing.Size(276, 27);
            this.dateOfProcedure.TabIndex = 0;
            this.dateOfProcedure.ValueChanged += new System.EventHandler(this.dateOfProcedure_ValueChanged);
            this.dateOfProcedure.Validating += new System.ComponentModel.CancelEventHandler(this.dateOfProcedure_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(594, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Of Procedure:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(1119, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time:";
            // 
            // TimeOfProcedure
            // 
            this.TimeOfProcedure.Enabled = false;
            this.TimeOfProcedure.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeOfProcedure.Location = new System.Drawing.Point(1228, 32);
            this.TimeOfProcedure.Name = "TimeOfProcedure";
            this.TimeOfProcedure.ShowUpDown = true;
            this.TimeOfProcedure.Size = new System.Drawing.Size(160, 27);
            this.TimeOfProcedure.TabIndex = 3;
            this.TimeOfProcedure.ValueChanged += new System.EventHandler(this.TimeOfProcedure_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(596, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "RoomID:";
            // 
            // cbxRoomNum
            // 
            this.cbxRoomNum.Enabled = false;
            this.cbxRoomNum.FormattingEnabled = true;
            this.cbxRoomNum.Location = new System.Drawing.Point(702, 94);
            this.cbxRoomNum.Name = "cbxRoomNum";
            this.cbxRoomNum.Size = new System.Drawing.Size(276, 27);
            this.cbxRoomNum.TabIndex = 5;
            this.cbxRoomNum.SelectedIndexChanged += new System.EventHandler(this.cbxRoomNum_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(33, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Surgery Type:";
            // 
            // cbxSurgeryTypes
            // 
            this.cbxSurgeryTypes.Enabled = false;
            this.cbxSurgeryTypes.FormattingEnabled = true;
            this.cbxSurgeryTypes.Location = new System.Drawing.Point(185, 94);
            this.cbxSurgeryTypes.Name = "cbxSurgeryTypes";
            this.cbxSurgeryTypes.Size = new System.Drawing.Size(276, 27);
            this.cbxSurgeryTypes.TabIndex = 7;
            this.cbxSurgeryTypes.SelectedIndexChanged += new System.EventHandler(this.cbxSurgeryTypes_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.btnSearchPatient);
            this.groupBox1.Controls.Add(this.txtPatientID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateOfProcedure);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxSurgeryTypes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxRoomNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TimeOfProcedure);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(0, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1400, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procedure Info:";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.White;
            this.btnCheck.Enabled = false;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnCheck.Location = new System.Drawing.Point(1193, 82);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(195, 45);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.BackColor = System.Drawing.Color.White;
            this.btnSearchPatient.BackgroundImage = global::HospitalSys.Properties.Resources.search__1_;
            this.btnSearchPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPatient.Location = new System.Drawing.Point(484, 28);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(50, 39);
            this.btnSearchPatient.TabIndex = 10;
            this.btnSearchPatient.UseVisualStyleBackColor = false;
            this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(185, 35);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(276, 27);
            this.txtPatientID.TabIndex = 9;
            this.txtPatientID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientID_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(33, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "PaitentID:";
            // 
            // PanelChoosing
            // 
            this.PanelChoosing.BackColor = System.Drawing.Color.SeaGreen;
            this.PanelChoosing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelChoosing.Controls.Add(this.btnDeleteNurse2);
            this.PanelChoosing.Controls.Add(this.btnDeleteDoctor3);
            this.PanelChoosing.Controls.Add(this.btnDeleteDoctor2);
            this.PanelChoosing.Controls.Add(this.btnFinishNurse);
            this.PanelChoosing.Controls.Add(this.btnEditNurse);
            this.PanelChoosing.Controls.Add(this.btnChooseNurse2);
            this.PanelChoosing.Controls.Add(this.lbNurse2);
            this.PanelChoosing.Controls.Add(this.label15);
            this.PanelChoosing.Controls.Add(this.btnChooseNurse1);
            this.PanelChoosing.Controls.Add(this.lbNurse1);
            this.PanelChoosing.Controls.Add(this.label17);
            this.PanelChoosing.Controls.Add(this.btnFinishDoctors);
            this.PanelChoosing.Controls.Add(this.btnEditDoctors);
            this.PanelChoosing.Controls.Add(this.btnChooseDoctor3);
            this.PanelChoosing.Controls.Add(this.lbDoctor3);
            this.PanelChoosing.Controls.Add(this.label12);
            this.PanelChoosing.Controls.Add(this.btnChooseDoctor2);
            this.PanelChoosing.Controls.Add(this.lbDoctor2);
            this.PanelChoosing.Controls.Add(this.label11);
            this.PanelChoosing.Controls.Add(this.btnChooseDoctor1);
            this.PanelChoosing.Controls.Add(this.lbDoctor1);
            this.PanelChoosing.Controls.Add(this.label9);
            this.PanelChoosing.Controls.Add(this.panel3);
            this.PanelChoosing.Enabled = false;
            this.PanelChoosing.Location = new System.Drawing.Point(0, 292);
            this.PanelChoosing.Name = "PanelChoosing";
            this.PanelChoosing.Size = new System.Drawing.Size(1400, 469);
            this.PanelChoosing.TabIndex = 2;
            // 
            // btnDeleteNurse2
            // 
            this.btnDeleteNurse2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDeleteNurse2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNurse2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNurse2.Location = new System.Drawing.Point(1152, 215);
            this.btnDeleteNurse2.Name = "btnDeleteNurse2";
            this.btnDeleteNurse2.Size = new System.Drawing.Size(183, 39);
            this.btnDeleteNurse2.TabIndex = 28;
            this.btnDeleteNurse2.Text = "Delete";
            this.btnDeleteNurse2.UseVisualStyleBackColor = false;
            this.btnDeleteNurse2.Visible = false;
            this.btnDeleteNurse2.Click += new System.EventHandler(this.btnDeleteNurse2_Click);
            // 
            // btnDeleteDoctor3
            // 
            this.btnDeleteDoctor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDeleteDoctor3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDoctor3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDoctor3.Location = new System.Drawing.Point(450, 339);
            this.btnDeleteDoctor3.Name = "btnDeleteDoctor3";
            this.btnDeleteDoctor3.Size = new System.Drawing.Size(183, 39);
            this.btnDeleteDoctor3.TabIndex = 27;
            this.btnDeleteDoctor3.Text = "Delete";
            this.btnDeleteDoctor3.UseVisualStyleBackColor = false;
            this.btnDeleteDoctor3.Visible = false;
            this.btnDeleteDoctor3.Click += new System.EventHandler(this.btnDeleteDoctor3_Click);
            // 
            // btnDeleteDoctor2
            // 
            this.btnDeleteDoctor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDeleteDoctor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDoctor2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDoctor2.Location = new System.Drawing.Point(450, 215);
            this.btnDeleteDoctor2.Name = "btnDeleteDoctor2";
            this.btnDeleteDoctor2.Size = new System.Drawing.Size(183, 39);
            this.btnDeleteDoctor2.TabIndex = 26;
            this.btnDeleteDoctor2.Text = "Delete";
            this.btnDeleteDoctor2.UseVisualStyleBackColor = false;
            this.btnDeleteDoctor2.Visible = false;
            this.btnDeleteDoctor2.Click += new System.EventHandler(this.btnDeleteDoctor2_Click);
            // 
            // btnFinishNurse
            // 
            this.btnFinishNurse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFinishNurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishNurse.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishNurse.Location = new System.Drawing.Point(1108, 402);
            this.btnFinishNurse.Name = "btnFinishNurse";
            this.btnFinishNurse.Size = new System.Drawing.Size(198, 54);
            this.btnFinishNurse.TabIndex = 25;
            this.btnFinishNurse.Text = "Finish";
            this.btnFinishNurse.UseVisualStyleBackColor = false;
            this.btnFinishNurse.Click += new System.EventHandler(this.btnFinishNurse_Click);
            // 
            // btnEditNurse
            // 
            this.btnEditNurse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditNurse.Enabled = false;
            this.btnEditNurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditNurse.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditNurse.Location = new System.Drawing.Point(806, 402);
            this.btnEditNurse.Name = "btnEditNurse";
            this.btnEditNurse.Size = new System.Drawing.Size(198, 54);
            this.btnEditNurse.TabIndex = 24;
            this.btnEditNurse.Text = "Edit";
            this.btnEditNurse.UseVisualStyleBackColor = false;
            this.btnEditNurse.Click += new System.EventHandler(this.btnEditNurse_Click);
            // 
            // btnChooseNurse2
            // 
            this.btnChooseNurse2.BackColor = System.Drawing.Color.White;
            this.btnChooseNurse2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseNurse2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnChooseNurse2.Location = new System.Drawing.Point(1121, 161);
            this.btnChooseNurse2.Name = "btnChooseNurse2";
            this.btnChooseNurse2.Size = new System.Drawing.Size(243, 46);
            this.btnChooseNurse2.TabIndex = 20;
            this.btnChooseNurse2.Text = "Choose";
            this.btnChooseNurse2.UseVisualStyleBackColor = false;
            this.btnChooseNurse2.Click += new System.EventHandler(this.btnChooseNurse2_Click);
            // 
            // lbNurse2
            // 
            this.lbNurse2.AutoSize = true;
            this.lbNurse2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbNurse2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbNurse2.Location = new System.Drawing.Point(972, 171);
            this.lbNurse2.Name = "lbNurse2";
            this.lbNurse2.Size = new System.Drawing.Size(76, 36);
            this.lbNurse2.TabIndex = 19;
            this.lbNurse2.Text = "N/A";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label15.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(732, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(189, 36);
            this.label15.TabIndex = 18;
            this.label15.Text = "Nurse 2 ID:";
            // 
            // btnChooseNurse1
            // 
            this.btnChooseNurse1.BackColor = System.Drawing.Color.White;
            this.btnChooseNurse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseNurse1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnChooseNurse1.Location = new System.Drawing.Point(1121, 37);
            this.btnChooseNurse1.Name = "btnChooseNurse1";
            this.btnChooseNurse1.Size = new System.Drawing.Size(243, 45);
            this.btnChooseNurse1.TabIndex = 17;
            this.btnChooseNurse1.Text = "Choose";
            this.btnChooseNurse1.UseVisualStyleBackColor = false;
            this.btnChooseNurse1.Click += new System.EventHandler(this.btnChooseNurse1_Click);
            // 
            // lbNurse1
            // 
            this.lbNurse1.AutoSize = true;
            this.lbNurse1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbNurse1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbNurse1.Location = new System.Drawing.Point(972, 46);
            this.lbNurse1.Name = "lbNurse1";
            this.lbNurse1.Size = new System.Drawing.Size(76, 36);
            this.lbNurse1.TabIndex = 16;
            this.lbNurse1.Text = "N/A";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label17.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(732, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(189, 36);
            this.label17.TabIndex = 15;
            this.label17.Text = "Nurse 1 ID:";
            // 
            // btnFinishDoctors
            // 
            this.btnFinishDoctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFinishDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishDoctors.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishDoctors.Location = new System.Drawing.Point(373, 402);
            this.btnFinishDoctors.Name = "btnFinishDoctors";
            this.btnFinishDoctors.Size = new System.Drawing.Size(198, 54);
            this.btnFinishDoctors.TabIndex = 14;
            this.btnFinishDoctors.Text = "Finish";
            this.btnFinishDoctors.UseVisualStyleBackColor = false;
            this.btnFinishDoctors.Click += new System.EventHandler(this.btnFinishDoctors_Click);
            // 
            // btnEditDoctors
            // 
            this.btnEditDoctors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEditDoctors.Enabled = false;
            this.btnEditDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDoctors.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDoctors.Location = new System.Drawing.Point(104, 402);
            this.btnEditDoctors.Name = "btnEditDoctors";
            this.btnEditDoctors.Size = new System.Drawing.Size(198, 54);
            this.btnEditDoctors.TabIndex = 13;
            this.btnEditDoctors.Text = "Edit";
            this.btnEditDoctors.UseVisualStyleBackColor = false;
            this.btnEditDoctors.Click += new System.EventHandler(this.btnEditDoctors_Click);
            // 
            // btnChooseDoctor3
            // 
            this.btnChooseDoctor3.BackColor = System.Drawing.Color.White;
            this.btnChooseDoctor3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseDoctor3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnChooseDoctor3.Location = new System.Drawing.Point(420, 283);
            this.btnChooseDoctor3.Name = "btnChooseDoctor3";
            this.btnChooseDoctor3.Size = new System.Drawing.Size(243, 41);
            this.btnChooseDoctor3.TabIndex = 12;
            this.btnChooseDoctor3.Text = "Choose";
            this.btnChooseDoctor3.UseVisualStyleBackColor = false;
            this.btnChooseDoctor3.Click += new System.EventHandler(this.btnChooseDoctor3_Click);
            // 
            // lbDoctor3
            // 
            this.lbDoctor3.AutoSize = true;
            this.lbDoctor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbDoctor3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbDoctor3.Location = new System.Drawing.Point(270, 288);
            this.lbDoctor3.Name = "lbDoctor3";
            this.lbDoctor3.Size = new System.Drawing.Size(76, 36);
            this.lbDoctor3.TabIndex = 11;
            this.lbDoctor3.Text = "N/A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label12.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(30, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(203, 36);
            this.label12.TabIndex = 10;
            this.label12.Text = "Doctor 3 ID:";
            // 
            // btnChooseDoctor2
            // 
            this.btnChooseDoctor2.BackColor = System.Drawing.Color.White;
            this.btnChooseDoctor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseDoctor2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnChooseDoctor2.Location = new System.Drawing.Point(420, 161);
            this.btnChooseDoctor2.Name = "btnChooseDoctor2";
            this.btnChooseDoctor2.Size = new System.Drawing.Size(243, 48);
            this.btnChooseDoctor2.TabIndex = 9;
            this.btnChooseDoctor2.Text = "Choose";
            this.btnChooseDoctor2.UseVisualStyleBackColor = false;
            this.btnChooseDoctor2.Click += new System.EventHandler(this.btnChooseDoctor2_Click);
            // 
            // lbDoctor2
            // 
            this.lbDoctor2.AutoSize = true;
            this.lbDoctor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbDoctor2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbDoctor2.Location = new System.Drawing.Point(271, 173);
            this.lbDoctor2.Name = "lbDoctor2";
            this.lbDoctor2.Size = new System.Drawing.Size(76, 36);
            this.lbDoctor2.TabIndex = 8;
            this.lbDoctor2.Text = "N/A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label11.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(31, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 36);
            this.label11.TabIndex = 7;
            this.label11.Text = "Doctor 2 ID:";
            // 
            // btnChooseDoctor1
            // 
            this.btnChooseDoctor1.BackColor = System.Drawing.Color.White;
            this.btnChooseDoctor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseDoctor1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnChooseDoctor1.Location = new System.Drawing.Point(420, 37);
            this.btnChooseDoctor1.Name = "btnChooseDoctor1";
            this.btnChooseDoctor1.Size = new System.Drawing.Size(243, 47);
            this.btnChooseDoctor1.TabIndex = 6;
            this.btnChooseDoctor1.Text = "Choose";
            this.btnChooseDoctor1.UseVisualStyleBackColor = false;
            this.btnChooseDoctor1.Click += new System.EventHandler(this.btnChooseDoctor1_Click);
            // 
            // lbDoctor1
            // 
            this.lbDoctor1.AutoSize = true;
            this.lbDoctor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbDoctor1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lbDoctor1.Location = new System.Drawing.Point(271, 48);
            this.lbDoctor1.Name = "lbDoctor1";
            this.lbDoctor1.Size = new System.Drawing.Size(76, 36);
            this.lbDoctor1.TabIndex = 5;
            this.lbDoctor1.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label9.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(31, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 36);
            this.label9.TabIndex = 4;
            this.label9.Text = "Doctor 1 ID:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(686, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 469);
            this.panel3.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "select Doctors:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(976, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "select Nurses:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddNewSurgeryProcedureAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1400, 761);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PanelChoosing);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewSurgeryProcedureAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewSurgeryProcedureAppointment";
            this.Load += new System.EventHandler(this.AddNewSurgeryProcedureAppointment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelChoosing.ResumeLayout(false);
            this.PanelChoosing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.DateTimePicker dateOfProcedure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker TimeOfProcedure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxRoomNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxSurgeryTypes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PanelChoosing;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnChooseDoctor1;
        private System.Windows.Forms.Label lbDoctor1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnChooseDoctor2;
        private System.Windows.Forms.Label lbDoctor2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbDoctor3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnChooseDoctor3;
        private System.Windows.Forms.Button btnFinishDoctors;
        private System.Windows.Forms.Button btnEditDoctors;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFinishNurse;
        private System.Windows.Forms.Button btnEditNurse;
        private System.Windows.Forms.Button btnChooseNurse2;
        private System.Windows.Forms.Label lbNurse2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnChooseNurse1;
        private System.Windows.Forms.Label lbNurse1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnDeleteDoctor3;
        private System.Windows.Forms.Button btnDeleteDoctor2;
        private System.Windows.Forms.Button btnDeleteNurse2;
    }
}