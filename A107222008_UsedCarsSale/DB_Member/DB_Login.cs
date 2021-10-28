using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Library;
using MySql.Data.MySqlClient;

namespace A107222008_UsedCar
{
    public partial class frmLogin : Form
    {
        private string dbHost = "localhost";
        private string dbPort = "3306";
        private string dbUser = "root";
        private string dbPassword = "";
        private string dbName = "db2020f_usedcarsales";
        private string connStr = "protocol=tcp;pooling=false;Sslmode=none;charset=utf8;";
        public static int ID;
        public string buyerID = null;
        public string sellerID = null;

        public void getIDfromLogin(out string _buyerID, out string _sellerID)
        {
            _buyerID = buyerID;
            _sellerID = sellerID;
        }

        public frmLogin()
        {
            InitializeComponent();
            cbxChoice.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cbxChoice.Text == "買家")
            {
                string connStr = $"server={dbHost};port={dbPort};uid={dbUser};pwd={dbPassword};database={dbName}";
                MySqlConnection conn = DBconnection.connectMariaDB(dbHost, dbPort, dbUser, dbPassword, dbName);
                string Account = tbxId.Text; //帳號
                string Password = tbxPassword.Text; //密碼
                string sqlStr = "select * from `buyer` where BuyerID in ('" + Account + "') and password in ('" + Password + "')";

                MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd); //data偵測            
                DataSet da = new DataSet(); //dataset
                adp.Fill(da, "info"); //資料存入dataset
                DataTable table = da.Tables["info"]; //資料存入datatble
                if (table.Rows.Count >= 1)
                {
                    buyerID = Account; //全域變數紀錄使用者帳號
                                             //建立一個執行序
                    Thread thread = new Thread(new ThreadStart(delegate ()
                    {
                        MessageBox.Show("登入成功");
                    }));
                    thread.Start();
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("帳號或密碼錯誤");
                }
            }
            else if (cbxChoice.Text == "賣家")
            {
                string connStr = $"server={dbHost};port={dbPort};uid={dbUser};pwd={dbPassword};database={dbName}";
                MySqlConnection conn = DBconnection.connectMariaDB(dbHost, dbPort, dbUser, dbPassword, dbName);
                string Account = tbxId.Text; //帳號
                string Password = tbxPassword.Text; //密碼
                string sqlStr = "select * from `cardealer` where CardealerID in ('" + Account + "') and password in ('" + Password + "')";

                MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd); //data偵測            
                DataSet da = new DataSet(); //dataset
                adp.Fill(da, "info"); //資料存入dataset
                DataTable table = da.Tables["info"]; //資料存入datatble
                if (table.Rows.Count >= 1)
                {
                    sellerID = Account; //全域變數紀錄使用者帳號
                                             //建立一個執行序
                    Thread thread = new Thread(new ThreadStart(delegate ()
                    {
                        MessageBox.Show("登入成功");
                    }));
                    thread.Start();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("帳號或密碼錯誤");
                }
            }


            //MessageBox.Show(buyerID + " " + sellerID);         
            //frmDBTest ff = new frmDBTest();
            //ff.getIDfromLogin(buyerID, sellerID);
            //ff.Show();
            //ff.Refresh();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }//end of class
}//end of namespace
