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
    public partial class frmSCreditRating : Form
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

        string sqlStr = null;
        string SellerID = null;
        string buyerID;

        public frmSCreditRating(string _SellerID)
        {
            InitializeComponent();
            this.SellerID = _SellerID;
        }

        private void updateCbx()
        {

            cbxbuyerID.Items.Clear();

            sqlStr = $"SELECT buyerID FROM buyer";
            MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
            MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {

                buyerID = (string)data["buyerID"];
                cbxbuyerID.Items.Add(buyerID);
            }
            data.Close();
        }

        private void frmSCreditRating_Load(object sender, EventArgs e)
        {
            cbxbuyerID.DropDownStyle = ComboBoxStyle.DropDownList;
            tclPage.SelectedIndex = 0;
            lblSCR.Visible = false;
            lbTCR.Visible = false;

            conn = DBconnection.connectMariaDB(dbHost, dbPort, dbUser, dbPassword, dbName);

            sqlStr = $"SELECT Name FROM cardealer WHERE CarDealerID = '{SellerID}'";
            MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
            object oRID = cmd.ExecuteScalar();
            string sRID = Convert.ToString(oRID);
            string Name = sRID;

            lbMyID.Text += " " + Name;

            string connStr = $"server={dbHost};port={dbPort};uid={dbUser};pwd={dbPassword};database={dbName}";
            conn = DBconnection.connectMariaDB(dbHost, dbPort, dbUser, dbPassword, dbName);
            updateCbx();
            int CRaverage = 0, i = 0;
            sqlStr = $"SELECT completeorder.CDCreditRating FROM completeorder LEFT JOIN orderform ON completeorder.OrderID = orderform.OrderID WHERE orderform.CarDealerID = '{SellerID}'";
            cmd = new MySqlCommand(sqlStr, conn);
            MySqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                i++;
                CRaverage += (int)data["CDCreditRating"];
            }
            

            data.Close();

            try
            {
                CRaverage /= i;
                lbTCR.Visible = true;
                lbTCR.Text += " " + CRaverage + "分";
            }
            catch (Exception ee) { }


            
            //sqlStr = $"SELECT record.RecordID AS '完成編號', record.RecordDate AS '完成時間', orderform.CarDealerID AS '賣家編號', record.CDCreditRating AS '賣家評價' FROM record LEFT JOIN orderform ON record.OrderID = orderform.OrderID WHERE orderform.CarDealerID = '{SellerID}'";
            sqlStr = $"SELECT completeorder.RecordID AS '完成編號', salescar.Brand AS '廠牌',salescar.CarType AS '車型',salescar.CarStyle AS '車種',salescar.CarAge AS '車齡',completeorder.RecordDate AS '完成時間', orderform.CarDealerID AS '賣家編號', completeorder.CDCreditRating AS '賣家評價' FROM((completeorder LEFT JOIN orderform ON completeorder.OrderID = orderform.OrderID) LEFT JOIN salescar ON orderform.LicensePlate = salescar.LicensePlate) WHERE orderform.CarDealerID = '{SellerID}'";

            mySqlDataAdapter = new MySqlDataAdapter(sqlStr, conn);
            ds = new DataSet();
            mySqlDataAdapter.Fill(ds);
            dgvMyCR.DataSource = ds.Tables[0];

            this.dgvMyCR.AllowUserToAddRows = false;
            this.dgvMyCR.AllowUserToDeleteRows = false;
            this.dgvMyCR.ReadOnly = true;

            this.dgvCreditRating.AllowUserToAddRows = false;
            this.dgvCreditRating.AllowUserToDeleteRows = false;
            this.dgvCreditRating.ReadOnly = true;

        }

        private void tpMyCR_Click(object sender, EventArgs e)
        {

        }

        private void btnCreditRating_Click(object sender, EventArgs e)
        {
            lblSCR.Text = "總評分: ";
            lblSCR.Visible = false;
            MySqlConnection conn = DBconnection.connectMariaDB(dbHost, dbPort, dbUser, dbPassword, dbName);
            MySqlCommand cmd = new MySqlCommand(sqlStr, conn);

            int CRaverage = 0, i = 0;
            sqlStr = $"SELECT completeorder.BuyerCreditRating FROM completeorder LEFT JOIN orderform ON completeorder.OrderID = orderform.OrderID WHERE orderform.BuyerID = '{cbxbuyerID.Text}'";
            cmd = new MySqlCommand(sqlStr, conn);

            MySqlDataReader data = cmd.ExecuteReader();
            while (data.Read())
            {
                i++;
                //CRaverage = 0;
                CRaverage += (int)data["BuyerCreditRating"];
            }
            data.Close();

            try
            {
                if (i >= 1)
                {
                    CRaverage /= i;
                    lblSCR.Visible = true;
                    lblSCR.Text += " " + CRaverage + "分";
                }
            }
            catch (Exception ee) { }

            //string connStr = $"server={dbHost};port={dbPort};uid={dbUser};pwd={dbPassword};database={dbName}";
            //sqlStr = $"SELECT orderform.CarDealerID AS '賣家編號',record.RecordDate AS '完成紀錄', record.CDCreditRating AS '賣家評價' FROM orderform  LEFT JOIN record ON orderform.OrderID = record.OrderID WHERE orderForm.CarDealerID LIKE '{tbxCreditRating.Text}%'";

            //sqlStr = $"SELECT orderform.BuyerID AS '買家編號',record.RecordDate AS '完成紀錄', record.BuyerCreditRating AS '買家評價' FROM orderform, record WHERE orderform.OrderID = record.OrderID AND orderForm.BuyerID = '{tbxCreditRating.Text}'";
            sqlStr = $"SELECT orderform.CarDealerID AS '買家編號',salescar.Brand AS '廠牌' ,salescar.CarType AS '車型' , salescar.CarStyle AS '車種' ,salescar.CarAge AS '車齡',completeorder.RecordDate AS '完成紀錄', completeorder.CDCreditRating AS '買家評價'  FROM((completeorder LEFT JOIN orderform ON completeorder.OrderID = orderform.OrderID) LEFT JOIN salescar ON orderform.LicensePlate = salescar.LicensePlate) WHERE orderform.BuyerID = '{cbxbuyerID.Text}'";
            cmd = new MySqlCommand(sqlStr, conn);
            mySqlDataAdapter = new MySqlDataAdapter(sqlStr, conn);
            ds = new DataSet();
            mySqlDataAdapter.Fill(ds);
            dgvCreditRating.DataSource = ds.Tables[0];

        }

        private void dgvMyCR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
