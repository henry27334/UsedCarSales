namespace A107222008_UsedCar
{
    partial class frmCarMenu
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
            this.cbxCarBrand = new System.Windows.Forms.ComboBox();
            this.cbxCarType = new System.Windows.Forms.ComboBox();
            this.cbxCarStyle = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnBuyerCR = new System.Windows.Forms.Button();
            this.btnSellerSC = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSellerCR = new System.Windows.Forms.Button();
            this.lbCB = new System.Windows.Forms.Label();
            this.lbCT = new System.Windows.Forms.Label();
            this.lbCS = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnSCarOrder = new System.Windows.Forms.Button();
            this.btnBCarOrder = new System.Windows.Forms.Button();
            this.lbEC = new System.Windows.Forms.Label();
            this.nudMinPrice = new System.Windows.Forms.NumericUpDown();
            this.nudMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.lbbbb = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lbCarAge = new System.Windows.Forms.Label();
            this.nudCarAge = new System.Windows.Forms.NumericUpDown();
            this.lbPassenger = new System.Windows.Forms.Label();
            this.cbxPassenger = new System.Windows.Forms.ComboBox();
            this.cbxCarDoor = new System.Windows.Forms.ComboBox();
            this.lblDoor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarAge)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCarBrand
            // 
            this.cbxCarBrand.Font = new System.Drawing.Font("新細明體", 15F);
            this.cbxCarBrand.FormattingEnabled = true;
            this.cbxCarBrand.Location = new System.Drawing.Point(153, 150);
            this.cbxCarBrand.Name = "cbxCarBrand";
            this.cbxCarBrand.Size = new System.Drawing.Size(121, 28);
            this.cbxCarBrand.TabIndex = 6;
            this.cbxCarBrand.SelectedIndexChanged += new System.EventHandler(this.cbxCarBrand_SelectedIndexChanged_1);
            // 
            // cbxCarType
            // 
            this.cbxCarType.Font = new System.Drawing.Font("新細明體", 15F);
            this.cbxCarType.FormattingEnabled = true;
            this.cbxCarType.Location = new System.Drawing.Point(319, 150);
            this.cbxCarType.Name = "cbxCarType";
            this.cbxCarType.Size = new System.Drawing.Size(125, 28);
            this.cbxCarType.TabIndex = 7;
            this.cbxCarType.SelectedIndexChanged += new System.EventHandler(this.cbxCarType_SelectedIndexChanged);
            // 
            // cbxCarStyle
            // 
            this.cbxCarStyle.Font = new System.Drawing.Font("新細明體", 15F);
            this.cbxCarStyle.FormattingEnabled = true;
            this.cbxCarStyle.Location = new System.Drawing.Point(481, 150);
            this.cbxCarStyle.Name = "cbxCarStyle";
            this.cbxCarStyle.Size = new System.Drawing.Size(121, 28);
            this.cbxCarStyle.TabIndex = 8;
            this.cbxCarStyle.Visible = false;
            this.cbxCarStyle.SelectedIndexChanged += new System.EventHandler(this.cbxCarStyle_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnSearch.Location = new System.Drawing.Point(507, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "尋找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(137, 63);
            this.tbxSearch.MaxLength = 30;
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(343, 22);
            this.tbxSearch.TabIndex = 11;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogin.Location = new System.Drawing.Point(1057, 589);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 38);
            this.btnLogin.TabIndex = 34;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSignUp.Location = new System.Drawing.Point(938, 589);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(97, 38);
            this.btnSignUp.TabIndex = 35;
            this.btnSignUp.Text = "註冊";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click_1);
            // 
            // btnBuyerCR
            // 
            this.btnBuyerCR.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBuyerCR.Location = new System.Drawing.Point(938, 589);
            this.btnBuyerCR.Name = "btnBuyerCR";
            this.btnBuyerCR.Size = new System.Drawing.Size(97, 38);
            this.btnBuyerCR.TabIndex = 36;
            this.btnBuyerCR.Text = "查詢評價";
            this.btnBuyerCR.UseVisualStyleBackColor = true;
            this.btnBuyerCR.Click += new System.EventHandler(this.btnSellerCR_Click);
            // 
            // btnSellerSC
            // 
            this.btnSellerSC.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSellerSC.Location = new System.Drawing.Point(696, 589);
            this.btnSellerSC.Name = "btnSellerSC";
            this.btnSellerSC.Size = new System.Drawing.Size(97, 38);
            this.btnSellerSC.TabIndex = 37;
            this.btnSellerSC.Text = "賣車GO";
            this.btnSellerSC.UseVisualStyleBackColor = true;
            this.btnSellerSC.Click += new System.EventHandler(this.btnSellerSC_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogout.Location = new System.Drawing.Point(1057, 589);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(97, 38);
            this.btnLogout.TabIndex = 38;
            this.btnLogout.Text = "登出";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSellerCR
            // 
            this.btnSellerCR.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSellerCR.Location = new System.Drawing.Point(938, 589);
            this.btnSellerCR.Name = "btnSellerCR";
            this.btnSellerCR.Size = new System.Drawing.Size(97, 38);
            this.btnSellerCR.TabIndex = 39;
            this.btnSellerCR.Text = "查詢評價";
            this.btnSellerCR.UseVisualStyleBackColor = true;
            this.btnSellerCR.Click += new System.EventHandler(this.btnSellerCR_Click_1);
            // 
            // lbCB
            // 
            this.lbCB.AutoSize = true;
            this.lbCB.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbCB.Location = new System.Drawing.Point(153, 117);
            this.lbCB.Name = "lbCB";
            this.lbCB.Size = new System.Drawing.Size(49, 20);
            this.lbCB.TabIndex = 41;
            this.lbCB.Text = "廠牌";
            // 
            // lbCT
            // 
            this.lbCT.AutoSize = true;
            this.lbCT.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbCT.Location = new System.Drawing.Point(324, 117);
            this.lbCT.Name = "lbCT";
            this.lbCT.Size = new System.Drawing.Size(49, 20);
            this.lbCT.TabIndex = 42;
            this.lbCT.Text = "車款";
            // 
            // lbCS
            // 
            this.lbCS.AutoSize = true;
            this.lbCS.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbCS.Location = new System.Drawing.Point(477, 117);
            this.lbCS.Name = "lbCS";
            this.lbCS.Size = new System.Drawing.Size(49, 20);
            this.lbCS.TabIndex = 43;
            this.lbCS.Text = "車型";
            // 
            // dgvData
            // 
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(92, 206);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(1072, 353);
            this.dgvData.TabIndex = 5;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_RowValidated);
            this.dgvData.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvData_UserAddedRow);
            // 
            // btnSCarOrder
            // 
            this.btnSCarOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSCarOrder.Location = new System.Drawing.Point(814, 589);
            this.btnSCarOrder.Name = "btnSCarOrder";
            this.btnSCarOrder.Size = new System.Drawing.Size(97, 38);
            this.btnSCarOrder.TabIndex = 44;
            this.btnSCarOrder.Text = "訂單交易";
            this.btnSCarOrder.UseVisualStyleBackColor = true;
            this.btnSCarOrder.Click += new System.EventHandler(this.btnCarOrder_Click);
            // 
            // btnBCarOrder
            // 
            this.btnBCarOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBCarOrder.Location = new System.Drawing.Point(814, 589);
            this.btnBCarOrder.Name = "btnBCarOrder";
            this.btnBCarOrder.Size = new System.Drawing.Size(97, 38);
            this.btnBCarOrder.TabIndex = 45;
            this.btnBCarOrder.Text = "訂單交易";
            this.btnBCarOrder.UseVisualStyleBackColor = true;
            this.btnBCarOrder.Click += new System.EventHandler(this.btnBCarOrder_Click);
            // 
            // lbEC
            // 
            this.lbEC.AutoSize = true;
            this.lbEC.BackColor = System.Drawing.SystemColors.Control;
            this.lbEC.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbEC.Location = new System.Drawing.Point(137, 28);
            this.lbEC.Name = "lbEC";
            this.lbEC.Size = new System.Drawing.Size(149, 20);
            this.lbEC.TabIndex = 46;
            this.lbEC.Text = "輸入想要的車子";
            // 
            // nudMinPrice
            // 
            this.nudMinPrice.Font = new System.Drawing.Font("新細明體", 15F);
            this.nudMinPrice.Location = new System.Drawing.Point(660, 151);
            this.nudMinPrice.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMinPrice.Name = "nudMinPrice";
            this.nudMinPrice.Size = new System.Drawing.Size(128, 31);
            this.nudMinPrice.TabIndex = 49;
            this.nudMinPrice.ValueChanged += new System.EventHandler(this.nudMinPrice_ValueChanged);
            // 
            // nudMaxPrice
            // 
            this.nudMaxPrice.Font = new System.Drawing.Font("新細明體", 15F);
            this.nudMaxPrice.Location = new System.Drawing.Point(819, 152);
            this.nudMaxPrice.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudMaxPrice.Name = "nudMaxPrice";
            this.nudMaxPrice.Size = new System.Drawing.Size(120, 31);
            this.nudMaxPrice.TabIndex = 50;
            this.nudMaxPrice.ValueChanged += new System.EventHandler(this.nudMaxPrice_ValueChanged);
            this.nudMaxPrice.Leave += new System.EventHandler(this.nudMaxPrice_Leave);
            // 
            // lbbbb
            // 
            this.lbbbb.AutoSize = true;
            this.lbbbb.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbbbb.Location = new System.Drawing.Point(794, 158);
            this.lbbbb.Name = "lbbbb";
            this.lbbbb.Size = new System.Drawing.Size(19, 20);
            this.lbbbb.TabIndex = 51;
            this.lbbbb.Text = "~";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbPrice.Location = new System.Drawing.Point(668, 117);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(89, 20);
            this.lbPrice.TabIndex = 52;
            this.lbPrice.Text = "價格範圍";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnConfirm.Location = new System.Drawing.Point(969, 152);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(88, 31);
            this.btnConfirm.TabIndex = 53;
            this.btnConfirm.Text = "確定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lbCarAge
            // 
            this.lbCarAge.AutoSize = true;
            this.lbCarAge.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbCarAge.Location = new System.Drawing.Point(954, 28);
            this.lbCarAge.Name = "lbCarAge";
            this.lbCarAge.Size = new System.Drawing.Size(146, 20);
            this.lbCarAge.TabIndex = 67;
            this.lbCarAge.Text = "車齡 (幾年以內)";
            // 
            // nudCarAge
            // 
            this.nudCarAge.Font = new System.Drawing.Font("新細明體", 15F);
            this.nudCarAge.Location = new System.Drawing.Point(958, 63);
            this.nudCarAge.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudCarAge.Name = "nudCarAge";
            this.nudCarAge.Size = new System.Drawing.Size(142, 31);
            this.nudCarAge.TabIndex = 66;
            this.nudCarAge.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lbPassenger
            // 
            this.lbPassenger.AutoSize = true;
            this.lbPassenger.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbPassenger.Location = new System.Drawing.Point(806, 28);
            this.lbPassenger.Name = "lbPassenger";
            this.lbPassenger.Size = new System.Drawing.Size(69, 20);
            this.lbPassenger.TabIndex = 65;
            this.lbPassenger.Text = "乘客數";
            // 
            // cbxPassenger
            // 
            this.cbxPassenger.Font = new System.Drawing.Font("新細明體", 15F);
            this.cbxPassenger.FormattingEnabled = true;
            this.cbxPassenger.Location = new System.Drawing.Point(810, 62);
            this.cbxPassenger.Name = "cbxPassenger";
            this.cbxPassenger.Size = new System.Drawing.Size(121, 28);
            this.cbxPassenger.TabIndex = 64;
            // 
            // cbxCarDoor
            // 
            this.cbxCarDoor.Font = new System.Drawing.Font("新細明體", 15F);
            this.cbxCarDoor.FormattingEnabled = true;
            this.cbxCarDoor.Location = new System.Drawing.Point(662, 62);
            this.cbxCarDoor.Name = "cbxCarDoor";
            this.cbxCarDoor.Size = new System.Drawing.Size(121, 28);
            this.cbxCarDoor.TabIndex = 63;
            // 
            // lblDoor
            // 
            this.lblDoor.AutoSize = true;
            this.lblDoor.Font = new System.Drawing.Font("新細明體", 15F);
            this.lblDoor.Location = new System.Drawing.Point(668, 28);
            this.lblDoor.Name = "lblDoor";
            this.lblDoor.Size = new System.Drawing.Size(69, 20);
            this.lblDoor.TabIndex = 62;
            this.lblDoor.Text = "車門數";
            // 
            // frmCarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1251, 676);
            this.Controls.Add(this.lbCarAge);
            this.Controls.Add(this.nudCarAge);
            this.Controls.Add(this.lbPassenger);
            this.Controls.Add(this.cbxPassenger);
            this.Controls.Add(this.cbxCarDoor);
            this.Controls.Add(this.lblDoor);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbbbb);
            this.Controls.Add(this.nudMaxPrice);
            this.Controls.Add(this.nudMinPrice);
            this.Controls.Add(this.lbEC);
            this.Controls.Add(this.btnBCarOrder);
            this.Controls.Add(this.btnSCarOrder);
            this.Controls.Add(this.lbCS);
            this.Controls.Add(this.lbCT);
            this.Controls.Add(this.lbCB);
            this.Controls.Add(this.btnSellerCR);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSellerSC);
            this.Controls.Add(this.btnBuyerCR);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbxCarStyle);
            this.Controls.Add(this.cbxCarType);
            this.Controls.Add(this.cbxCarBrand);
            this.Controls.Add(this.dgvData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCarMenu";
            this.Text = "車子清單";
            this.Load += new System.EventHandler(this.frmDBTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxCarBrand;
        private System.Windows.Forms.ComboBox cbxCarType;
        private System.Windows.Forms.ComboBox cbxCarStyle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnBuyerCR;
        private System.Windows.Forms.Button btnSellerSC;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSellerCR;
        private System.Windows.Forms.Label lbCB;
        private System.Windows.Forms.Label lbCT;
        private System.Windows.Forms.Label lbCS;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnSCarOrder;
        private System.Windows.Forms.Button btnBCarOrder;
        private System.Windows.Forms.Label lbEC;
        private System.Windows.Forms.NumericUpDown nudMinPrice;
        private System.Windows.Forms.NumericUpDown nudMaxPrice;
        private System.Windows.Forms.Label lbbbb;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lbCarAge;
        private System.Windows.Forms.NumericUpDown nudCarAge;
        private System.Windows.Forms.Label lbPassenger;
        private System.Windows.Forms.ComboBox cbxPassenger;
        private System.Windows.Forms.ComboBox cbxCarDoor;
        private System.Windows.Forms.Label lblDoor;
    }
}