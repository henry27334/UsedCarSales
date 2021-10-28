using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Library;
using MySql.Data.MySqlClient;

namespace A107222008_UsedCar
{
    public partial class frmSCarTransaction : Form
    {
        private string dbHost = "localhost";
        private string dbPort = "3306";
        private string dbUser = "root";
        private string dbPassword = "";
        private string dbName = "db2020f_usedcarsales";
        MySqlDataAdapter mySqlDataAdapter;
        DataSet ds;
        private string connStr = "protocol=tcp;pooling=false;Sslmode=none;charset=utf8;";
        MySqlConnection conn = null;
        MySqlCommand cmd;

        string sqlStr = null;
        string SellerID = null;
        int sellerFinishID = 0;
        int sellerOrderID = 0;
        string getValue = null;

        private void showOneTable()
        {
            //sqlStr = $"SELECT orderform.OrderID AS '訂單編號', orderform.OrderDate AS '訂單日期', orderform.LicensePlate AS '車牌', orderform.BuyerID AS '買家編號' FROM orderform WHERE orderform.CarDealerID = '{SellerID}' AND orderform.OrderID NOT IN (SELECT record.OrderID FROM record)";
            sqlStr = $" SELECT orderform.OrderID AS '訂單編號',salescar.Brand AS '廠牌',salescar.CarType AS '車款',salescar.CarStyle AS '車種',salescar.CarAge AS '車齡' , orderform.OrderDate AS '訂單日期', orderform.LicensePlate AS '車牌', orderform.CarDealerID AS '賣家編號' FROM orderform LEFT JOIN salescar ON orderform.LicensePlate = salescar.LicensePlate WHERE orderform.CarDealerID = '47826' AND orderform.OrderID NOT IN(SELECT completeorder.OrderID FROM completeorder)";
            mySqlDataAdapter = new MySqlDataAdapter(sqlStr, conn);
            ds = new DataSet();
            mySqlDataAdapter.Fill(ds);
            dgvMyOF.DataSource = ds.Tables[0];

        }

        private void showTwoTable()
        {
            //sqlStr = $"SELECT record.RecordID AS '紀錄編號', record.RecordDate AS '紀錄日期', orderform.BuyerID AS '買家編號', record.BuyerCreditRating AS '買家評價' FROM record LEFT JOIN orderform ON record.OrderID = orderform.OrderID WHERE orderform.CarDealerID = '{SellerID}'";
            sqlStr = $"SELECT completeorder.RecordID AS '紀錄編號',salescar.Brand AS '廠牌',salescar.CarType AS '車款',salescar.CarStyle AS '車種',salescar.CarAge AS '車齡', completeorder.RecordDate AS '紀錄日期', orderform.BuyerID AS '買家編號', completeorder.BuyerCreditRating AS '買家評價' FROM((completeorder LEFT JOIN orderform ON completeorder.OrderID = orderform.OrderID) LEFT JOIN salescar ON orderform.LicensePlate = salescar.LicensePlate) WHERE orderform.CarDealerID = '{SellerID}'";
            mySqlDataAdapter = new MySqlDataAdapter(sqlStr, conn);
            ds = new DataSet();
            mySqlDataAdapter.Fill(ds);
            dgvFOF.DataSource = ds.Tables[0];
        }

        public void updateCbx()
        {
            cbxRI.Items.Clear();
            cbxOrderID.Items.Clear();

            sqlStr = $"SELECT completeorder.RecordID FROM completeorder LEFT JOIN orderform ON completeorder.OrderID = orderform.OrderID WHERE orderform.CarDealerID = '{SellerID}'";
            cmd = new MySqlCommand(sqlStr, conn);
            MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                sellerFinishID = (int)data["RecordID"];
                cbxRI.Items.Add(sellerFinishID);
            }
            data.Close();

            sqlStr = $"SELECT orderform.OrderID FROM orderform WHERE orderform.CarDealerID = '{SellerID}' AND orderform.OrderID NOT IN (SELECT completeorder.OrderID FROM completeorder)";
            cmd = new MySqlCommand(sqlStr, conn);
            data = cmd.ExecuteReader();

            while (data.Read())
            {
                sellerOrderID = (int)data["OrderID"];
                cbxOrderID.Items.Add(sellerOrderID);
            }
            data.Close();

        }

        public frmSCarTransaction(string _SellerID = "47826")
        {
            InitializeComponent();
            this.SellerID = _SellerID;
        }

        private void frmCarTransaction_Load(object sender, EventArgs e)
        {
            conn = DBconnection.connectMariaDB(dbUser, dbPassword, dbName);

            sqlStr = $"SELECT Name FROM cardealer WHERE carDealerID = '{SellerID}'";
            MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
            object oRID = cmd.ExecuteScalar();
            string sRID = Convert.ToString(oRID);
            string Name = sRID;

            lbMyID.Text += " " + Name;
            lbFOFS.Text += " " + Name;

            this.dgvMyOF.AllowUserToAddRows = false;
            this.dgvMyOF.AllowUserToDeleteRows = false;
            this.dgvMyOF.ReadOnly = true;
            this.dgvFOF.AllowUserToAddRows = false;
            this.dgvFOF.AllowUserToDeleteRows = false;
            this.dgvFOF.ReadOnly = true;
            cbxRI.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxOrderID.DropDownStyle = ComboBoxStyle.DropDownList;


            updateCbx();
            showOneTable();
            showTwoTable();
        }

        private void btnGiveCR_Click(object sender, EventArgs e)
        {
            if(cbxRI.Text == "")
            {
                MessageBox.Show("無選擇紀錄。");
                return;
            }

            sqlStr = $"SELECT RecordDate FROM completeorder WHERE RecordID = '{cbxRI.Text}'";
            cmd = new MySqlCommand(sqlStr, conn);
            object oRD = cmd.ExecuteScalar();

            DateTime RecordDate = (DateTime)oRD;
            RecordDate = RecordDate.AddDays(7);
            DateTime nDate = DateTime.Now;
            int result = DateTime.Compare(RecordDate, nDate);

            if (result < 0)
            {
                MessageBox.Show("已超過七天可修改評價的時限。");
            }
            else
            {
                int CRnumber = 0;
                try
                {
                    if (tbxCR.Text != "")
                    {
                        CRnumber = int.Parse(tbxCR.Text);
                        if (CRnumber < 0 || CRnumber > 100)
                        {
                            MessageBox.Show("數字過大 請輸入1~100之間");
                            tbxCR.Text = "";
                        }
                        else
                        {
                            sqlStr = $"UPDATE completeorder SET BuyerCreditRating = {tbxCR.Text} WHERE completeorder.RecordID = '{cbxRI.Text}'";
                            cmd = new MySqlCommand(sqlStr, conn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("評價完成");

                            updateCbx();
                            showTwoTable();
                        }
                    }
                    else
                    {
                        MessageBox.Show("請輸入評價 (1~100分)");
                    }
                }
                catch (Exception ee) { }
            }        
        }//

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (cbxOrderID.Text != "")
            {
                int orderID = 0;

                if (cbxOrderID.Text != "")
                {
                    orderID = int.Parse(cbxOrderID.Text);
                }

                frmOrder ff = new frmOrder(orderID, null, SellerID);
                ff.ShowDialog();

                updateCbx();
                showOneTable();
                showTwoTable();

            }
            else
            {
                MessageBox.Show("無選擇訂單。");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cbxOrderID.Text != "")
            {
                string caption = "訂單確認";
                var doubleCheck = MessageBox.Show("確定刪除此訂單?", caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (doubleCheck == DialogResult.Yes)
                {
                    sqlStr = $"DELETE FROM orderform WHERE OrderID = {cbxOrderID.Text}";
                    cmd = new MySqlCommand(sqlStr, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("已刪除訂單");
                }
            }
            else
            {
                MessageBox.Show("無選擇訂單。");
            }

            updateCbx();
            showOneTable();
        }

        private void dgvMyOF_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            getValue = dgvMyOF.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbxOrderID.Text = getValue;
        }

        private void dgvFOF_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            getValue = dgvFOF.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbxRI.Text = getValue;
        }

        private void tbxCR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
