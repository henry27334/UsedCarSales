
namespace A107222008_UsedCar
{
    partial class frmCarDealerInsert
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.tbxRegion = new System.Windows.Forms.TextBox();
            this.tbxCarAge = new System.Windows.Forms.TextBox();
            this.tbxLicensePlate = new System.Windows.Forms.TextBox();
            this.btnCarDealerInsert = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.cbxCarStyle = new System.Windows.Forms.ComboBox();
            this.cbxCarType = new System.Windows.Forms.ComboBox();
            this.cbxCarBrand = new System.Windows.Forms.ComboBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lbCS = new System.Windows.Forms.Label();
            this.lbCT = new System.Windows.Forms.Label();
            this.lbCB = new System.Windows.Forms.Label();
            this.tclPage = new System.Windows.Forms.TabControl();
            this.tpAddCar = new System.Windows.Forms.TabPage();
            this.tpMyCar = new System.Windows.Forms.TabPage();
            this.lblR = new System.Windows.Forms.Label();
            this.cbxCP = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbFOFS = new System.Windows.Forms.Label();
            this.dgvSelling = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.tclPage.SuspendLayout();
            this.tpAddCar.SuspendLayout();
            this.tpMyCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelling)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(52, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "請輸入車所在地區 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(52, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "請輸入購車年份 (西元) : ";
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLicensePlate.Location = new System.Drawing.Point(52, 107);
            this.lblLicensePlate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(101, 20);
            this.lblLicensePlate.TabIndex = 55;
            this.lblLicensePlate.Text = "請輸入車牌 : ";
            // 
            // tbxRegion
            // 
            this.tbxRegion.Font = new System.Drawing.Font("新細明體", 12F);
            this.tbxRegion.Location = new System.Drawing.Point(246, 187);
            this.tbxRegion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxRegion.Multiline = true;
            this.tbxRegion.Name = "tbxRegion";
            this.tbxRegion.Size = new System.Drawing.Size(93, 27);
            this.tbxRegion.TabIndex = 54;
            // 
            // tbxCarAge
            // 
            this.tbxCarAge.Font = new System.Drawing.Font("新細明體", 12F);
            this.tbxCarAge.Location = new System.Drawing.Point(246, 148);
            this.tbxCarAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxCarAge.MaxLength = 4;
            this.tbxCarAge.Multiline = true;
            this.tbxCarAge.Name = "tbxCarAge";
            this.tbxCarAge.Size = new System.Drawing.Size(93, 27);
            this.tbxCarAge.TabIndex = 53;
            this.tbxCarAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCarAge_KeyPress);
            // 
            // tbxLicensePlate
            // 
            this.tbxLicensePlate.Font = new System.Drawing.Font("新細明體", 12F);
            this.tbxLicensePlate.Location = new System.Drawing.Point(246, 107);
            this.tbxLicensePlate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxLicensePlate.MaxLength = 7;
            this.tbxLicensePlate.Multiline = true;
            this.tbxLicensePlate.Name = "tbxLicensePlate";
            this.tbxLicensePlate.Size = new System.Drawing.Size(93, 27);
            this.tbxLicensePlate.TabIndex = 51;
            this.tbxLicensePlate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLicensePlate_KeyPress);
            // 
            // btnCarDealerInsert
            // 
            this.btnCarDealerInsert.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCarDealerInsert.Location = new System.Drawing.Point(604, 232);
            this.btnCarDealerInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCarDealerInsert.Name = "btnCarDealerInsert";
            this.btnCarDealerInsert.Size = new System.Drawing.Size(81, 38);
            this.btnCarDealerInsert.TabIndex = 50;
            this.btnCarDealerInsert.Text = "新增車子";
            this.btnCarDealerInsert.UseVisualStyleBackColor = true;
            this.btnCarDealerInsert.Click += new System.EventHandler(this.btnCarDealerInsert_Click_1);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToResizeColumns = false;
            this.dgvData.AllowUserToResizeRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(6, 293);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(721, 352);
            this.dgvData.TabIndex = 49;
            // 
            // cbxCarStyle
            // 
            this.cbxCarStyle.Font = new System.Drawing.Font("新細明體", 15F);
            this.cbxCarStyle.FormattingEnabled = true;
            this.cbxCarStyle.Location = new System.Drawing.Point(360, 52);
            this.cbxCarStyle.Name = "cbxCarStyle";
            this.cbxCarStyle.Size = new System.Drawing.Size(129, 28);
            this.cbxCarStyle.TabIndex = 48;
            this.cbxCarStyle.Visible = false;
            this.cbxCarStyle.SelectedIndexChanged += new System.EventHandler(this.cbxCarStyle_SelectedIndexChanged);
            // 
            // cbxCarType
            // 
            this.cbxCarType.Font = new System.Drawing.Font("新細明體", 15F);
            this.cbxCarType.FormattingEnabled = true;
            this.cbxCarType.Location = new System.Drawing.Point(218, 52);
            this.cbxCarType.Name = "cbxCarType";
            this.cbxCarType.Size = new System.Drawing.Size(121, 28);
            this.cbxCarType.TabIndex = 47;
            this.cbxCarType.SelectedIndexChanged += new System.EventHandler(this.cbxCarType_SelectedIndexChanged);
            // 
            // cbxCarBrand
            // 
            this.cbxCarBrand.Font = new System.Drawing.Font("新細明體", 15F);
            this.cbxCarBrand.FormattingEnabled = true;
            this.cbxCarBrand.Location = new System.Drawing.Point(56, 52);
            this.cbxCarBrand.Name = "cbxCarBrand";
            this.cbxCarBrand.Size = new System.Drawing.Size(131, 28);
            this.cbxCarBrand.TabIndex = 46;
            this.cbxCarBrand.SelectedIndexChanged += new System.EventHandler(this.cbxCarBrand_SelectedIndexChanged);
            // 
            // tbxPrice
            // 
            this.tbxPrice.Font = new System.Drawing.Font("新細明體", 12F);
            this.tbxPrice.Location = new System.Drawing.Point(246, 232);
            this.tbxPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxPrice.MaxLength = 12;
            this.tbxPrice.Multiline = true;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(93, 27);
            this.tbxPrice.TabIndex = 62;
            this.tbxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrice_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.Location = new System.Drawing.Point(56, 232);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(93, 20);
            this.lblPrice.TabIndex = 61;
            this.lblPrice.Text = "請輸入價格:";
            // 
            // lbCS
            // 
            this.lbCS.AutoSize = true;
            this.lbCS.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbCS.Location = new System.Drawing.Point(380, 20);
            this.lbCS.Name = "lbCS";
            this.lbCS.Size = new System.Drawing.Size(49, 20);
            this.lbCS.TabIndex = 65;
            this.lbCS.Text = "車種";
            this.lbCS.Visible = false;
            // 
            // lbCT
            // 
            this.lbCT.AutoSize = true;
            this.lbCT.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbCT.Location = new System.Drawing.Point(227, 20);
            this.lbCT.Name = "lbCT";
            this.lbCT.Size = new System.Drawing.Size(49, 20);
            this.lbCT.TabIndex = 64;
            this.lbCT.Text = "車款";
            // 
            // lbCB
            // 
            this.lbCB.AutoSize = true;
            this.lbCB.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbCB.Location = new System.Drawing.Point(56, 20);
            this.lbCB.Name = "lbCB";
            this.lbCB.Size = new System.Drawing.Size(49, 20);
            this.lbCB.TabIndex = 63;
            this.lbCB.Text = "廠牌";
            // 
            // tclPage
            // 
            this.tclPage.Controls.Add(this.tpAddCar);
            this.tclPage.Controls.Add(this.tpMyCar);
            this.tclPage.Font = new System.Drawing.Font("新細明體", 12F);
            this.tclPage.Location = new System.Drawing.Point(9, 6);
            this.tclPage.Name = "tclPage";
            this.tclPage.SelectedIndex = 0;
            this.tclPage.Size = new System.Drawing.Size(739, 707);
            this.tclPage.TabIndex = 66;
            // 
            // tpAddCar
            // 
            this.tpAddCar.Controls.Add(this.lbCB);
            this.tpAddCar.Controls.Add(this.lbCS);
            this.tpAddCar.Controls.Add(this.cbxCarBrand);
            this.tpAddCar.Controls.Add(this.lbCT);
            this.tpAddCar.Controls.Add(this.cbxCarType);
            this.tpAddCar.Controls.Add(this.cbxCarStyle);
            this.tpAddCar.Controls.Add(this.tbxPrice);
            this.tpAddCar.Controls.Add(this.dgvData);
            this.tpAddCar.Controls.Add(this.lblPrice);
            this.tpAddCar.Controls.Add(this.btnCarDealerInsert);
            this.tpAddCar.Controls.Add(this.label3);
            this.tpAddCar.Controls.Add(this.tbxLicensePlate);
            this.tpAddCar.Controls.Add(this.label2);
            this.tpAddCar.Controls.Add(this.tbxCarAge);
            this.tpAddCar.Controls.Add(this.lblLicensePlate);
            this.tpAddCar.Controls.Add(this.tbxRegion);
            this.tpAddCar.Font = new System.Drawing.Font("新細明體", 12F);
            this.tpAddCar.Location = new System.Drawing.Point(4, 26);
            this.tpAddCar.Name = "tpAddCar";
            this.tpAddCar.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpAddCar.Size = new System.Drawing.Size(731, 677);
            this.tpAddCar.TabIndex = 0;
            this.tpAddCar.Text = "新增車子";
            this.tpAddCar.UseVisualStyleBackColor = true;
            // 
            // tpMyCar
            // 
            this.tpMyCar.Controls.Add(this.lblR);
            this.tpMyCar.Controls.Add(this.cbxCP);
            this.tpMyCar.Controls.Add(this.btnDelete);
            this.tpMyCar.Controls.Add(this.lbFOFS);
            this.tpMyCar.Controls.Add(this.dgvSelling);
            this.tpMyCar.Location = new System.Drawing.Point(4, 26);
            this.tpMyCar.Name = "tpMyCar";
            this.tpMyCar.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpMyCar.Size = new System.Drawing.Size(731, 677);
            this.tpMyCar.TabIndex = 1;
            this.tpMyCar.Text = "在售車子";
            this.tpMyCar.UseVisualStyleBackColor = true;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("新細明體", 15F);
            this.lblR.Location = new System.Drawing.Point(435, 45);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(89, 20);
            this.lblR.TabIndex = 10;
            this.lblR.Text = "車牌號碼";
            // 
            // cbxCP
            // 
            this.cbxCP.FormattingEnabled = true;
            this.cbxCP.Location = new System.Drawing.Point(439, 82);
            this.cbxCP.Name = "cbxCP";
            this.cbxCP.Size = new System.Drawing.Size(101, 24);
            this.cbxCP.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnDelete.Location = new System.Drawing.Point(565, 77);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 32);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbFOFS
            // 
            this.lbFOFS.AutoSize = true;
            this.lbFOFS.Font = new System.Drawing.Font("新細明體", 15F);
            this.lbFOFS.Location = new System.Drawing.Point(34, 75);
            this.lbFOFS.Name = "lbFOFS";
            this.lbFOFS.Size = new System.Drawing.Size(94, 20);
            this.lbFOFS.TabIndex = 6;
            this.lbFOFS.Text = "賣家編號:";
            // 
            // dgvSelling
            // 
            this.dgvSelling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelling.Location = new System.Drawing.Point(38, 136);
            this.dgvSelling.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSelling.Name = "dgvSelling";
            this.dgvSelling.RowHeadersWidth = 51;
            this.dgvSelling.RowTemplate.Height = 27;
            this.dgvSelling.Size = new System.Drawing.Size(638, 517);
            this.dgvSelling.TabIndex = 3;
            this.dgvSelling.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelling_RowEnter);
            // 
            // frmCarDealerInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 725);
            this.Controls.Add(this.tclPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCarDealerInsert";
            this.Text = "賣車GO";
            this.Load += new System.EventHandler(this.frmCarDealerInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.tclPage.ResumeLayout(false);
            this.tpAddCar.ResumeLayout(false);
            this.tpAddCar.PerformLayout();
            this.tpMyCar.ResumeLayout(false);
            this.tpMyCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.TextBox tbxRegion;
        private System.Windows.Forms.TextBox tbxCarAge;
        private System.Windows.Forms.TextBox tbxLicensePlate;
        private System.Windows.Forms.Button btnCarDealerInsert;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ComboBox cbxCarStyle;
        private System.Windows.Forms.ComboBox cbxCarType;
        private System.Windows.Forms.ComboBox cbxCarBrand;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lbCS;
        private System.Windows.Forms.Label lbCT;
        private System.Windows.Forms.Label lbCB;
        private System.Windows.Forms.TabControl tclPage;
        private System.Windows.Forms.TabPage tpAddCar;
        private System.Windows.Forms.TabPage tpMyCar;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.ComboBox cbxCP;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbFOFS;
        private System.Windows.Forms.DataGridView dgvSelling;
    }
}