namespace CShard_3cs2_Lad_P2_Salary
{
    partial class frmStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSurNameLao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSurNameEng = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtFacebook = new System.Windows.Forms.TextBox();
            this.txtNameLao = new System.Windows.Forms.TextBox();
            this.txtNameEng = new System.Windows.Forms.TextBox();
            this.txtVillage = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rdbMarried = new System.Windows.Forms.RadioButton();
            this.rdbSingle = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dpBrithDate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.cmbNameEngQ = new System.Windows.Forms.ComboBox();
            this.cmbNameEngP = new System.Windows.Forms.ComboBox();
            this.cmbDeparment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNameLaoP = new System.Windows.Forms.ComboBox();
            this.cmbNameLaoQ = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btExit = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.btPrint = new System.Windows.Forms.Button();
            this.gbGender.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(28, 44);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(189, 34);
            this.txtID.TabIndex = 0;
            this.txtID.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name of Lao";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Staff ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surname of lao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name of English";
            // 
            // txtSurNameLao
            // 
            this.txtSurNameLao.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurNameLao.Location = new System.Drawing.Point(28, 167);
            this.txtSurNameLao.Name = "txtSurNameLao";
            this.txtSurNameLao.Size = new System.Drawing.Size(189, 34);
            this.txtSurNameLao.TabIndex = 3;
            this.txtSurNameLao.Enter += new System.EventHandler(this.txtNameLao_Enter);
            this.txtSurNameLao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Surname of English";
            // 
            // txtSurNameEng
            // 
            this.txtSurNameEng.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurNameEng.Location = new System.Drawing.Point(28, 291);
            this.txtSurNameEng.Name = "txtSurNameEng";
            this.txtSurNameEng.Size = new System.Drawing.Size(189, 34);
            this.txtSurNameEng.TabIndex = 5;
            this.txtSurNameEng.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtSurNameEng.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(253, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 26);
            this.label9.TabIndex = 17;
            this.label9.Text = "Brith Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(253, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 26);
            this.label10.TabIndex = 18;
            this.label10.Text = "Village";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(481, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 26);
            this.label11.TabIndex = 21;
            this.label11.Text = "District";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(481, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 26);
            this.label12.TabIndex = 22;
            this.label12.Text = "Province";
            // 
            // txtDistrict
            // 
            this.txtDistrict.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistrict.Location = new System.Drawing.Point(481, 45);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(189, 34);
            this.txtDistrict.TabIndex = 7;
            this.txtDistrict.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(481, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 26);
            this.label13.TabIndex = 25;
            this.label13.Text = "Tel";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(481, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 26);
            this.label14.TabIndex = 26;
            this.label14.Text = "Email";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(481, 169);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(189, 34);
            this.txtTel.TabIndex = 9;
            this.txtTel.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtTel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(481, 267);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 26);
            this.label15.TabIndex = 29;
            this.label15.Text = "Facebook";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(714, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 26);
            this.label16.TabIndex = 30;
            this.label16.Text = "Qualification(English)";
            // 
            // txtFacebook
            // 
            this.txtFacebook.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacebook.Location = new System.Drawing.Point(481, 291);
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(189, 34);
            this.txtFacebook.TabIndex = 11;
            this.txtFacebook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // txtNameLao
            // 
            this.txtNameLao.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameLao.Location = new System.Drawing.Point(28, 106);
            this.txtNameLao.Name = "txtNameLao";
            this.txtNameLao.Size = new System.Drawing.Size(189, 34);
            this.txtNameLao.TabIndex = 2;
            this.txtNameLao.Enter += new System.EventHandler(this.txtNameLao_Enter);
            this.txtNameLao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // txtNameEng
            // 
            this.txtNameEng.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameEng.Location = new System.Drawing.Point(28, 228);
            this.txtNameEng.Name = "txtNameEng";
            this.txtNameEng.Size = new System.Drawing.Size(189, 34);
            this.txtNameEng.TabIndex = 4;
            this.txtNameEng.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtNameEng.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // txtVillage
            // 
            this.txtVillage.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVillage.Location = new System.Drawing.Point(253, 291);
            this.txtVillage.Name = "txtVillage";
            this.txtVillage.Size = new System.Drawing.Size(189, 34);
            this.txtVillage.TabIndex = 6;
            this.txtVillage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // txtProvince
            // 
            this.txtProvince.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProvince.Location = new System.Drawing.Point(481, 106);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(189, 34);
            this.txtProvince.TabIndex = 8;
            this.txtProvince.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(481, 229);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(189, 34);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rdbFemale);
            this.gbGender.Controls.Add(this.rdbMale);
            this.gbGender.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGender.ForeColor = System.Drawing.Color.White;
            this.gbGender.Location = new System.Drawing.Point(253, 105);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(189, 67);
            this.gbGender.TabIndex = 39;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemale.Location = new System.Drawing.Point(108, 32);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(76, 30);
            this.rdbFemale.TabIndex = 1;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            this.rdbFemale.CheckedChanged += new System.EventHandler(this.rdbFemale_CheckedChanged);
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMale.Location = new System.Drawing.Point(20, 31);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(62, 30);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            this.rdbMale.CheckedChanged += new System.EventHandler(this.rdbMale_CheckedChanged);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rdbMarried);
            this.gbStatus.Controls.Add(this.rdbSingle);
            this.gbStatus.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.ForeColor = System.Drawing.Color.White;
            this.gbStatus.Location = new System.Drawing.Point(253, 200);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(189, 65);
            this.gbStatus.TabIndex = 39;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rdbMarried
            // 
            this.rdbMarried.AutoSize = true;
            this.rdbMarried.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMarried.Location = new System.Drawing.Point(103, 31);
            this.rdbMarried.Name = "rdbMarried";
            this.rdbMarried.Size = new System.Drawing.Size(80, 30);
            this.rdbMarried.TabIndex = 1;
            this.rdbMarried.TabStop = true;
            this.rdbMarried.Text = "Married";
            this.rdbMarried.UseVisualStyleBackColor = true;
            this.rdbMarried.CheckedChanged += new System.EventHandler(this.rdbMarried_CheckedChanged);
            // 
            // rdbSingle
            // 
            this.rdbSingle.AutoSize = true;
            this.rdbSingle.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSingle.Location = new System.Drawing.Point(20, 31);
            this.rdbSingle.Name = "rdbSingle";
            this.rdbSingle.Size = new System.Drawing.Size(70, 30);
            this.rdbSingle.TabIndex = 0;
            this.rdbSingle.TabStop = true;
            this.rdbSingle.Text = "Single";
            this.rdbSingle.UseVisualStyleBackColor = true;
            this.rdbSingle.CheckedChanged += new System.EventHandler(this.rdbSingle_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(714, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Position(English)";
            // 
            // dpBrithDate
            // 
            this.dpBrithDate.BaseColor = System.Drawing.Color.White;
            this.dpBrithDate.BorderColor = System.Drawing.Color.Silver;
            this.dpBrithDate.BorderSize = 0;
            this.dpBrithDate.CustomFormat = "dd/MM/yyyy";
            this.dpBrithDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dpBrithDate.FocusedColor = System.Drawing.Color.White;
            this.dpBrithDate.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpBrithDate.ForeColor = System.Drawing.Color.Black;
            this.dpBrithDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpBrithDate.Location = new System.Drawing.Point(253, 46);
            this.dpBrithDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpBrithDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpBrithDate.Name = "dpBrithDate";
            this.dpBrithDate.OnHoverBaseColor = System.Drawing.Color.White;
            this.dpBrithDate.OnHoverBorderColor = System.Drawing.Color.White;
            this.dpBrithDate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dpBrithDate.OnPressedColor = System.Drawing.Color.Black;
            this.dpBrithDate.Size = new System.Drawing.Size(189, 34);
            this.dpBrithDate.TabIndex = 41;
            this.dpBrithDate.Text = "22/04/2020";
            this.dpBrithDate.Value = new System.DateTime(2020, 4, 22, 5, 28, 41, 424);
            // 
            // cmbNameEngQ
            // 
            this.cmbNameEngQ.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNameEngQ.FormattingEnabled = true;
            this.cmbNameEngQ.Location = new System.Drawing.Point(714, 45);
            this.cmbNameEngQ.Name = "cmbNameEngQ";
            this.cmbNameEngQ.Size = new System.Drawing.Size(189, 34);
            this.cmbNameEngQ.TabIndex = 12;
            this.cmbNameEngQ.SelectedIndexChanged += new System.EventHandler(this.cmbQualifica_SelectedIndexChanged);
            this.cmbNameEngQ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // cmbNameEngP
            // 
            this.cmbNameEngP.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNameEngP.FormattingEnabled = true;
            this.cmbNameEngP.Location = new System.Drawing.Point(714, 168);
            this.cmbNameEngP.Name = "cmbNameEngP";
            this.cmbNameEngP.Size = new System.Drawing.Size(189, 34);
            this.cmbNameEngP.TabIndex = 14;
            this.cmbNameEngP.SelectedIndexChanged += new System.EventHandler(this.cmbPosition_SelectedIndexChanged);
            this.cmbNameEngP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // cmbDeparment
            // 
            this.cmbDeparment.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDeparment.FormattingEnabled = true;
            this.cmbDeparment.Location = new System.Drawing.Point(714, 291);
            this.cmbDeparment.Name = "cmbDeparment";
            this.cmbDeparment.Size = new System.Drawing.Size(189, 34);
            this.cmbDeparment.TabIndex = 16;
            this.cmbDeparment.SelectedIndexChanged += new System.EventHandler(this.cmbDeparment_SelectedIndexChanged);
            this.cmbDeparment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(714, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 26);
            this.label6.TabIndex = 43;
            this.label6.Text = "Department";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.cmbDeparment);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbNameLaoP);
            this.groupBox1.Controls.Add(this.cmbNameEngP);
            this.groupBox1.Controls.Add(this.txtSurNameLao);
            this.groupBox1.Controls.Add(this.cmbNameLaoQ);
            this.groupBox1.Controls.Add(this.cmbNameEngQ);
            this.groupBox1.Controls.Add(this.dpBrithDate);
            this.groupBox1.Controls.Add(this.gbStatus);
            this.groupBox1.Controls.Add(this.txtSurNameEng);
            this.groupBox1.Controls.Add(this.gbGender);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtProvince);
            this.groupBox1.Controls.Add(this.txtVillage);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNameEng);
            this.groupBox1.Controls.Add(this.txtDistrict);
            this.groupBox1.Controls.Add(this.txtNameLao);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.txtFacebook);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 347);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Information";
            // 
            // cmbNameLaoP
            // 
            this.cmbNameLaoP.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNameLaoP.FormattingEnabled = true;
            this.cmbNameLaoP.Location = new System.Drawing.Point(714, 230);
            this.cmbNameLaoP.Name = "cmbNameLaoP";
            this.cmbNameLaoP.Size = new System.Drawing.Size(189, 34);
            this.cmbNameLaoP.TabIndex = 15;
            this.cmbNameLaoP.SelectedIndexChanged += new System.EventHandler(this.cmbNameLaoP_SelectedIndexChanged);
            this.cmbNameLaoP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // cmbNameLaoQ
            // 
            this.cmbNameLaoQ.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNameLaoQ.FormattingEnabled = true;
            this.cmbNameLaoQ.Location = new System.Drawing.Point(714, 105);
            this.cmbNameLaoQ.Name = "cmbNameLaoQ";
            this.cmbNameLaoQ.Size = new System.Drawing.Size(189, 34);
            this.cmbNameLaoQ.TabIndex = 13;
            this.cmbNameLaoQ.SelectedIndexChanged += new System.EventHandler(this.cmbNameLaoQ_SelectedIndexChanged);
            this.cmbNameLaoQ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_EnterNextControl);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(714, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = "Position(Lao)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Lao_Ketmany2", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(714, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 26);
            this.label17.TabIndex = 30;
            this.label17.Text = "Qualification(Lao)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btExit);
            this.groupBox2.Controls.Add(this.btEdit);
            this.groupBox2.Controls.Add(this.btSave);
            this.groupBox2.Controls.Add(this.btPrint);
            this.groupBox2.Controls.Add(this.btDelete);
            this.groupBox2.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(936, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 347);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Staff";
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.Color.White;
            this.btExit.Location = new System.Drawing.Point(28, 286);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(69, 39);
            this.btExit.TabIndex = 48;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.button7_Click);
            // 
            // btEdit
            // 
            this.btEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.Color.White;
            this.btEdit.Location = new System.Drawing.Point(28, 103);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(69, 39);
            this.btEdit.TabIndex = 46;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.button3_Click);
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Location = new System.Drawing.Point(28, 44);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(69, 39);
            this.btSave.TabIndex = 15;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(28, 159);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(69, 39);
            this.btDelete.TabIndex = 45;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.AllowUserToResizeColumns = false;
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStaff.ColumnHeadersHeight = 35;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStaff.Location = new System.Drawing.Point(14, 361);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStaff.RowHeadersWidth = 5;
            this.dgvStaff.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStaff.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStaff.RowTemplate.Height = 30;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(1049, 279);
            this.dgvStaff.TabIndex = 48;
            this.dgvStaff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellDoubleClick_1);
            // 
            // btPrint
            // 
            this.btPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148)))));
            this.btPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPrint.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrint.ForeColor = System.Drawing.Color.White;
            this.btPrint.Location = new System.Drawing.Point(28, 222);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(69, 39);
            this.btPrint.TabIndex = 45;
            this.btPrint.Text = "Print";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // frmStaff
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1080, 651);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "frmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStaff";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSurNameLao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSurNameEng;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtFacebook;
        private System.Windows.Forms.TextBox txtNameLao;
        private System.Windows.Forms.TextBox txtNameEng;
        private System.Windows.Forms.TextBox txtVillage;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rdbMarried;
        private System.Windows.Forms.RadioButton rdbSingle;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaDateTimePicker dpBrithDate;
        private System.Windows.Forms.ComboBox cmbNameEngQ;
        private System.Windows.Forms.ComboBox cmbNameEngP;
        private System.Windows.Forms.ComboBox cmbDeparment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.ComboBox cmbNameLaoP;
        private System.Windows.Forms.ComboBox cmbNameLaoQ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btPrint;
    }
}