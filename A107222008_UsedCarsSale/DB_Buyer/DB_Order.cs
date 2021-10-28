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
    public partial class frmOrder : Form
    {
        private string dbHost = "localhost"; //"localhost";
        private string dbPort = "3306";
        private string dbUser = "root";
        private string dbPassword = ""; 
        private string dbName = "db2020f_usedcarsales"; //"testdb";
        private string sqlStr = "";

        string carBrand;
        string carType;
        string carStyle;
        string licensePlate;
        int carAge;    
        int orderID = 0;
        int recordID = 0;
        DateTime orderDate;
        string buyerID;
        string carDealerID;
        int carPrice;

        string CbuyerID = null;
        string CsellerID = null;
        string carPriceS;

        MySqlConnection conn = null;

        public frmOrder(int _OrderID, string _BuyerID = null , string _SellerID = null)
        {
            InitializeComponent();

            this.CbuyerID = _BuyerID;
            this.CsellerID = _SellerID;

            lbcs.Visible = false;
            lbBuyerID.Visible = false;
            lbSellerID.Visible = false;

            if (CbuyerID != null)
            {

                conn = DBconnection.connectMariaDB(dbUser, dbPassword, dbName);

                sqlStr = "SELECT COUNT(recordID) FROM completeorder";
                MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                object oRID = cmd.ExecuteScalar();
                string sRID = Convert.ToString(oRID);
                int CrecordID = int.Parse(sRID);

                int MrecordID;

                try
                {
                    sqlStr = "SELECT MAX(recordID) FROM completeorder";
                    cmd = new MySqlCommand(sqlStr, conn);
                    object mRID = cmd.ExecuteScalar();
                    string mmRID = Convert.ToString(mRID);
                    MrecordID = int.Parse(mmRID);
                }
                catch (Exception ee) { MrecordID = 0; };

                recordID = Math.Max(CrecordID, MrecordID);

                this.orderID = _OrderID;
                sqlStr = $"SELECT DISTINCT * FROM orderform LEFT JOIN salescar ON orderform.LicensePlate = salescar.LicensePlate WHERE orderform.OrderID = '{orderID}'";
                cmd = new MySqlCommand(sqlStr, conn);
                MySqlDataReader data = cmd.ExecuteReader();

                while (data.Read())
                {
                    orderDate = (DateTime)data["OrderDate"];
                    licensePlate = (string)data["LicensePlate"];
                    buyerID = (string)data["BuyerID"];
                    carDealerID = (string)data["CarDealerID"];
                    carBrand = (string)data["Brand"];
                    carType = (string)data["CarType"];
                    carStyle = (string)data["CarStyle"];
                    carAge = (int)data["CarAge"];
                    carPrice = (int)data["Price"];

                }

                data.Close();

                string oID = Convert.ToString(orderID);
                string sorderDate = orderDate.ToString("yyyy-MM-dd HH:mm:ss");

                lbOrderID.Text = oID;
                lbCDID.Text = carDealerID;
                lbDate.Text = sorderDate;
                lbBrand.Text = carBrand;
                lbCarType.Text = carType;

                if(CbuyerID != null)
                {
                    lbSellerID.Visible = true;
                }

                if (carStyle != "")
                {
                    lbcs.Visible = true;
                    lbCarStyle.Text = carStyle;
                }

                DateTime myDate = DateTime.Now;
                string year = myDate.ToString("yyyy");
                int nowYear = int.Parse(year);
                int ageUse = nowYear - carAge;
                string cAge = Convert.ToString(carAge);
                string uAge = Convert.ToString(ageUse);
                lbCarAge.Text = carAge + " (已使用" + uAge + "年)";

                carPriceS = Convert.ToString(carPrice);
                lbPriceShow.Text = carPriceS;
            }
            else if ( CsellerID != null)
            {
                conn = DBconnection.connectMariaDB(dbUser, dbPassword, dbName);

                sqlStr = "SELECT COUNT(recordID) FROM completeorder";
                MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                object oRID = cmd.ExecuteScalar();
                string sRID = Convert.ToString(oRID);
                int CrecordID = int.Parse(sRID);

                sqlStr = "SELECT MAX(recordID) FROM completeorder";
                cmd = new MySqlCommand(sqlStr, conn);
                object mRID = cmd.ExecuteScalar();
                string mmRID = Convert.ToString(mRID);
                int MrecordID = int.Parse(mmRID);

                recordID = Math.Max(CrecordID, MrecordID);

                this.orderID = _OrderID;
                sqlStr = $"SELECT DISTINCT * FROM orderform LEFT JOIN salescar ON orderform.LicensePlate = salescar.LicensePlate WHERE orderform.OrderID = '{orderID}'";
                cmd = new MySqlCommand(sqlStr, conn);
                MySqlDataReader data = cmd.ExecuteReader();

                while (data.Read())
                {
                    orderDate = (DateTime)data["OrderDate"];
                    licensePlate = (string)data["LicensePlate"];
                    buyerID = (string)data["BuyerID"];
                    carDealerID = (string)data["CarDealerID"];
                    carBrand = (string)data["Brand"];
                    carType = (string)data["CarType"];
                    carStyle = (string)data["CarStyle"];
                    carAge = (int)data["CarAge"];
                    carPrice = (int)data["Price"];

                }

                data.Close();

                string oID = Convert.ToString(orderID);
                string sorderDate = orderDate.ToString("yyyy-MM-dd HH:mm:ss");

                lbOrderID.Text = oID;
                lbCDID.Text = buyerID;
                lbDate.Text = sorderDate;
                lbBrand.Text = carBrand;
                lbCarType.Text = carType;

                if (CsellerID != null)
                {
                    lbBuyerID.Visible = true;
                }

                if (carStyle != "")
                {
                    lbcs.Visible = true;
                    lbCarStyle.Text = carStyle;
                }

                DateTime myDate = DateTime.Now;
                string year = myDate.ToString("yyyy");
                int nowYear = int.Parse(year);
                int ageUse = nowYear - carAge;
                string cAge = Convert.ToString(carAge);
                string uAge = Convert.ToString(ageUse);
                lbCarAge.Text = carAge + " (已使用" + uAge + "年)";

                carPriceS = Convert.ToString(carPrice);
                lbPriceShow.Text = carPriceS;
            }

        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            //conn = DBconnection.connectMariaDB(dbUser, dbPassword, dbName);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (CbuyerID != null)
            {
                if (tbxCreditRating.Text != "")
                {
                    recordID += 1;
                    DateTime mDate = DateTime.Now;
                    string recordDate = mDate.ToString("yyyy-MM-dd");

                    sqlStr = $"INSERT INTO completeorder (RecordID, RecordDate, OrderID, CDCreditRating) Values ('{recordID}', '{recordDate}', '{orderID}', {tbxCreditRating.Text})";
                    MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("完成購買!");

                    //sqlStr = $"DELETE FROM salescar WHERE LicensePlate = '{licensePlate}'";
                    sqlStr = $"update `salescar` set `isSale`= NOT `isSale` where salescar.LicensePlate = '{licensePlate}'";
                    cmd = new MySqlCommand(sqlStr, conn);
                    cmd.ExecuteNonQuery();
                    //記得開                   

                    this.Close();
                }
                else
                {
                    MessageBox.Show("請輸入評分(1~100分)!");
                }

            }
            else if (CsellerID != null)
            {
                if (tbxCreditRating.Text != "")
                {
                    recordID += 1;
                    DateTime mDate = DateTime.Now;
                    string recordDate = mDate.ToString("yyyy-MM-dd");

                    sqlStr = $"INSERT INTO completeorder (RecordID, RecordDate, OrderID, BuyerCreditRating) Values ('{recordID}', '{recordDate}', '{orderID}', {tbxCreditRating.Text})";
                    MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("完成購買!");

                    //sqlStr = $"DELETE FROM salescar WHERE LicensePlate = '{licensePlate}'";
                    sqlStr = $"update `salescar` set `isSale`= NOT `isSale` where salescar.LicensePlate = '{licensePlate}'";
                    cmd = new MySqlCommand(sqlStr, conn);
                    cmd.ExecuteNonQuery();

                    

                    //記得開

                    this.Close();
                }
                else
                {
                    MessageBox.Show("請輸入評分(1~100分)!");
                }

            }        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            sqlStr = $"DELETE FROM orderform WHERE OrderID = {orderID}";
            MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
            cmd.ExecuteNonQuery();

            this.Close();
        }

        private void lbOrderID_Click(object sender, EventArgs e)
        {

        }

        private void lbCDID_Click(object sender, EventArgs e)
        {

        }

        private void btnLater_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
