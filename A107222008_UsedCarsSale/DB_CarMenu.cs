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
    public partial class frmCarMenu : Form
    {
        private string dbHost = "localhost"; //"localhost";
        private string dbPort = "3306";
        private string dbUser = "root";
        private string dbPassword = ""; //"";
        private string dbName = "db2020f_usedcarsales"; //"testdb";
        private string sqlStr = "";

        int OrderID = 0;
        string BuyerID = null;
        string SellerID = null;
        
        MySqlConnection conn = null;
        MySqlDataAdapter mySqlDataAdapter;
        DataSet ds;

        void getTable()
        {
            string sqlStr = $"SELECT TABLE_NAME FROM INFORMATION_SCHENA.TABLES WHERE TABLE_TYPE = \'BASE TABLE\' AND TABLE_SCHEMA = \'{dbName}\'";
            MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
            MySqlDataReader rr = cmd.ExecuteReader();
            //lbxTables.Items.Clear();
            //while (rr.Read()) { lbxTables.Items.Add(rr.GetString(0)); }
            rr.Close();
        }

        void showTable(MySqlConnection conn)
        {
            if (conn != null)
            {
                //DBmanipulation.getDBtables(conn, dbName, lbxTables);
                DBmanipulation.getDBtables(conn, dbName, cbxCarBrand);
                if (cbxCarBrand.Items.Count > 0) { cbxCarBrand.SelectedIndex = 0; }
                //if (lbxTables.Items.Count > 0) { lbxTables.SelectedIndex = 0; }
            }
            else { MessageBox.Show("Connection fail!!"); }
        }

        void showOringalTable()
        {
            string sqlStr = "", selectedType;
            selectedType = cbxCarBrand.GetItemText(this.cbxCarBrand.SelectedItem);

            sqlStr = $"SELECT salescar.Brand AS '廠牌', salescar.CarType AS '車款', salescar.CarStyle AS '車種', carresource.CarModel AS '車型', carresource.CarDoor AS '車門數', carresource.Passenger AS '乘客數', carresource.CableControlSystem AS '變速系統', carresource.EngineDisplacement AS '排氣量', carresource.CarColor AS '車色',salescar.CarAge AS '車齡',salescar.Region AS '地區', salescar.CarDealerID AS '賣家編號',salescar.Price AS '價格' FROM salescar LEFT JOIN carresource On salescar.Brand = carresource.Brand AND salescar.CarType = carresource.CarType AND salescar.CarStyle = carresource.CarStyle WHERE salescar.isSale = 0";
            
            mySqlDataAdapter = new MySqlDataAdapter(sqlStr, conn);
            ds = new DataSet();
            mySqlDataAdapter.Fill(ds);
            dgvData.DataSource = ds.Tables[0];

            addButtonIntoDGV();
        }

        #region showPriceRangeTabl(no use)
        //void showPriceRangeTable(Object sender, int minPrice = 0, int maxPrice = int.MaxValue)
        //{
        //    if (minPrice > maxPrice)
        //    {
        //        MessageBox.Show("最低價格不可高於最高價格!");
        //        nudMinPrice.Value = 0;
        //        nudMaxPrice.Value = 0;
        //    }

        //    string sqlStr = "", selectedType;
        //    selectedType = cbxCarBrand.GetItemText(this.cbxCarBrand.SelectedItem);
        //    //sqlStr = $"SELECT salescar.Brand AS '廠牌', salescar.CarType AS '車款', salescar.CarStyle AS '車種', carresource.CarModel AS '車型', carresource.CarDoor AS '車門數', carresource.Passenger AS '乘客數', carresource.CableControlSystem AS '變速系統', carresource.EngineDisplacement AS '排氣量', carresource.CarColor AS '車色',salescar.CarAge AS '車齡',salescar.Region AS '地區', salescar.CarDealerID AS '賣家編號', salescar.Price AS '價格' FROM salescar LEFT JOIN carresource On salescar.Brand = carresource.Brand AND salescar.CarType = carresource.CarType AND salescar.CarStyle = carresource.CarStyle WHERE salescar.{column} = '{text}'";
        //    sqlStr = $"SELECT salescar.Brand AS '廠牌', salescar.CarType AS '車款', salescar.CarStyle AS '車種', carresource.CarModel AS '車型', carresource.CarDoor AS '車門數', carresource.Passenger AS '乘客數', carresource.CableControlSystem AS '變速系統', carresource.EngineDisplacement AS '排氣量', carresource.CarColor AS '車色',salescar.CarAge AS '車齡',salescar.Region AS '地區', salescar.CarDealerID AS '賣家編號', salescar.Price AS '價格' FROM salescar LEFT JOIN carresource On salescar.Brand = carresource.Brand AND salescar.CarType = carresource.CarType AND salescar.CarStyle = carresource.CarStyle WHERE salescar.Price BETWEEN {minPrice} AND {maxPrice}";
        //    mySqlDataAdapter = new MySqlDataAdapter(sqlStr, conn);
        //    ds = new DataSet();
        //    mySqlDataAdapter.Fill(ds);
        //    dgvData.DataSource = ds.Tables[0];

        //    addButtonIntoDGV();

        //    //MaxPrice = int.MaxValue;
        //    //MinPrice = int.MinValue;
        //    //nudMinPrice.Value = 0;
        //    //nudMaxPrice.Value = 0;
        //}
        #endregion

        void showTable(Object sender, string column, string text, int minPrice = 0, int maxPrice = int.MaxValue)
        {
            if(minPrice > maxPrice)
            {
                MessageBox.Show("最低價格不可高於最高價格!");
                nudMinPrice.Value = 0;
                nudMaxPrice.Value = 0;
            }

            string sqlStr = "" , selectedType;
            selectedType = cbxCarBrand.GetItemText(this.cbxCarBrand.SelectedItem);
            sqlStr = $"SELECT salescar.Brand AS '廠牌', salescar.CarType AS '車款', salescar.CarStyle AS '車種', carresource.CarModel AS '車型', carresource.CarDoor AS '車門數', carresource.Passenger AS '乘客數', carresource.CableControlSystem AS '變速系統', carresource.EngineDisplacement AS '排氣量', carresource.CarColor AS '車色',salescar.CarAge AS '車齡',salescar.Region AS '地區', salescar.CarDealerID AS '賣家編號', salescar.Price AS '價格' FROM salescar LEFT JOIN carresource On salescar.Brand = carresource.Brand AND salescar.CarType = carresource.CarType AND salescar.CarStyle = carresource.CarStyle WHERE salescar.isSale = 0 AND salescar.{column} = '{text}'";
            //sqlStr = $"SELECT salescar.Brand AS '廠牌', salescar.CarType AS '車款', salescar.CarStyle AS '車種', carresource.CarModel AS '車型', carresource.CarDoor AS '車門數', carresource.Passenger AS '乘客數', carresource.CableControlSystem AS '變速系統', carresource.EngineDisplacement AS '排氣量', carresource.CarColor AS '車色',salescar.CarAge AS '車齡',salescar.Region AS '地區', salescar.CarDealerID AS '賣家編號', carDealer.Name AS '商家名稱' ,salescar.Price AS '價格' FROM((salescar LEFT JOIN carresource ON salescar.Brand = carresource.Brand AND salescar.CarType = carresource.CarType AND salescar.CarStyle = carresource.CarStyle) LEFT JOIN cardealer ON salescar.Brand = carresource.Brand AND salescar.CarType = carresource.CarType AND salescar.CarStyle = carresource.CarStyle ) WHERE salescar.isSale = 0";
            
            mySqlDataAdapter = new MySqlDataAdapter(sqlStr, conn);
            ds = new DataSet();
            mySqlDataAdapter.Fill(ds);
            dgvData.DataSource = ds.Tables[0];

            addButtonIntoDGV();

            nudMinPrice.Value = 0;
            nudMaxPrice.Value = 0;
        }

        private void addButtonIntoDGV()
        {

            DataGridViewButtonColumn buyItDbc = new DataGridViewButtonColumn();
            buyItDbc.Name = "購買";
            buyItDbc.Text = "買車Go";
            buyItDbc.UseColumnTextForButtonValue = true;
            int rowIndex = dgvData.ColumnCount;
            //int rowIndex = ds.Tables[0].Columns.Count;
            if (dgvData.Columns["購買"] == null)
            {
                dgvData.Columns.Insert(rowIndex, buyItDbc);
            }
        }

        private void buttonVisible()
        {
            btnBuyerCR.Visible = false;
            btnSellerSC.Visible = false;
            btnLogout.Visible = false;
            btnSellerCR.Visible = false;
            lbCS.Visible = false;

            btnLogin.Visible = true;
            btnSignUp.Visible = true;
            btnSCarOrder.Visible = false;
            btnBCarOrder.Visible = false;
        }

        private void dataGridViewSoftware_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (BuyerID != null)
            {
                if (e.ColumnIndex == dgvData.Columns["購買"].Index)
                {
        
                    string carBrand = "";
                    string carType = "";
                    string carStyle = "";
                    int carAge = 0;
                    string carDealerID = "";           
                    
                    try
                    {
                        string test = (string)dgvData.Rows[e.RowIndex].Cells[0].Value;
                       // MessageBox.Show(test);

                        if (test == "買車Go")
                        {
                            carBrand = (string)dgvData.Rows[e.RowIndex].Cells[1].Value;
                            carType = (string)dgvData.Rows[e.RowIndex].Cells[2].Value;
                            carStyle = (string)dgvData.Rows[e.RowIndex].Cells[3].Value;
                            carAge = (int)dgvData.Rows[e.RowIndex].Cells[10].Value;
                            carDealerID = (string)dgvData.Rows[e.RowIndex].Cells[12].Value;
                        }
                        else
                        {
                            carBrand = (string)dgvData.Rows[e.RowIndex].Cells[0].Value;
                            carType = (string)dgvData.Rows[e.RowIndex].Cells[1].Value;
                            carStyle = (string)dgvData.Rows[e.RowIndex].Cells[2].Value;
                            carAge = (int)dgvData.Rows[e.RowIndex].Cells[9].Value;
                            carDealerID = (string)dgvData.Rows[e.RowIndex].Cells[11].Value;
                        }                    
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.ToString());
                    }

                    DateTime myDate = DateTime.Now;
                    string year = myDate.ToString("yyyy");
                    int nowYear = int.Parse(year);
                    int ageUse = nowYear - carAge;

                    sqlStr = $"SELECT LicensePlate FROM salescar WHERE Brand = '{carBrand}' AND CarType = '{carType}' AND CarStyle = '{carStyle}' AND CarDealerID = '{carDealerID}'";
                    MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                    string LicensePlate = (string)cmd.ExecuteScalar();


                    sqlStr = "SELECT COUNT(OrderID) FROM orderform";
                    cmd = new MySqlCommand(sqlStr, conn);
                    object oOID = cmd.ExecuteScalar();
                    string sOID = Convert.ToString(oOID);
                    int OrderID = int.Parse(sOID);

                    int mOrderID;
                    try
                    {
                        sqlStr = "SELECT MAX(OrderID) FROM orderform";
                        cmd = new MySqlCommand(sqlStr, conn);
                        object mOID = cmd.ExecuteScalar();
                        string mmOID = Convert.ToString(mOID);
                        //MessageBox.Show(mmOID);
                        mOrderID = int.Parse(mmOID);

                    }catch(Exception ee) { mOrderID = 0; };

                    string caption = "訂單確認";
                    string carDetails = $"{carBrand} {carType} {carStyle} 已使用{ageUse}年 ";
                    var doubleCheck = MessageBox.Show("確認車子詳情: \n " + carDetails, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //MessageBox.Show(OrderID + "/" + mOrderID);

                    if (doubleCheck == DialogResult.Yes)
                    {
                        OrderID = Math.Max(OrderID, mOrderID);

                        OrderID += 1;
                        DateTime mDate = DateTime.Now;
                        string orderDate = mDate.ToString("yyyy-MM-dd HH:mm:ss");

                        sqlStr = $"INSERT INTO orderform (OrderID, OrderDate, LicensePlate, BuyerID, CarDealerID) Values ('{OrderID}', '{orderDate}', '{LicensePlate}', '{BuyerID}', '{carDealerID}')";
                        cmd = new MySqlCommand(sqlStr, conn);
                        cmd.ExecuteNonQuery();

                        frmOrder ff = new frmOrder(OrderID, _BuyerID:BuyerID);
                        ff.ShowDialog();

                        showOringalTable();
                    }
                }
            }
            else
            {
                if(SellerID != null)
                {
                    MessageBox.Show("目前身分為賣家!");
                }
                else
                {
                    MessageBox.Show("請先登入會員!");
                }
                
            }
        }

        public frmCarMenu()
        {
            InitializeComponent();
            InitialOperation();

        }

        void InitialOperation()
        {
            cbxCarBrand.Items.Clear();
            cbxCarType.Items.Clear();
            cbxCarStyle.Items.Clear();
            
            this.BackgroundImage = new Bitmap(Application.StartupPath + "\\Pics\\Cars.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            lbEC.BackColor = Color.Transparent;
            lbCT.BackColor = Color.Transparent;
            lbCS.BackColor = Color.Transparent;
            lbCB.BackColor = Color.Transparent;
            lbPrice.BackColor = Color.Transparent;
            lbbbb.BackColor = Color.Transparent;
            lblDoor.BackColor = Color.Transparent;
            lbPassenger.BackColor = Color.Transparent;
            lbCarAge.BackColor = Color.Transparent;

            nudMinPrice.Minimum = 0;
            nudMaxPrice.Minimum = 0;
            nudMinPrice.Maximum = int.MaxValue;
            nudMaxPrice.Maximum = int.MaxValue;

            conn = DBconnection.connectMariaDB(dbUser, dbPassword, dbName);

            showOringalTable();
            dgvData.CellClick += dataGridViewSoftware_CellClick;

            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ReadOnly = true;
            buttonVisible();
           
            cbxCarBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCarType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCarStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCarDoor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPassenger.DropDownStyle = ComboBoxStyle.DropDownList;

            #region //cbx add
            cbxCarBrand.Items.Add("Mercedes");
            cbxCarBrand.Items.Add("BMW");
            cbxCarBrand.Items.Add("Toyota");
            cbxCarBrand.Items.Add("Mitsubishi");
            cbxCarBrand.Items.Add("Honda");
            cbxCarBrand.Items.Add("Mazda");
            cbxCarBrand.Items.Add("Ford");
            cbxCarBrand.Items.Add("Audi");
            cbxCarBrand.Items.Add("Hyundai");
            cbxCarBrand.Items.Add("Lamborghini");
            cbxCarBrand.Items.Add("Lexus");
            cbxCarBrand.Items.Add("Nissan");
            cbxCarBrand.Items.Add("Volkswagen");
            cbxCarBrand.Items.Add("Volvo");

            cbxCarDoor.Items.Add("2");
            cbxCarDoor.Items.Add("4");
            cbxCarDoor.Items.Add("5");
            cbxCarDoor.Items.Add("6");

            cbxPassenger.Items.Add("2");
            cbxPassenger.Items.Add("3");
            cbxPassenger.Items.Add("4");
            cbxPassenger.Items.Add("5");
            cbxPassenger.Items.Add("6");
            cbxPassenger.Items.Add("7");
            cbxPassenger.Items.Add("8");
            cbxPassenger.Items.Add("9");
            #endregion
        }

        private void frmDBTest_Load(object sender, EventArgs e)
        {
            //conn = DBconnection.connectMariaDB(dbUser, dbPassword, dbName);
            //showOringalTable(sender);
        }

        private void cbxCarBrand_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbxCarType.Items.Clear();

            if (cbxCarBrand.SelectedIndex != 0 && cbxCarBrand.SelectedIndex != 1)
            {
                cbxCarStyle.Visible = false;
                lbCS.Visible = false;
            }
            else {

                cbxCarStyle.Visible = true;
                lbCS.Visible = true;
            }

            #region //switch 
            switch (cbxCarBrand.SelectedIndex)
            {
                case 0: //Mercedes-Benz
                    cbxCarType.Items.Add("A");
                    //cbxCarType.Items.Add("AMG GT");
                    cbxCarType.Items.Add("AMGGT");
                    cbxCarType.Items.Add("B");
                    cbxCarType.Items.Add("C");
                    cbxCarType.Items.Add("CITAN");
                    cbxCarType.Items.Add("CL");
                    cbxCarType.Items.Add("CLA");
                    cbxCarType.Items.Add("CLK");
                    cbxCarType.Items.Add("CLS");
                    cbxCarType.Items.Add("E");
                    cbxCarType.Items.Add("G");
                    cbxCarType.Items.Add("GL");
                    cbxCarType.Items.Add("GLA");
                    cbxCarType.Items.Add("GLB");
                    cbxCarType.Items.Add("GLC");
                    cbxCarType.Items.Add("GLE");
                    cbxCarType.Items.Add("GLK");
                    cbxCarType.Items.Add("GLS");
                    cbxCarType.Items.Add("Metris");
                    cbxCarType.Items.Add("ML");
                    cbxCarType.Items.Add("R");
                    cbxCarType.Items.Add("S");
                    cbxCarType.Items.Add("SL");
                    cbxCarType.Items.Add("SLC");
                    cbxCarType.Items.Add("SLK");
                    cbxCarType.Items.Add("SLR");
                    cbxCarType.Items.Add("SLS");
                    cbxCarType.Items.Add("V");
                    cbxCarType.Items.Add("W123");
                    cbxCarType.Items.Add("W201");
                    cbxCarType.Items.Add("X");
                    break;

                case 1: //BMW
                    cbxCarType.Items.Add("1");
                    cbxCarType.Items.Add("2");
                    cbxCarType.Items.Add("3");
                    cbxCarType.Items.Add("4");
                    cbxCarType.Items.Add("5");
                    cbxCarType.Items.Add("6");
                    cbxCarType.Items.Add("7");
                    cbxCarType.Items.Add("8");
                    cbxCarType.Items.Add("Alpina");
                    cbxCarType.Items.Add("i");
                    cbxCarType.Items.Add("M");
                    cbxCarType.Items.Add("X1");
                    cbxCarType.Items.Add("X2");
                    cbxCarType.Items.Add("X3");
                    cbxCarType.Items.Add("X4");
                    cbxCarType.Items.Add("X5");
                    cbxCarType.Items.Add("X6");
                    cbxCarType.Items.Add("X7");
                    cbxCarType.Items.Add("Z3");
                    cbxCarType.Items.Add("Z4");
                    break;

                case 2: //Toyota
                    cbxCarType.Items.Add("4 Runner");
                    cbxCarType.Items.Add("86");
                    cbxCarType.Items.Add("Alphard");
                    cbxCarType.Items.Add("AT2EPN");
                    cbxCarType.Items.Add("Auris");
                    cbxCarType.Items.Add("C-HR");
                    cbxCarType.Items.Add("Camry");
                    cbxCarType.Items.Add("Camry Hybrid");
                    cbxCarType.Items.Add("Celica");
                    cbxCarType.Items.Add("Coaster");
                    cbxCarType.Items.Add("Corolla");
                    cbxCarType.Items.Add("Corolla Altis");
                    cbxCarType.Items.Add("corolla altis hybird");
                    cbxCarType.Items.Add("Corrolla Altis X");
                    cbxCarType.Items.Add("Corolla Cross");
                    cbxCarType.Items.Add("Corolla Sport");
                    cbxCarType.Items.Add("Crown");
                    cbxCarType.Items.Add("Dyna");
                    cbxCarType.Items.Add("Granvia");
                    cbxCarType.Items.Add("Hiace");
                    cbxCarType.Items.Add("HighLander");
                    cbxCarType.Items.Add("Hilux");
                    break;

                case 3: //Mitsubishi
                    cbxCarType.Items.Add("3000GT");
                    cbxCarType.Items.Add("ASX");
                    cbxCarType.Items.Add("Boss Zinger");
                    cbxCarType.Items.Add("Canter");
                    cbxCarType.Items.Add("Clot Plus");
                    cbxCarType.Items.Add("Delica");
                    cbxCarType.Items.Add("Delica廂車");
                    cbxCarType.Items.Add("Delica貨車");
                    cbxCarType.Items.Add("Eclipse");
                    cbxCarType.Items.Add("Eclipse Cross");
                    cbxCarType.Items.Add("Evo");
                    cbxCarType.Items.Add("Freeca");
                    cbxCarType.Items.Add("Fuso");
                    cbxCarType.Items.Add("Grand Lancer");
                    cbxCarType.Items.Add("Grunder");
                    cbxCarType.Items.Add("Lancer");
                    cbxCarType.Items.Add("Lancer Fortis");
                    cbxCarType.Items.Add("Lancer Sportback");
                    cbxCarType.Items.Add("LEADCA");
                    cbxCarType.Items.Add("Magic");
                    cbxCarType.Items.Add("Minicab");
                    cbxCarType.Items.Add("Outlander");
                    cbxCarType.Items.Add("Oulander PHEV");
                    break;

                case 4: //Honda
                    cbxCarType.Items.Add("Accord");
                    cbxCarType.Items.Add("City");
                    cbxCarType.Items.Add("Civic");
                    cbxCarType.Items.Add("Civic CV3");
                    cbxCarType.Items.Add("Civic K8");
                    cbxCarType.Items.Add("Civic Type R");
                    cbxCarType.Items.Add("CR-V");
                    cbxCarType.Items.Add("CR-Z");
                    cbxCarType.Items.Add("CV4");
                    cbxCarType.Items.Add("Ferio");
                    cbxCarType.Items.Add("Fit");
                    cbxCarType.Items.Add("HR-V");
                    cbxCarType.Items.Add("Insight Hybird");
                    cbxCarType.Items.Add("K6");
                    cbxCarType.Items.Add("Odyssey");
                    cbxCarType.Items.Add("S2000");
                    break;

                case 5: //Mazda
                    cbxCarType.Items.Add("CX-3");
                    cbxCarType.Items.Add("CX-30");
                    cbxCarType.Items.Add("CX-5");
                    cbxCarType.Items.Add("CX-7");
                    cbxCarType.Items.Add("CX-9");
                    cbxCarType.Items.Add("E2000");
                    cbxCarType.Items.Add("lsamu");
                    cbxCarType.Items.Add("Mazda2");
                    cbxCarType.Items.Add("Mazda3");
                    cbxCarType.Items.Add("Mazda323");
                    cbxCarType.Items.Add("Mazda5");
                    cbxCarType.Items.Add("Mazda6");
                    cbxCarType.Items.Add("Mazda6 Wagon");
                    cbxCarType.Items.Add("MPV");
                    cbxCarType.Items.Add("MX-5");
                    cbxCarType.Items.Add("Premacy");
                    cbxCarType.Items.Add("RX-8");
                    cbxCarType.Items.Add("Tribute");
                    break;

                case 6: //Ford
                    cbxCarType.Items.Add("Activa");
                    cbxCarType.Items.Add("E-250");
                    cbxCarType.Items.Add("Econoline");
                    cbxCarType.Items.Add("EcoSport");
                    cbxCarType.Items.Add("Escape");
                    cbxCarType.Items.Add("Escort");
                    cbxCarType.Items.Add("Explorer");
                    cbxCarType.Items.Add("F-150");
                    cbxCarType.Items.Add("Fiesta");
                    cbxCarType.Items.Add("Focus");
                    cbxCarType.Items.Add("Focus Powershift");
                    cbxCarType.Items.Add("Freestar");
                    cbxCarType.Items.Add("i-Max");
                    cbxCarType.Items.Add("Kuga");
                    cbxCarType.Items.Add("Metrostar");
                    cbxCarType.Items.Add("Mondeo");
                    cbxCarType.Items.Add("Mondeo Hybird");
                    cbxCarType.Items.Add("Mustang");
                    cbxCarType.Items.Add("Pronto");
                    cbxCarType.Items.Add("PRZ");
                    cbxCarType.Items.Add("Ranger");
                    cbxCarType.Items.Add("Tierra");
                    cbxCarType.Items.Add("Tourneo Custom");
                    cbxCarType.Items.Add("Windstar");
                    break;

                case 7: //Audi
                    cbxCarType.Items.Add("A1");
                    cbxCarType.Items.Add("A1 Sportback");
                    cbxCarType.Items.Add("A3 5D");
                    cbxCarType.Items.Add("A3 Sedan");
                    cbxCarType.Items.Add("A3 Sportback");
                    cbxCarType.Items.Add("A4 Allroad");
                    cbxCarType.Items.Add("A4 Avant");
                    cbxCarType.Items.Add("A4 Sedan");
                    cbxCarType.Items.Add("A5");
                    cbxCarType.Items.Add("A5 Coupe");
                    cbxCarType.Items.Add("A5 Sportback");
                    cbxCarType.Items.Add("A6");
                    cbxCarType.Items.Add("A6 Allroad");
                    cbxCarType.Items.Add("A6 Avant");
                    cbxCarType.Items.Add("A7");
                    cbxCarType.Items.Add("A7 Sportback");
                    cbxCarType.Items.Add("A8");
                    cbxCarType.Items.Add("A8L");
                    cbxCarType.Items.Add("Q2");
                    cbxCarType.Items.Add("Q3");
                    cbxCarType.Items.Add("Q5");
                    cbxCarType.Items.Add("Q7");
                    cbxCarType.Items.Add("R8 Coupe");
                    cbxCarType.Items.Add("R8 Spyder");
                    cbxCarType.Items.Add("RS 4");
                    cbxCarType.Items.Add("RS 6");
                    cbxCarType.Items.Add("S3");
                    break;

                case 8: //Hyundai
                    cbxCarType.Items.Add("Coupe");
                    cbxCarType.Items.Add("Elantra");
                    cbxCarType.Items.Add("Getz");
                    cbxCarType.Items.Add("i10");
                    cbxCarType.Items.Add("i30");
                    cbxCarType.Items.Add("i30 CW");
                    cbxCarType.Items.Add("IONIQ");
                    cbxCarType.Items.Add("ix35");
                    cbxCarType.Items.Add("Kona");
                    cbxCarType.Items.Add("Lavita");
                    cbxCarType.Items.Add("Matrix");
                    cbxCarType.Items.Add("Porter");
                    cbxCarType.Items.Add("Santa Fe");
                    cbxCarType.Items.Add("Sonata");
                    cbxCarType.Items.Add("Trajet");
                    cbxCarType.Items.Add("Tucson");
                    cbxCarType.Items.Add("Veloster");
                    cbxCarType.Items.Add("Verna");
                    break;

                case 9: //Lamborghini
                    cbxCarType.Items.Add("Aventador");
                    cbxCarType.Items.Add("Gallardo");
                    cbxCarType.Items.Add("Huracan");
                    cbxCarType.Items.Add("Huracan LP610-4");
                    cbxCarType.Items.Add("LP550-2");
                    cbxCarType.Items.Add("LP560-4");
                    cbxCarType.Items.Add("Urus");
                    break;

                case 10: //Lexus
                    cbxCarType.Items.Add("CT");
                    cbxCarType.Items.Add("ES");
                    cbxCarType.Items.Add("GS");
                    cbxCarType.Items.Add("GS F");
                    cbxCarType.Items.Add("IS");
                    cbxCarType.Items.Add("ISF");
                    cbxCarType.Items.Add("LC");
                    cbxCarType.Items.Add("LM");
                    cbxCarType.Items.Add("LS");
                    cbxCarType.Items.Add("LX");
                    cbxCarType.Items.Add("NX");
                    cbxCarType.Items.Add("RC");
                    cbxCarType.Items.Add("RX");
                    cbxCarType.Items.Add("RX L");
                    cbxCarType.Items.Add("RX450h");
                    cbxCarType.Items.Add("SC");
                    cbxCarType.Items.Add("UX");
                    break;

                case 11: //Nissan
                    cbxCarType.Items.Add("331");
                    cbxCarType.Items.Add("341");
                    cbxCarType.Items.Add("350Z");
                    cbxCarType.Items.Add("370Z");
                    cbxCarType.Items.Add("Altima");
                    cbxCarType.Items.Add("Bluebird");
                    cbxCarType.Items.Add("Cabstar");
                    cbxCarType.Items.Add("Cefiro");
                    cbxCarType.Items.Add("Cube");
                    cbxCarType.Items.Add("frontier");
                    cbxCarType.Items.Add("Grand Livina");
                    cbxCarType.Items.Add("GT-R");
                    cbxCarType.Items.Add("Juke");
                    cbxCarType.Items.Add("Livina");
                    cbxCarType.Items.Add("March");
                    cbxCarType.Items.Add("MaXima");
                    cbxCarType.Items.Add("Murano");
                    cbxCarType.Items.Add("Nissan Kicks");
                    cbxCarType.Items.Add("Pick up");
                    cbxCarType.Items.Add("Quest");
                    cbxCarType.Items.Add("Rogue");
                    cbxCarType.Items.Add("Sentra");
                    cbxCarType.Items.Add("Serena QRV");
                    cbxCarType.Items.Add("Teana");
                    cbxCarType.Items.Add("Tiida");
                    cbxCarType.Items.Add("Verita");
                    cbxCarType.Items.Add("X-Trail");
                    break;

                case 12: //Volkswagen
                    cbxCarType.Items.Add("Amarok");
                    cbxCarType.Items.Add("Beetle");
                    cbxCarType.Items.Add("Bettle 1.8T");
                    cbxCarType.Items.Add("Bora");
                    cbxCarType.Items.Add("Caddy");
                    cbxCarType.Items.Add("Caddy Pro");
                    cbxCarType.Items.Add("California");
                    cbxCarType.Items.Add("CC");
                    cbxCarType.Items.Add("Crafter");
                    cbxCarType.Items.Add("Eos");
                    cbxCarType.Items.Add("Golf");
                    cbxCarType.Items.Add("Golf GTI");
                    cbxCarType.Items.Add("Golf Plus");
                    cbxCarType.Items.Add("Golf R");
                    cbxCarType.Items.Add("Golf R32");
                    cbxCarType.Items.Add("Golf Variant");
                    cbxCarType.Items.Add("Jetta");
                    cbxCarType.Items.Add("Lupo");
                    cbxCarType.Items.Add("Lupo GTi");
                    cbxCarType.Items.Add("Passat");
                    cbxCarType.Items.Add("Passat CC");
                    cbxCarType.Items.Add("Phaeton");
                    cbxCarType.Items.Add("Pointer");
                    cbxCarType.Items.Add("Polo");
                    cbxCarType.Items.Add("Polo GTI");
                    cbxCarType.Items.Add("Scirocco");
                    break;

                case 13: //Volvo
                    cbxCarType.Items.Add("240");
                    cbxCarType.Items.Add("850");
                    cbxCarType.Items.Add("C30");
                    cbxCarType.Items.Add("S40");
                    cbxCarType.Items.Add("S60");
                    cbxCarType.Items.Add("S80");
                    cbxCarType.Items.Add("S90");
                    cbxCarType.Items.Add("V40");
                    cbxCarType.Items.Add("V40 Cross Country");
                    cbxCarType.Items.Add("V50");
                    cbxCarType.Items.Add("V60");
                    cbxCarType.Items.Add("V60 Cross Country");
                    cbxCarType.Items.Add("V90");
                    cbxCarType.Items.Add("V90 Cross Country");
                    cbxCarType.Items.Add("Volvo XC40");
                    cbxCarType.Items.Add("XC60");
                    cbxCarType.Items.Add("XC70");
                    cbxCarType.Items.Add("XC90");
                    break;

                default:
                    break;
            }//end of switch
            #endregion

            //cbxCarType.SelectedIndex = 0;

            string carbrand = cbxCarBrand.GetItemText(this.cbxCarBrand.SelectedItem);
            showTable(sender, "Brand", carbrand);
        }

        private void cbxCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCarStyle.Items.Clear();

            if (cbxCarBrand.SelectedIndex == 0)
            {
                #region //switch
                switch (cbxCarType.SelectedIndex)
                {
                    case 0: //A
                        cbxCarStyle.Items.Add("A180");
                        cbxCarStyle.Items.Add("A190");
                        cbxCarStyle.Items.Add("A200");
                        cbxCarStyle.Items.Add("A220");
                        cbxCarStyle.Items.Add("A250");
                        cbxCarStyle.Items.Add("A45 AMG");
                        cbxCarStyle.Items.Add("A45S AMG");
                        cbxCarStyle.Items.Add("AMG A 35 4Matic");
                        break;

                    case 1: //AMGGT
                        cbxCarStyle.Items.Add("AMG GT");
                        cbxCarStyle.Items.Add("AMG GTS");
                        cbxCarStyle.Items.Add("AMG GT43");
                        cbxCarStyle.Items.Add("AMG GT53");
                        break;

                    case 2: //B
                        cbxCarStyle.Items.Add("B170");
                        cbxCarStyle.Items.Add("B180");
                        cbxCarStyle.Items.Add("B200");
                        cbxCarStyle.Items.Add("B200d");
                        cbxCarStyle.Items.Add("B200t");
                        break;

                    case 3: //C
                        cbxCarStyle.Items.Add("C180");
                        cbxCarStyle.Items.Add("C200");
                        cbxCarStyle.Items.Add("C200 Cabrio");
                        cbxCarStyle.Items.Add("C200d");
                        cbxCarStyle.Items.Add("C200K");
                        cbxCarStyle.Items.Add("C200K Estate");
                        cbxCarStyle.Items.Add("C220");
                        cbxCarStyle.Items.Add("C220D");
                        cbxCarStyle.Items.Add("C230");
                        cbxCarStyle.Items.Add("C230K");
                        cbxCarStyle.Items.Add("C240");
                        cbxCarStyle.Items.Add("C250");
                        cbxCarStyle.Items.Add("C250 Estate");
                        cbxCarStyle.Items.Add("C280");
                        cbxCarStyle.Items.Add("C300");
                        cbxCarStyle.Items.Add("C300 Cabrio");
                        cbxCarStyle.Items.Add("C300 Estate");
                        cbxCarStyle.Items.Add("C32");
                        cbxCarStyle.Items.Add("C32 AMG");
                        cbxCarStyle.Items.Add("C320");
                        cbxCarStyle.Items.Add("C32T AMG");
                        cbxCarStyle.Items.Add("C350");
                        cbxCarStyle.Items.Add("C400");
                        cbxCarStyle.Items.Add("C43 AMG");
                        cbxCarStyle.Items.Add("C450");
                        cbxCarStyle.Items.Add("C63 AMG");
                        cbxCarStyle.Items.Add("C63 S AMG");
                        break;

                    case 4: //CITAN
                        cbxCarStyle.Items.Add("CITAN Tourer");
                        break;

                    case 5: //CL
                        cbxCarStyle.Items.Add("CL500");
                        cbxCarStyle.Items.Add("CL550");
                        break;

                    case 6: //CLA
                        cbxCarStyle.Items.Add("AMG CLA35");
                        cbxCarStyle.Items.Add("CLA200");
                        cbxCarStyle.Items.Add("CLA220");
                        cbxCarStyle.Items.Add("CLA250");
                        cbxCarStyle.Items.Add("CLA250 Shooting Brake");
                        cbxCarStyle.Items.Add("CLA45 AMG");
                        cbxCarStyle.Items.Add("CLA45 AMG Shooting Brake");
                        break;

                    case 7: //CLK
                        cbxCarStyle.Items.Add("CLK240");
                        cbxCarStyle.Items.Add("CLK280");
                        cbxCarStyle.Items.Add("CLK320");
                        cbxCarStyle.Items.Add("CLK350");
                        cbxCarStyle.Items.Add("CLK430");
                        break;

                    case 8: //CLS
                        cbxCarStyle.Items.Add("CLS 53");
                        cbxCarStyle.Items.Add("CLS350");
                        cbxCarStyle.Items.Add("CLS350 Shooting Brake");
                        cbxCarStyle.Items.Add("CLS350d Shooting Brake");
                        cbxCarStyle.Items.Add("CLS400");
                        cbxCarStyle.Items.Add("CLS450");
                        cbxCarStyle.Items.Add("CLS500 Shooting Brake");
                        cbxCarStyle.Items.Add("CLS550");
                        cbxCarStyle.Items.Add("CLS550 Shooting Brake");
                        cbxCarStyle.Items.Add("CLS63 AMG");
                        cbxCarStyle.Items.Add("CLS63 AMG Shooting Brake");
                        break;

                    case 9: //E
                        cbxCarStyle.Items.Add("200E");
                        cbxCarStyle.Items.Add("300CE");
                        cbxCarStyle.Items.Add("300E");
                        cbxCarStyle.Items.Add("E200");
                        cbxCarStyle.Items.Add("E200 Cabriolet");
                        cbxCarStyle.Items.Add("E200K");
                        cbxCarStyle.Items.Add("E200t");
                        cbxCarStyle.Items.Add("E220");
                        cbxCarStyle.Items.Add("E220 W124");
                        cbxCarStyle.Items.Add("E220d");
                        cbxCarStyle.Items.Add("E230");
                        cbxCarStyle.Items.Add("E240");
                        cbxCarStyle.Items.Add("E250");
                        cbxCarStyle.Items.Add("E280");
                        cbxCarStyle.Items.Add("E300");
                        cbxCarStyle.Items.Add("E300 Hybird");
                        cbxCarStyle.Items.Add("E320");
                        cbxCarStyle.Items.Add("E320d");
                        cbxCarStyle.Items.Add("E350");
                        cbxCarStyle.Items.Add("E400");
                        cbxCarStyle.Items.Add("E43");
                        cbxCarStyle.Items.Add("E43 AMG");
                        cbxCarStyle.Items.Add("E450");
                        cbxCarStyle.Items.Add("E500");
                        cbxCarStyle.Items.Add("E53 AMG");
                        cbxCarStyle.Items.Add("E55");
                        cbxCarStyle.Items.Add("E55 AMG");
                        cbxCarStyle.Items.Add("E550");
                        cbxCarStyle.Items.Add("E63 AMG");
                        cbxCarStyle.Items.Add("E63 S AMG");
                        break;

                    case 10: //G
                        cbxCarStyle.Items.Add("280GE");
                        cbxCarStyle.Items.Add("AMG G63");
                        cbxCarStyle.Items.Add("G320");
                        cbxCarStyle.Items.Add("G350d");
                        cbxCarStyle.Items.Add("G500");
                        cbxCarStyle.Items.Add("G55 AMG");
                        break;

                    case 11: //GL
                        cbxCarStyle.Items.Add("GL350");
                        cbxCarStyle.Items.Add("GL450");
                        cbxCarStyle.Items.Add("GL550 AMG");
                        break;

                    case 12: //GLA
                        cbxCarStyle.Items.Add("GLA180");
                        cbxCarStyle.Items.Add("GLA200");
                        cbxCarStyle.Items.Add("GLA200d");
                        cbxCarStyle.Items.Add("GLA250");
                        cbxCarStyle.Items.Add("GLA45 AMG");
                        break;

                    case 13: //GLB
                        cbxCarStyle.Items.Add("GLB200");
                        cbxCarStyle.Items.Add("GLB250");
                        break;

                    case 14: //GLC
                        cbxCarStyle.Items.Add("63 AMG 4MATIC+");
                        cbxCarStyle.Items.Add("GLC200");
                        cbxCarStyle.Items.Add("GLC220d");
                        cbxCarStyle.Items.Add("GLC220d");
                        cbxCarStyle.Items.Add("GLC250");
                        cbxCarStyle.Items.Add("GLC300");
                        cbxCarStyle.Items.Add("GLC43 AMG");
                        cbxCarStyle.Items.Add("GLC63 S AMG");
                        break;

                    case 15: //GLE
                        cbxCarStyle.Items.Add("300d");
                        cbxCarStyle.Items.Add("AMG GLE43");
                        cbxCarStyle.Items.Add("GLE250d");
                        cbxCarStyle.Items.Add("GLE350");
                        cbxCarStyle.Items.Add("GLE350d");
                        cbxCarStyle.Items.Add("GLE400");
                        cbxCarStyle.Items.Add("GLE450");
                        cbxCarStyle.Items.Add("GKE450 AMG");
                        cbxCarStyle.Items.Add("GLE53 AMG");
                        cbxCarStyle.Items.Add("GLE63 AMG");
                        break;

                    case 16: //GLK
                        cbxCarStyle.Items.Add("GLK220");
                        cbxCarStyle.Items.Add("GLK280");
                        cbxCarStyle.Items.Add("GLK300");
                        cbxCarStyle.Items.Add("GLK350");
                        break;

                    case 17: //GLS
                        cbxCarStyle.Items.Add("GLS 450");
                        cbxCarStyle.Items.Add("GLS350d");
                        cbxCarStyle.Items.Add("GLS400");
                        cbxCarStyle.Items.Add("GLS63 AMG");
                        break;

                    case 18: //Metris
                        cbxCarStyle.Items.Add("Metris vans");
                        break;

                    case 19: //ML
                        cbxCarStyle.Items.Add("ML250");
                        cbxCarStyle.Items.Add("ML320");
                        cbxCarStyle.Items.Add("ML350");
                        cbxCarStyle.Items.Add("ML350d");
                        cbxCarStyle.Items.Add("ML400");
                        cbxCarStyle.Items.Add("ML63 AMG");
                        break;

                    case 20: //R
                        cbxCarStyle.Items.Add("R350");
                        cbxCarStyle.Items.Add("R500");
                        break;

                    case 21: //S
                        cbxCarStyle.Items.Add("300SE");
                        cbxCarStyle.Items.Add("S-Class 300SEL");
                        cbxCarStyle.Items.Add("S-Class W126");
                        cbxCarStyle.Items.Add("S280");
                        cbxCarStyle.Items.Add("S300");
                        cbxCarStyle.Items.Add("S320");
                        cbxCarStyle.Items.Add("S320L");
                        cbxCarStyle.Items.Add("S350");
                        cbxCarStyle.Items.Add("S350d");
                        cbxCarStyle.Items.Add("S350d L");
                        cbxCarStyle.Items.Add("S400");
                        cbxCarStyle.Items.Add("S400 Hybird");
                        cbxCarStyle.Items.Add("S400 LWB");
                        cbxCarStyle.Items.Add("S450");
                        cbxCarStyle.Items.Add("S450 L");
                        cbxCarStyle.Items.Add("S500");
                        cbxCarStyle.Items.Add("S500 L");
                        cbxCarStyle.Items.Add("S550");
                        cbxCarStyle.Items.Add("S560 L");
                        cbxCarStyle.Items.Add("S600");
                        cbxCarStyle.Items.Add("S63 AMG");
                        break;

                    case 22: //SL
                        cbxCarStyle.Items.Add("SL300");
                        cbxCarStyle.Items.Add("SL320");
                        cbxCarStyle.Items.Add("SL350");
                        cbxCarStyle.Items.Add("SL400");
                        cbxCarStyle.Items.Add("SL500");
                        cbxCarStyle.Items.Add("SL55 AMG");
                        cbxCarStyle.Items.Add("SL550");
                        cbxCarStyle.Items.Add("SL600");
                        cbxCarStyle.Items.Add("SL63 AMG");
                        break;

                    case 23: //SL
                        cbxCarStyle.Items.Add("SLC200");
                        break;

                    case 24: //SLK
                        cbxCarStyle.Items.Add("SLK200");
                        cbxCarStyle.Items.Add("SLK230");
                        cbxCarStyle.Items.Add("SLK250");
                        cbxCarStyle.Items.Add("SLK280");
                        cbxCarStyle.Items.Add("SLK350");
                        cbxCarStyle.Items.Add("SLK55 AMG");
                        break;

                    case 25: //SLR
                        cbxCarStyle.Items.Add("SLR Coupe");
                        break;

                    case 26: //SLS
                        cbxCarStyle.Items.Add("SLS AMG");
                        break;

                    case 27: //V
                        cbxCarStyle.Items.Add("V220d");
                        cbxCarStyle.Items.Add("V250d");
                        cbxCarStyle.Items.Add("V300");
                        cbxCarStyle.Items.Add("VIANO");
                        cbxCarStyle.Items.Add("Vito");
                        break;

                    case 28: //W123
                        cbxCarStyle.Items.Add("230E");
                        cbxCarStyle.Items.Add("W123");
                        break;

                    case 29: //W201
                        cbxCarStyle.Items.Add("190E");
                        break;

                    case 30: //X
                        cbxCarStyle.Items.Add("X250D");
                        break;

                    default:
                        break;
                }//end of switch
                #endregion

                
            }
            else if ( cbxCarBrand.SelectedIndex == 1)
            {
                #region //switch
                switch (cbxCarType.SelectedIndex)
                {
                    
                    case 0: //1
                        cbxCarStyle.Items.Add("116i");
                        cbxCarStyle.Items.Add("118d");
                        cbxCarStyle.Items.Add("118i");
                        cbxCarStyle.Items.Add("118i 運動版");
                        cbxCarStyle.Items.Add("120d");
                        cbxCarStyle.Items.Add("120i");
                        cbxCarStyle.Items.Add("120i M Sport");
                        cbxCarStyle.Items.Add("120iA");
                        cbxCarStyle.Items.Add("123d");
                        cbxCarStyle.Items.Add("125i");
                        cbxCarStyle.Items.Add("130i");
                        cbxCarStyle.Items.Add("135i");
                        cbxCarStyle.Items.Add("M135i");
                        break; 

                    case 1: //2
                        cbxCarStyle.Items.Add("218d");
                        cbxCarStyle.Items.Add("218i");
                        cbxCarStyle.Items.Add("220d");
                        cbxCarStyle.Items.Add("220i");
                        cbxCarStyle.Items.Add("220i M Sport");
                        cbxCarStyle.Items.Add("225i");
                        cbxCarStyle.Items.Add("M 220I");
                        cbxCarStyle.Items.Add("M235i");
                        cbxCarStyle.Items.Add("M235i xDrive");
                        cbxCarStyle.Items.Add("M240i");
                        break;

                    case 2: //3
                        cbxCarStyle.Items.Add("316i");
                        cbxCarStyle.Items.Add("318Ci");
                        cbxCarStyle.Items.Add("318d");
                        cbxCarStyle.Items.Add("320ci");
                        cbxCarStyle.Items.Add("320d");
                        cbxCarStyle.Items.Add("320d GT");
                        cbxCarStyle.Items.Add("320i");
                        cbxCarStyle.Items.Add("320i GT");
                        cbxCarStyle.Items.Add("320i LCI");
                        cbxCarStyle.Items.Add("320i M Sport");
                        cbxCarStyle.Items.Add("320i Sport Line");
                        cbxCarStyle.Items.Add("323ci");
                        cbxCarStyle.Items.Add("323i");
                        cbxCarStyle.Items.Add("323i M Sport");
                        cbxCarStyle.Items.Add("325ci");
                        cbxCarStyle.Items.Add("325i");
                        cbxCarStyle.Items.Add("325is");
                        cbxCarStyle.Items.Add("325xi");
                        cbxCarStyle.Items.Add("328i");
                        cbxCarStyle.Items.Add("328i GT");
                        cbxCarStyle.Items.Add("328i M Sport");
                        cbxCarStyle.Items.Add("328xi");
                        cbxCarStyle.Items.Add("330ci");
                        cbxCarStyle.Items.Add("330i GT");
                        cbxCarStyle.Items.Add("330i M Sport");
                        cbxCarStyle.Items.Add("335ci");
                        cbxCarStyle.Items.Add("335i");
                        cbxCarStyle.Items.Add("335i GT");
                        cbxCarStyle.Items.Add("340i");
                        cbxCarStyle.Items.Add("ActiveHybrid3");
                        cbxCarStyle.Items.Add("M340i XDrive");
                        break;

                    case 3: //4
                        cbxCarStyle.Items.Add("420i");
                        cbxCarStyle.Items.Add("420i M Sport");
                        cbxCarStyle.Items.Add("428i");
                        cbxCarStyle.Items.Add("428i M Sport");
                        cbxCarStyle.Items.Add("430i");
                        cbxCarStyle.Items.Add("430i M Sport");
                        cbxCarStyle.Items.Add("435i");
                        cbxCarStyle.Items.Add("440i");
                        cbxCarStyle.Items.Add("440i M Sport");
                        break;
                    case 4: //5
                        cbxCarStyle.Items.Add("520d");
                        cbxCarStyle.Items.Add("520d GT");
                        cbxCarStyle.Items.Add("520d Luxury");
                        cbxCarStyle.Items.Add("520d Touring");
                        cbxCarStyle.Items.Add("520i");
                        cbxCarStyle.Items.Add("520i Luxury");
                        cbxCarStyle.Items.Add("520i M Sport");
                        cbxCarStyle.Items.Add("520i Touring");
                        cbxCarStyle.Items.Add("520iA");
                        cbxCarStyle.Items.Add("523i");
                        cbxCarStyle.Items.Add("525d");
                        cbxCarStyle.Items.Add("525i");
                        cbxCarStyle.Items.Add("525i Sport");
                        cbxCarStyle.Items.Add("525iA");
                        cbxCarStyle.Items.Add("528i");
                        cbxCarStyle.Items.Add("528i GT");
                        cbxCarStyle.Items.Add("528i Luxury");
                        cbxCarStyle.Items.Add("528 M Sport");
                        cbxCarStyle.Items.Add("528i Touring");
                        cbxCarStyle.Items.Add("530d");
                        cbxCarStyle.Items.Add("530d GT");
                        cbxCarStyle.Items.Add("530d M Sport");
                        cbxCarStyle.Items.Add("530 i");
                        cbxCarStyle.Items.Add("530i Luxury");
                        cbxCarStyle.Items.Add("530i M Sport");
                        cbxCarStyle.Items.Add("530i xDrive");
                        cbxCarStyle.Items.Add("530XI xDrive");
                        cbxCarStyle.Items.Add("530XI Touring");
                        cbxCarStyle.Items.Add("535d");
                        cbxCarStyle.Items.Add("535i");
                        cbxCarStyle.Items.Add("535i GT");
                        cbxCarStyle.Items.Add("535i M Sport");
                        cbxCarStyle.Items.Add("535xi");
                        cbxCarStyle.Items.Add("540i");
                        cbxCarStyle.Items.Add("540i M Sport");
                        cbxCarStyle.Items.Add("540i XDrive");
                        cbxCarStyle.Items.Add("550i");
                        cbxCarStyle.Items.Add("550i GT");
                        cbxCarStyle.Items.Add("ActiveHybird 5");
                        cbxCarStyle.Items.Add("M550d xDrive");
                        cbxCarStyle.Items.Add("M550i");
                        cbxCarStyle.Items.Add("M550i xDrive");
                        break;

                    case 5: //6
                        cbxCarStyle.Items.Add("630i");
                        cbxCarStyle.Items.Add("640i");
                        cbxCarStyle.Items.Add("640i M Sport");
                        cbxCarStyle.Items.Add("645Ci");
                        cbxCarStyle.Items.Add("650i");
                        break;

                    case 6:
                        cbxCarStyle.Items.Add("728i");
                        cbxCarStyle.Items.Add("730d");
                        cbxCarStyle.Items.Add("730d Luxury");
                        cbxCarStyle.Items.Add("730i");
                        cbxCarStyle.Items.Add("730i Luxury");
                        cbxCarStyle.Items.Add("730Ld");
                        cbxCarStyle.Items.Add("730Li");
                        cbxCarStyle.Items.Add("735iL");
                        cbxCarStyle.Items.Add("735Li");
                        cbxCarStyle.Items.Add("740i");
                        cbxCarStyle.Items.Add("740Li");
                        cbxCarStyle.Items.Add("740Li Luxury");
                        cbxCarStyle.Items.Add("745Li");
                        cbxCarStyle.Items.Add("750i");
                        cbxCarStyle.Items.Add("750Ld");
                        cbxCarStyle.Items.Add("750Ld");
                        cbxCarStyle.Items.Add("750Li");
                        cbxCarStyle.Items.Add("750Li Luxury");
                        cbxCarStyle.Items.Add("760Li");
                        cbxCarStyle.Items.Add("ActiveHybird 7");
                        cbxCarStyle.Items.Add("ActiveHybird 7L");
                        cbxCarStyle.Items.Add("L7");
                        break;

                    case 7: //8
                        cbxCarStyle.Items.Add("840i M Sport");
                        cbxCarStyle.Items.Add("m850i");
                        break;

                    case 8: //Alpina
                        cbxCarStyle.Items.Add("Alpina B3");
                        cbxCarStyle.Items.Add("Alpina B5");
                        cbxCarStyle.Items.Add("Alpina B6");
                        break;

                    case 9: //i
                        cbxCarStyle.Items.Add("i3");
                        cbxCarStyle.Items.Add("i3s");
                        cbxCarStyle.Items.Add("i3s REx");
                        cbxCarStyle.Items.Add("i8 Coupe");
                        break;

                    case 10: //M
                        cbxCarStyle.Items.Add("M1 Coupe");
                        cbxCarStyle.Items.Add("M2 Coupe");
                        cbxCarStyle.Items.Add("M3 Convertible");
                        cbxCarStyle.Items.Add("M3 Coupe");
                        cbxCarStyle.Items.Add("M3 Coupe 手排版");
                        cbxCarStyle.Items.Add("M3 M-DCT");
                        cbxCarStyle.Items.Add("M3 Sedan");
                        cbxCarStyle.Items.Add("M3 Sedan 手排版");
                        cbxCarStyle.Items.Add("M4 Convertible");
                        cbxCarStyle.Items.Add("M4 Coupe");
                        cbxCarStyle.Items.Add("M5 Sedan");
                        cbxCarStyle.Items.Add("M6 Coupe");
                        cbxCarStyle.Items.Add("X3 M");
                        cbxCarStyle.Items.Add("X4 M");
                        break;

                    case 11: //X1
                        cbxCarStyle.Items.Add("X1 sDrive18d");
                        cbxCarStyle.Items.Add("X1 sDrive18i");
                        cbxCarStyle.Items.Add("X1 sDrive20d");
                        cbxCarStyle.Items.Add("X1 sDrive20i");
                        cbxCarStyle.Items.Add("X1 sDrive28i");
                        cbxCarStyle.Items.Add("X1 xDrive20i");
                        cbxCarStyle.Items.Add("X1 xDrive20d");
                        cbxCarStyle.Items.Add("X1 xDrive23d");
                        cbxCarStyle.Items.Add("X1 xDrive25d");
                        cbxCarStyle.Items.Add("X1 xDrive28i");
                        break;

                    case 12: //X2
                        cbxCarStyle.Items.Add("M35i");
                        cbxCarStyle.Items.Add("X2 sDrive 18i");
                        cbxCarStyle.Items.Add("X2 sDrive 18i M SportX");
                        cbxCarStyle.Items.Add("X2 sDrive 20i");
                        cbxCarStyle.Items.Add("X2 sDrive 28i");
                        break;

                    case 13: //X3
                        cbxCarStyle.Items.Add("X3 2.5si");
                        cbxCarStyle.Items.Add("X3 3.0si");
                        cbxCarStyle.Items.Add("X3 M40i");
                        cbxCarStyle.Items.Add("X3 sDrive 20i");
                        cbxCarStyle.Items.Add("X3 sDrive 28i");
                        cbxCarStyle.Items.Add("X3 sDrive 30i");
                        cbxCarStyle.Items.Add("X3 xDrive 20d");
                        cbxCarStyle.Items.Add("X3 xDrive 20i");
                        cbxCarStyle.Items.Add("X3 xDrive 25i");
                        cbxCarStyle.Items.Add("X3 xDrive 28i");
                        cbxCarStyle.Items.Add("X3 xDrive 30d");
                        cbxCarStyle.Items.Add("X3 xDrive 30i");
                        cbxCarStyle.Items.Add("X3 xDrive 35i");
                        break;

                    case 14: //X4
                        cbxCarStyle.Items.Add("X4 M40i");
                        cbxCarStyle.Items.Add("X4 xDrive20i");
                        cbxCarStyle.Items.Add("X4 xDrive20i 運動版");
                        cbxCarStyle.Items.Add("X4 xDrive28i");
                        cbxCarStyle.Items.Add("X4 xDrive30d");
                        cbxCarStyle.Items.Add("X4 xDrive30i");
                        cbxCarStyle.Items.Add("X4 xDrive30i M Sport");
                        cbxCarStyle.Items.Add("X4 xDrive35i");
                        break;

                    case 15: //X5
                        cbxCarStyle.Items.Add("X5 3.0d");
                        cbxCarStyle.Items.Add("X5 3.0i");
                        cbxCarStyle.Items.Add("X5 3.0sd");
                        cbxCarStyle.Items.Add("X5 3.0si");
                        cbxCarStyle.Items.Add("X5 4.4i");
                        cbxCarStyle.Items.Add("X5 4.8i");
                        cbxCarStyle.Items.Add("X5 5M");
                        cbxCarStyle.Items.Add("X5 M50d");
                        cbxCarStyle.Items.Add("X5 sDrive35i");
                        cbxCarStyle.Items.Add("X5 xDrive25d");
                        cbxCarStyle.Items.Add("X5 xDrive30d");
                        cbxCarStyle.Items.Add("X5 xDrive30i");
                        cbxCarStyle.Items.Add("X5 xDrive35i");
                        cbxCarStyle.Items.Add("X5 xDrive40d");
                        cbxCarStyle.Items.Add("X5 xDrive40i");
                        cbxCarStyle.Items.Add("X5 xDrive50i");
                        cbxCarStyle.Items.Add("X5 xDriveM50d");
                        break;

                    case 16: //X6
                        cbxCarStyle.Items.Add("X6 M");
                        cbxCarStyle.Items.Add("X6 M50d");
                        cbxCarStyle.Items.Add("X6 xDrive30d");
                        cbxCarStyle.Items.Add("X6 xDrive35i");
                        cbxCarStyle.Items.Add("X6 xDrive40d");
                        cbxCarStyle.Items.Add("X6 xDrive40i");
                        cbxCarStyle.Items.Add("X6 xDrive50i");
                        break;

                    case 17: //X7
                        cbxCarStyle.Items.Add("X7 xDrive40i");
                        break;

                    case 18: //Z3
                        cbxCarStyle.Items.Add("Z3");
                        break;

                    case 19: //Z4
                        cbxCarStyle.Items.Add("Z4 2.5i");
                        cbxCarStyle.Items.Add("Z4 25i");
                        cbxCarStyle.Items.Add("Z4 3.0si");
                        cbxCarStyle.Items.Add("Z4 M Roadster");
                        cbxCarStyle.Items.Add("Z4 M40i");
                        cbxCarStyle.Items.Add("Z4 sDrive18i");
                        cbxCarStyle.Items.Add("Z4 sDrive20i");
                        cbxCarStyle.Items.Add("Z4 sDrive20i Sport Line");
                        cbxCarStyle.Items.Add("Z4 sDrive23i");
                        cbxCarStyle.Items.Add("Z4 sDrive30i");
                        cbxCarStyle.Items.Add("Z4 sDrive35i");
                        cbxCarStyle.Items.Add("Z4 sDrive35is");
                        break;

                    default:
                        break;
                }//end of switch
                #endregion
               
            }

            //cbxCarStyle.SelectedIndex = 0;
            string carType = cbxCarType.GetItemText(this.cbxCarType.SelectedItem);
            showTable(sender, "CarType", carType);
        }

        private void cbxCarStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string carStyle = cbxCarStyle.GetItemText(this.cbxCarStyle.SelectedItem);
            showTable(sender, "CarStyle", carStyle);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            //string carbrand = cbxcarbrand.getitemtext(this.cbxcarbrand.selecteditem);
            //messagebox.show(carbrand);

            cbxCarBrand.SelectedIndex = -1;
            cbxCarType.SelectedIndex = -1;
            cbxCarStyle.SelectedIndex = -1;

            dgvData.DataSource = null;
            dgvData.Columns.Clear();

            int MinPrice = 0;
            int MaxPrice = int.MaxValue;
            string CarDoorStr = "";
            string PassengerStr = "";

            int carAge = (int)nudCarAge.Value;
            DateTime myDate = DateTime.Now;
            string year = myDate.ToString("yyyy");
            int nowYear = int.Parse(year);
            int DifferentYear = nowYear - carAge;

            if (nudMaxPrice.Value != 0)
            {
                MinPrice = (int)nudMinPrice.Value;
                MaxPrice = (int)nudMaxPrice.Value;
            }

            if (cbxCarDoor.Text != "")
            {
                CarDoorStr = $" AND carresource.CarDoor = {cbxCarDoor.Text}";
            }

            if (cbxPassenger.Text != "")
            {
                PassengerStr = $" AND carresource.Passenger = {cbxPassenger.Text}";
            }

            String searchStr = tbxSearch.Text;
            string[] columnsStr = { "CarType", "CarStyle" };

            if (MinPrice < MaxPrice)
            {
                if (tbxSearch.Text != "")
                {

                    sqlStr = $"SELECT salescar.Brand AS '廠牌', salescar.CarType AS '車款', salescar.CarStyle AS '車種', carresource.CarModel AS '車型', carresource.CarDoor AS '車門數', carresource.Passenger AS '乘客數', carresource.CableControlSystem AS '變速系統', carresource.EngineDisplacement AS '排氣量', carresource.CarColor AS '車色',salescar.CarAge AS '車齡',salescar.Region AS '地區', salescar.CarDealerID AS '賣家編號', salescar.Price AS '價格' FROM salescar LEFT JOIN carresource On salescar.Brand = carresource.Brand AND salescar.CarType = carresource.CarType AND salescar.CarStyle = carresource.CarStyle WHERE salescar.isSale = 0 AND salescar.CarAge > {DifferentYear} AND salescar.Price BETWEEN {MinPrice} AND {MaxPrice} AND salescar.Brand like '{searchStr}%'" + CarDoorStr + PassengerStr;

                    mySqlDataAdapter = new MySqlDataAdapter(sqlStr, conn);
                    ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dgvData.DataSource = ds.Tables[0];


                    for (int i = 0; i < columnsStr.Length; i++)
                    {
                        if (ds.Tables.Count == 1 & ds.Tables[0].Rows.Count == 0)
                        {
                            sqlStr = $"SELECT salescar.Brand AS '廠牌', salescar.CarType AS '車款', salescar.CarStyle AS '車種', carresource.CarModel AS '車型', carresource.CarDoor AS '車門數', carresource.Passenger AS '乘客數', carresource.CableControlSystem AS '變速系統', carresource.EngineDisplacement AS '排氣量', carresource.CarColor AS '車色',salescar.CarAge AS '車齡',salescar.Region AS '地區', salescar.CarDealerID AS '賣家編號', salescar.Price AS '價格' FROM salescar LEFT JOIN carresource On salescar.Brand = carresource.Brand AND salescar.CarType = carresource.CarType AND salescar.CarStyle = carresource.CarStyle WHERE salescar.isSale = 0 AND salescar.CarAge > {DifferentYear} AND salescar.Price BETWEEN {MinPrice} AND {MaxPrice} AND salescar.{columnsStr[i]} like '{searchStr}%'" + CarDoorStr + PassengerStr;

                            mySqlDataAdapter = new MySqlDataAdapter(sqlStr, conn);
                            ds = new DataSet();
                            mySqlDataAdapter.Fill(ds);
                            dgvData.DataSource = ds.Tables[0];

                        }
                    }

                }
                else
                {
                    sqlStr = $"SELECT salescar.Brand AS '廠牌', salescar.CarType AS '車款', salescar.CarStyle AS '車種', carresource.CarModel AS '車型', carresource.CarDoor AS '車門數', carresource.Passenger AS '乘客數', carresource.CableControlSystem AS '變速系統', carresource.EngineDisplacement AS '排氣量', carresource.CarColor AS '車色',salescar.CarAge AS '車齡',salescar.Region AS '地區', salescar.CarDealerID AS '賣家編號', salescar.Price AS '價格' FROM salescar LEFT JOIN carresource On salescar.Brand = carresource.Brand AND salescar.CarType = carresource.CarType AND salescar.CarStyle = carresource.CarStyle WHERE salescar.isSale = 0 AND salescar.CarAge > {DifferentYear} AND salescar.Price BETWEEN {MinPrice} AND {MaxPrice}" + CarDoorStr + PassengerStr;
                    mySqlDataAdapter = new MySqlDataAdapter(sqlStr, conn);
                    ds = new DataSet();
                    mySqlDataAdapter.Fill(ds);
                    dgvData.DataSource = ds.Tables[0];
                }

                if (ds.Tables.Count == 1 & ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("查無相關資料。");
                    tbxSearch.Clear();
                    showOringalTable();
                }
            }
            else
            {
                MessageBox.Show("最低價格不可高於最價格!");
                showOringalTable();
            }


            addButtonIntoDGV();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvData_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            //DBmanipulation.updateDGV(dgvData, mySqlDataAdapter);
        }

        private void dgvData_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            frmLogin ff = new frmLogin();
            ff.ShowDialog();
            ff.getIDfromLogin(out BuyerID, out SellerID);

            //MessageBox.Show(BuyerID + "/" + SellerID);

            if(BuyerID != null)
            {
                btnSignUp.Visible = false;
                btnBuyerCR.Visible = true;
                btnLogin.Visible = false;
                btnLogout.Visible = true;
                btnSellerCR.Visible = false;
                btnBCarOrder.Visible = true;

            }
            else if(SellerID != null)
            {
                btnSignUp.Visible = false;
                btnBuyerCR.Visible = false;
                btnLogin.Visible = false;
                btnLogout.Visible = true;
                btnSellerCR.Visible = true;
                btnSellerSC.Visible = true;
                btnSCarOrder.Visible = true;
            }
                         
        }

        private void btnSignUp_Click_1(object sender, EventArgs e)
        {
            frmSignUp ff = new frmSignUp();
            ff.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string caption = "登出";
            string message = "是否登出?";
            var doubleCheck = MessageBox.Show( message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (doubleCheck == DialogResult.Yes)
            {
                BuyerID = null;
                SellerID = null;
                buttonVisible();
            }
        }

        private void btnSellerCR_Click(object sender, EventArgs e)
        {
            frmBCreditingRating ff = new frmBCreditingRating(BuyerID);
            ff.Show();
        }

        private void btnSellerCR_Click_1(object sender, EventArgs e)
        {
            frmSCreditRating ff = new frmSCreditRating(SellerID);
            ff.Show();
        }

        private void btnCarOrder_Click(object sender, EventArgs e)
        {
            frmSCarTransaction ff = new frmSCarTransaction(SellerID);
            ff.ShowDialog();

            showOringalTable();
        }

        private void btnBCarOrder_Click(object sender, EventArgs e)
        {
            frmBCarTransaction ff = new frmBCarTransaction(BuyerID);
            ff.ShowDialog();

            showOringalTable();
        }

        private void btnSellerSC_Click(object sender, EventArgs e)
        {
            frmCarDealerInsert ff = new frmCarDealerInsert(SellerID);
            ff.ShowDialog();

            showOringalTable();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            int MinPrice = 0;
            int MaxPrice = int.MaxValue;
            string CarBrandStr = "";
            string CarTypeStr = "";
            string CarStyleStr = "";
            string CarDoorStr = "";
            string PassengerStr = "";


            int carAge = (int)nudCarAge.Value;
            DateTime myDate = DateTime.Now;
            string year = myDate.ToString("yyyy");
            int nowYear = int.Parse(year);
            int DifferentYear = nowYear - carAge;

            if (nudMaxPrice.Value != 0)
            {
                MinPrice = (int)nudMinPrice.Value;
                MaxPrice = (int)nudMaxPrice.Value;
            }

            if (cbxCarBrand.Text != "")
            {
                CarBrandStr = $" AND salescar.Brand = '{cbxCarBrand.Text}'";
            }

            if (cbxCarType.Text != "")
            {
                CarTypeStr = $" AND salescar.CarType = '{cbxCarType.Text}'";
            }

            if (cbxCarStyle.Text != "")
            {
                CarStyleStr = $" AND salescar.CarStyle = '{cbxCarStyle.Text}'";
            }

            if (cbxCarDoor.Text != "")
            {
                CarDoorStr = $" AND carresource.CarDoor = {cbxCarDoor.Text}";
            }

            if (cbxPassenger.Text != "")
            {
                PassengerStr = $" AND carresource.Passenger = {cbxPassenger.Text}";
            }


            if (MinPrice < MaxPrice)
            {
                sqlStr = $"SELECT salescar.Brand AS '廠牌', salescar.CarType AS '車款', salescar.CarStyle AS '車種', carresource.CarModel AS '車型', carresource.CarDoor AS '車門數', carresource.Passenger AS '乘客數', carresource.CableControlSystem AS '變速系統', carresource.EngineDisplacement AS '排氣量', carresource.CarColor AS '車色',salescar.CarAge AS '車齡',salescar.Region AS '地區', salescar.CarDealerID AS '賣家編號', salescar.Price AS '價格' FROM salescar LEFT JOIN carresource On salescar.Brand = carresource.Brand AND salescar.CarType = carresource.CarType AND salescar.CarStyle = carresource.CarStyle WHERE salescar.isSale = 0 AND salescar.CarAge > {DifferentYear} AND salescar.Price BETWEEN {MinPrice} AND {MaxPrice}" + CarBrandStr + CarTypeStr + CarStyleStr + CarDoorStr + PassengerStr;

                mySqlDataAdapter = new MySqlDataAdapter(sqlStr, conn);
                ds = new DataSet();
                mySqlDataAdapter.Fill(ds);
                dgvData.DataSource = ds.Tables[0];

            }
            else
            {
                MessageBox.Show("最低價格不可高於最價格!");
                showOringalTable();
            }

        }

        private void nudMinPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudMaxPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudMaxPrice_Leave(object sender, EventArgs e)
        {

        }
    }//end of class
}//end of namespace
