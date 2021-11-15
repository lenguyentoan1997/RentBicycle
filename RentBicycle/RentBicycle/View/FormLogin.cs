using DevExpress.Utils.Drawing.Helpers;
using RentBicycle.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentBicycle.View
{
    public partial class FormLogin : Form
    {
        private LoginViewModel _loginViewModel;
        public FormLogin()
        {
            InitializeComponent();

            _loginViewModel = new LoginViewModel();

            _loginViewModel.InitData(txtEmail,txtPassword,chkRemember);

            lblRegister.Click += delegate { _loginViewModel.OpenFormRegister(); };
            btnLogin.Click += delegate { _loginViewModel.Login(txtEmail.Text.ToLower().Trim(), txtPassword.Text.ToLower().Trim(),this,chkRemember); };
            lblForgotPassword.Click += delegate { _loginViewModel.ForgetPassword(); };
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {
            //Border radius panel Login
            IntPtr ptrPanelLogin = NativeMethods.CreateRoundRectRgn(15, 15, panelLogin.Width, panelLogin.Height, 40, 40);
            panelLogin.Region = Region.FromHrgn(ptrPanelLogin);

            IntPtr ptrBtnLogin = NativeMethods.CreateRoundRectRgn(15, 15, btnLogin.Width, btnLogin.Height, 60, 60);
            btnLogin.Region = Region.FromHrgn(ptrBtnLogin);

        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "Enter Email")
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
            {
                txtEmail.Text = "Enter Email";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "Enter Password")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Trim() == "")
            {
                txtPassword.Text = "Enter Password";
                txtPassword.PasswordChar = '\0';
            }
        }
    }
}
