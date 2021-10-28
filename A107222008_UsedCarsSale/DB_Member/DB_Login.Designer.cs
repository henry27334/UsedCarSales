namespace A107222008_UsedCar
{
    partial class frmLogin
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
            this.lbA = new System.Windows.Forms.Label();
            this.lbP = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.cbxChoice = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbIdentity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbA.Location = new System.Drawing.Point(33, 119);
            this.lbA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(129, 40);
            this.lbA.TabIndex = 7;
            this.lbA.Text = "會員帳號";
            // 
            // lbP
            // 
            this.lbP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbP.Location = new System.Drawing.Point(33, 184);
            this.lbP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbP.Name = "lbP";
            this.lbP.Size = new System.Drawing.Size(129, 40);
            this.lbP.TabIndex = 8;
            this.lbP.Text = "會員密碼";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(197, 119);
            this.tbxId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxId.MaxLength = 12;
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(200, 25);
            this.tbxId.TabIndex = 25;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(197, 184);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPassword.MaxLength = 12;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(200, 25);
            this.tbxPassword.TabIndex = 26;
            // 
            // cbxChoice
            // 
            this.cbxChoice.Font = new System.Drawing.Font("新細明體", 12F);
            this.cbxChoice.FormattingEnabled = true;
            this.cbxChoice.Items.AddRange(new object[] {
            "買家",
            "賣家"});
            this.cbxChoice.Location = new System.Drawing.Point(197, 51);
            this.cbxChoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxChoice.Name = "cbxChoice";
            this.cbxChoice.Size = new System.Drawing.Size(200, 28);
            this.cbxChoice.TabIndex = 32;
            this.cbxChoice.Text = "買家";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogin.Location = new System.Drawing.Point(160, 265);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(129, 48);
            this.btnLogin.TabIndex = 33;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExit.Location = new System.Drawing.Point(315, 265);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 48);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbIdentity
            // 
            this.lbIdentity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbIdentity.Location = new System.Drawing.Point(33, 51);
            this.lbIdentity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdentity.Name = "lbIdentity";
            this.lbIdentity.Size = new System.Drawing.Size(129, 40);
            this.lbIdentity.TabIndex = 35;
            this.lbIdentity.Text = "會員身分";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 424);
            this.Controls.Add(this.lbIdentity);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cbxChoice);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.lbP);
            this.Controls.Add(this.lbA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLogin";
            this.Text = "會員登入";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbP;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.ComboBox cbxChoice;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbIdentity;
    }
}