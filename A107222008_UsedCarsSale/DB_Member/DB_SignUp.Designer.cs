namespace A107222008_UsedCar
{
    partial class frmSignUp
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
            this.cbxChoice = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tbxphoneNumber = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbSU = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEarnestMoney = new System.Windows.Forms.Label();
            this.tbxEarnestMoney = new System.Windows.Forms.TextBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbxChoice
            // 
            this.cbxChoice.Font = new System.Drawing.Font("新細明體", 12F);
            this.cbxChoice.FormattingEnabled = true;
            this.cbxChoice.Items.AddRange(new object[] {
            "買家",
            "賣家"});
            this.cbxChoice.Location = new System.Drawing.Point(237, 84);
            this.cbxChoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxChoice.Name = "cbxChoice";
            this.cbxChoice.Size = new System.Drawing.Size(200, 28);
            this.cbxChoice.TabIndex = 78;
            this.cbxChoice.Text = "買家";
            this.cbxChoice.SelectedIndexChanged += new System.EventHandler(this.cbxChoice_SelectedIndexChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("新細明體", 15F);
            this.lblAddress.Location = new System.Drawing.Point(52, 354);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 25);
            this.lblAddress.TabIndex = 76;
            this.lblAddress.Text = "地址";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(237, 354);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAddress.MaxLength = 40;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(200, 25);
            this.tbxAddress.TabIndex = 74;
            this.tbxAddress.TextChanged += new System.EventHandler(this.tbxAddress_TextChanged);
            this.tbxAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAddress_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("新細明體", 15F);
            this.lblEmail.Location = new System.Drawing.Point(52, 462);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(112, 25);
            this.lblEmail.TabIndex = 72;
            this.lblEmail.Text = "電子郵件";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("新細明體", 15F);
            this.lblPhoneNumber.Location = new System.Drawing.Point(52, 411);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(112, 25);
            this.lblPhoneNumber.TabIndex = 73;
            this.lblPhoneNumber.Text = "電話號碼";
            // 
            // tbxphoneNumber
            // 
            this.tbxphoneNumber.Location = new System.Drawing.Point(237, 409);
            this.tbxphoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxphoneNumber.MaxLength = 10;
            this.tbxphoneNumber.Name = "tbxphoneNumber";
            this.tbxphoneNumber.Size = new System.Drawing.Size(200, 25);
            this.tbxphoneNumber.TabIndex = 71;
            this.tbxphoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxphoneNumber_KeyPress);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(237, 462);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEmail.MaxLength = 40;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(200, 25);
            this.tbxEmail.TabIndex = 70;
            this.tbxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEmail_KeyPress);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("新細明體", 15F);
            this.lblName.Location = new System.Drawing.Point(52, 248);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 25);
            this.lblName.TabIndex = 68;
            this.lblName.Text = "名字";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("新細明體", 15F);
            this.lblGender.Location = new System.Drawing.Point(52, 302);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(62, 25);
            this.lblGender.TabIndex = 69;
            this.lblGender.Text = "性別";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(237, 248);
            this.tbxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxName.MaxLength = 20;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(200, 25);
            this.tbxName.TabIndex = 66;
            this.tbxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxName_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("新細明體", 15F);
            this.lblID.Location = new System.Drawing.Point(52, 139);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(62, 25);
            this.lblID.TabIndex = 62;
            this.lblID.Text = "帳號";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("新細明體", 15F);
            this.lblPassword.Location = new System.Drawing.Point(52, 194);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 25);
            this.lblPassword.TabIndex = 63;
            this.lblPassword.Text = "密碼";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnInsert.Location = new System.Drawing.Point(501, 75);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(101, 46);
            this.btnInsert.TabIndex = 65;
            this.btnInsert.Text = "註冊";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(237, 194);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPassword.MaxLength = 12;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(200, 25);
            this.tbxPassword.TabIndex = 61;
            this.tbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPassword_KeyPress);
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(237, 139);
            this.tbxId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxId.MaxLength = 12;
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(200, 25);
            this.tbxId.TabIndex = 60;
            this.tbxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxId_KeyPress);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnExit.Location = new System.Drawing.Point(501, 139);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 45);
            this.btnExit.TabIndex = 64;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbSU
            // 
            this.lbSU.AutoSize = true;
            this.lbSU.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbSU.Location = new System.Drawing.Point(52, 28);
            this.lbSU.Name = "lbSU";
            this.lbSU.Size = new System.Drawing.Size(112, 25);
            this.lbSU.TabIndex = 79;
            this.lbSU.Text = "註冊會員";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(52, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 80;
            this.label1.Text = "註冊身分";
            // 
            // lblEarnestMoney
            // 
            this.lblEarnestMoney.AutoSize = true;
            this.lblEarnestMoney.Font = new System.Drawing.Font("新細明體", 15F);
            this.lblEarnestMoney.Location = new System.Drawing.Point(52, 302);
            this.lblEarnestMoney.Name = "lblEarnestMoney";
            this.lblEarnestMoney.Size = new System.Drawing.Size(87, 25);
            this.lblEarnestMoney.TabIndex = 98;
            this.lblEarnestMoney.Text = "保證金";
            // 
            // tbxEarnestMoney
            // 
            this.tbxEarnestMoney.Font = new System.Drawing.Font("新細明體", 12F);
            this.tbxEarnestMoney.Location = new System.Drawing.Point(237, 298);
            this.tbxEarnestMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEarnestMoney.MaxLength = 10;
            this.tbxEarnestMoney.Name = "tbxEarnestMoney";
            this.tbxEarnestMoney.Size = new System.Drawing.Size(200, 31);
            this.tbxEarnestMoney.TabIndex = 96;
            this.tbxEarnestMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEarnestMoney_KeyPress);
            // 
            // cbxGender
            // 
            this.cbxGender.Font = new System.Drawing.Font("新細明體", 12F);
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "男性",
            "女性"});
            this.cbxGender.Location = new System.Drawing.Point(237, 298);
            this.cbxGender.Margin = new System.Windows.Forms.Padding(4);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(200, 28);
            this.cbxGender.TabIndex = 99;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 570);
            this.Controls.Add(this.cbxGender);
            this.Controls.Add(this.lblEarnestMoney);
            this.Controls.Add(this.tbxEarnestMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSU);
            this.Controls.Add(this.cbxChoice);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.tbxphoneNumber);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSignUp";
            this.Text = "會員註冊";
            this.Load += new System.EventHandler(this.frmSignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxChoice;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox tbxphoneNumber;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbSU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEarnestMoney;
        private System.Windows.Forms.TextBox tbxEarnestMoney;
        private System.Windows.Forms.ComboBox cbxGender;
    }
}