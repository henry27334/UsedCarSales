using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Library;
using MySql.Data.MySqlClient;

namespace A107222008_UsedCar
{
    public partial class frmSignUp : Form
    {
        private string dbHost = "localhost";
        private string dbPort = "3306";
        private string dbUser = "root";
        private string dbPassword = "";
        private string dbName = "db2020f_usedcarsales";
        private string connStr = "protocol=tcp;pooling=false;Sslmode=none;charset=utf8;";
        public static string UserName;
        public static string UserType;
        public static int ID;

        public frmSignUp()
        {
            InitializeComponent();
            cbxChoice.SelectedIndex = 0;
            cbxGender.SelectedIndex = 0;
            cbxChoice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            lblEarnestMoney.Visible = false;
            tbxEarnestMoney.Visible = false;
            
        }

        private void cbxChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbxChoice.Text == "買家") 
            {
                lblEarnestMoney.Visible = false;
                tbxEarnestMoney.Visible = false;
                lblGender.Visible = true;
                cbxGender.Visible = true;

            }
            else if (cbxChoice.Text == "賣家")
            {
                lblEarnestMoney.Visible = true;
                tbxEarnestMoney.Visible = true;
                lblGender.Visible = false;
                cbxGender.Visible = false;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string connStr = $"server={dbHost};port={dbPort};uid={dbUser};pwd={dbPassword};database={dbName}";
            MySqlConnection conn = DBconnection.connectMariaDB(dbHost, dbPort, dbUser, dbPassword, dbName);
            
            if (cbxChoice.Text == "買家")
            {
                //&& tbxId.Text.Length > 20
                
                if (tbxId.Text.Length < 5 || tbxId.Text.Length > 20)
                {
                    MessageBox.Show("帳號長度需介於5到20個字元。");
                }

                if (tbxPassword.Text.Length < 5 || tbxPassword.Text.Length > 20)
                {
                    MessageBox.Show("密碼長度需介於5到20個字元。");
                }

                if (tbxName.Text == "")
                {
                    MessageBox.Show("名字不能為空！");
                }
                if (cbxChoice.Text == "")
                {
                    MessageBox.Show("性別不能為空！");
                }               
                if (tbxAddress.Text == "")
                {
                    MessageBox.Show("地址不能為空！");
                }
                if (tbxphoneNumber.Text == "")
                {
                    MessageBox.Show("電話號碼不能為空！");
                }
                if (tbxEmail.Text == "")
                {
                    MessageBox.Show("電子郵件不能為空！");
                }

                string genderStr = "";
                if(cbxGender.SelectedIndex == 0)
                {
                    genderStr = "M";
                }
                else
                {
                    genderStr = "W";
                }
                

                if (tbxId.Text.Length > 4 && tbxPassword.Text.Length > 4 && tbxName.Text != "" && cbxGender.SelectedItem != null && tbxEmail.Text != "" && tbxAddress.Text != "" && tbxphoneNumber.Text != "")
                {
                    try
                    {
                        string sqlStr = $"INSERT INTO buyer(BuyerID, Password, Name, Gender, Email, Address, PhoneNumber) VALUES ('{tbxId.Text}' , '{tbxPassword.Text}', '{tbxName.Text}', '{genderStr}', '{tbxEmail.Text}', '{tbxAddress.Text}', '{tbxphoneNumber.Text}')";
                        MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("註冊成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        this.Close();
                    }
                }

            }
            else if (cbxChoice.Text == "賣家")
            {
                if (tbxId.Text.Length < 5 || tbxId.Text.Length > 20)
                {
                    MessageBox.Show("帳號長度需介於5到20個字元。");
                }

                if (tbxPassword.Text.Length < 5 || tbxPassword.Text.Length > 20)
                {
                    MessageBox.Show("密碼長度需介於5到20個字元。");
                }
                if (tbxName.Text == "")
                {
                    MessageBox.Show("名字不能為空！");
                }
                if (tbxEarnestMoney.Text == "")
                {
                    MessageBox.Show("保證金不能為空！");
                }
                if (tbxAddress.Text == "")
                {
                    MessageBox.Show("地址不能為空！");
                }
                if (tbxphoneNumber.Text == "")
                {
                    MessageBox.Show("電話號碼不能為空！");
                }
                if (tbxEmail.Text == "")
                {
                    MessageBox.Show("Email不能為空！");
                }

                if (tbxId.Text.Length > 4 && tbxPassword.Text.Length > 4 && tbxName.Text != "" && tbxEmail.Text != "" && tbxphoneNumber.Text != "" && tbxAddress.Text != "" && tbxEarnestMoney.Text != "")
                {
                    try
                    {
                        string sqlStr = $"INSERT INTO cardealer(CarDealerID, Password, Name, Email, PhoneNumber, StoreAddress, EarnestMoney) VALUES ('{tbxId.Text}' , '{tbxPassword.Text}', '{tbxName.Text}', '{tbxEmail.Text}', '{tbxphoneNumber.Text}', '{tbxAddress.Text}', '{tbxEarnestMoney.Text}')";
                        MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("註冊成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        this.Close();
                    }
                }
            }
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsUpper(e.KeyChar) && !Char.IsLower(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        private void tbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsUpper(e.KeyChar) && !Char.IsLower(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tbxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsUpper(e.KeyChar) && !Char.IsLower(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tbxEarnestMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tbxAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tbxphoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tbxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsUpper(e.KeyChar) && !Char.IsLower(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 64)
            {
                e.Handled = true;
            }
        }

        private void tbxAddress_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
