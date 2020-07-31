namespace CShard_3cs2_Lad_P2_Salary
{
    partial class frmCreateUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbNameLaoP = new System.Windows.Forms.ComboBox();
            this.cmbNameEngP = new System.Windows.Forms.ComboBox();
            this.txtRepass = new System.Windows.Forms.TextBox();
            this.txtNewpass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtstaff_id = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnewuser = new System.Windows.Forms.Button();
            this.brexit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Alice5 95", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "New User";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.cmbNameLaoP);
            this.groupBox1.Controls.Add(this.cmbNameEngP);
            this.groupBox1.Controls.Add(this.txtRepass);
            this.groupBox1.Controls.Add(this.txtNewpass);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.txtstaff_id);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(546, 342);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input information";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Lao_Ketmany2", 12F);
            this.txtName.Location = new System.Drawing.Point(38, 215);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 36);
            this.txtName.TabIndex = 7;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // cmbNameLaoP
            // 
            this.cmbNameLaoP.Font = new System.Drawing.Font("Lao_Ketmany2", 12F);
            this.cmbNameLaoP.FormattingEnabled = true;
            this.cmbNameLaoP.Location = new System.Drawing.Point(285, 59);
            this.cmbNameLaoP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbNameLaoP.Name = "cmbNameLaoP";
            this.cmbNameLaoP.Size = new System.Drawing.Size(227, 36);
            this.cmbNameLaoP.TabIndex = 3;
            this.cmbNameLaoP.SelectedIndexChanged += new System.EventHandler(this.cmbNameLaoP_SelectedIndexChanged);
            this.cmbNameLaoP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Enter);
            // 
            // cmbNameEngP
            // 
            this.cmbNameEngP.Font = new System.Drawing.Font("Lao_Ketmany2", 12F);
            this.cmbNameEngP.FormattingEnabled = true;
            this.cmbNameEngP.Location = new System.Drawing.Point(38, 285);
            this.cmbNameEngP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbNameEngP.Name = "cmbNameEngP";
            this.cmbNameEngP.Size = new System.Drawing.Size(227, 36);
            this.cmbNameEngP.TabIndex = 2;
            this.cmbNameEngP.SelectedIndexChanged += new System.EventHandler(this.cmbPosition_SelectedIndexChanged);
            this.cmbNameEngP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Enter);
            // 
            // txtRepass
            // 
            this.txtRepass.Font = new System.Drawing.Font("Lao_Ketmany2", 12F);
            this.txtRepass.Location = new System.Drawing.Point(285, 285);
            this.txtRepass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRepass.Name = "txtRepass";
            this.txtRepass.Size = new System.Drawing.Size(227, 36);
            this.txtRepass.TabIndex = 6;
            this.txtRepass.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtRepass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Enter);
            // 
            // txtNewpass
            // 
            this.txtNewpass.Font = new System.Drawing.Font("Lao_Ketmany2", 12F);
            this.txtNewpass.Location = new System.Drawing.Point(285, 215);
            this.txtNewpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewpass.Name = "txtNewpass";
            this.txtNewpass.Size = new System.Drawing.Size(227, 36);
            this.txtNewpass.TabIndex = 5;
            this.txtNewpass.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtNewpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Enter);
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Lao_Ketmany2", 12F);
            this.txtUser.Location = new System.Drawing.Point(285, 141);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(227, 36);
            this.txtUser.TabIndex = 4;
            this.txtUser.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Enter);
            // 
            // txtstaff_id
            // 
            this.txtstaff_id.Font = new System.Drawing.Font("Lao_Ketmany2", 12F);
            this.txtstaff_id.Location = new System.Drawing.Point(38, 141);
            this.txtstaff_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtstaff_id.Name = "txtstaff_id";
            this.txtstaff_id.Size = new System.Drawing.Size(227, 36);
            this.txtstaff_id.TabIndex = 1;
            this.txtstaff_id.TextChanged += new System.EventHandler(this.txtstaff_id_TextChanged);
            this.txtstaff_id.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtstaff_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Enter);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Lao_Ketmany2", 12F);
            this.txtID.Location = new System.Drawing.Point(38, 59);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(227, 36);
            this.txtID.TabIndex = 0;
            this.txtID.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lao_Ketmany2", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(285, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Position (Lao)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lao_Ketmany2", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(38, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lao_Ketmany2", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(285, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Re-password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lao_Ketmany2", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(38, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Position (English)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lao_Ketmany2", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(285, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "New password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lao_Ketmany2", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(38, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Staff ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lao_Ketmany2", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(285, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lao_Ketmany2", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(38, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // btnewuser
            // 
            this.btnewuser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnewuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnewuser.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnewuser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnewuser.Location = new System.Drawing.Point(176, 423);
            this.btnewuser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnewuser.Name = "btnewuser";
            this.btnewuser.Size = new System.Drawing.Size(106, 47);
            this.btnewuser.TabIndex = 7;
            this.btnewuser.Text = "New user";
            this.btnewuser.UseVisualStyleBackColor = true;
            this.btnewuser.Click += new System.EventHandler(this.btnewuser_Click);
            // 
            // brexit
            // 
            this.brexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.brexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brexit.Font = new System.Drawing.Font("Lao_Ketmany2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.brexit.Location = new System.Drawing.Point(297, 423);
            this.brexit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.brexit.Name = "brexit";
            this.brexit.Size = new System.Drawing.Size(65, 47);
            this.brexit.TabIndex = 8;
            this.brexit.Text = "Exit";
            this.brexit.UseVisualStyleBackColor = true;
            this.brexit.Click += new System.EventHandler(this.brexit_Click);
            // 
            // frmCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(570, 483);
            this.Controls.Add(this.brexit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnewuser);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewpass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtstaff_id;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRepass;
        private System.Windows.Forms.Button btnewuser;
        private System.Windows.Forms.Button brexit;
        private System.Windows.Forms.ComboBox cmbNameEngP;
        private System.Windows.Forms.ComboBox cmbNameLaoP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtName;
    }
}