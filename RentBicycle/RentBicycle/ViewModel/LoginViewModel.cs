using DevComponents.DotNetBar.Controls;
using RentBicycle.Model;
using RentBicycle.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentBicycle.ViewModel
{
    public class LoginViewModel
    {
        private RentBicycleEntities _database;
        private FormRegister _frmRegister;
        private FormMain _frmMain;

        public LoginViewModel() => _database = new RentBicycleEntities();

        public void OpenFormRegister()
        {
            _frmRegister = new FormRegister();
            _frmRegister.ShowDialog();
        }

        public void Login(string email, string password, Form frmLogin,CheckBoxX chkRemember)
        {
            if (email != "enter email" && password != "enter password")
            {
                //Remember ME
                SaveDataToAppconfig(email,password,chkRemember);

                usp_Login_Result results = _database.usp_Login(email, Helper.EncryptMD5(password)).FirstOrDefault();
                if (results != null)
                {
                    Helper.InforAccountLogin = results;
                    Helper.InforAccountLogin.Password = password;

                    frmLogin.Hide();
                    _frmMain = new FormMain();
                    _frmMain.Show();     
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
            else
            {
                MessageBox.Show("Id and Password cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /*
         * Get Data in appconfig and assign it to txtEmail,txtPassword when checkbox remember = true
         */
        internal void InitData(TextBox txtEmail, TextBox txtPassword, CheckBoxX chkRemember)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.Email))
            {
                if (Properties.Settings.Default.Remmember == "yes")
                {
                    txtPassword.PasswordChar = '*';

                    txtEmail.Text = Properties.Settings.Default.Email;
                    txtPassword.Text = Properties.Settings.Default.Password;
                    chkRemember.Checked = true;
                }
                else
                {
                    txtEmail.Text = Properties.Settings.Default.Email;
                }
            }
        }
        // save data in appconfig when tick checkbox remember
        private void SaveDataToAppconfig(string txtEmail, string txtPassword, CheckBoxX chkRemember)
        {
            if (chkRemember.Checked)
            {
                Properties.Settings.Default.Email = txtEmail;
                Properties.Settings.Default.Password = txtPassword;
                Properties.Settings.Default.Remmember = "yes";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Email = txtEmail;
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remmember = "no";
                Properties.Settings.Default.Save();
            }
        }

        public void ForgetPassword()
        {
            MessageBox.Show("This function is under development");
        }
    }
}
