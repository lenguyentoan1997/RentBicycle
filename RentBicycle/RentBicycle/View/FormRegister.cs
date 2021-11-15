using DevExpress.Utils.Drawing.Helpers;
using RentBicycle.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentBicycle.View
{
    public partial class FormRegister : Form
    {
        private RegisterViewModel _registerViewModel;
        public FormRegister()
        {
            _registerViewModel = new RegisterViewModel();

            InitializeComponent();

            btnRegister.Click += delegate { _registerViewModel.InsertAccount(txtRegisEmail.Text.ToLower().Trim(), txtRegisPass.Text.ToLower().Trim(),this); };
        }

        private void panelRegister_Paint(object sender, PaintEventArgs e)
        {
            IntPtr ptr = NativeMethods.CreateRoundRectRgn(15, 15, btnRegister.Width, btnRegister.Height, 60, 60);
            btnRegister.Region = Region.FromHrgn(ptr);

        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void txtRegisEmail_Enter(object sender, EventArgs e)
        {
            if (txtRegisEmail.Text.Trim() == "Enter Email")
            {
                txtRegisEmail.Text = "";
            }
        }

        private void txtRegisEmail_Leave(object sender, EventArgs e)
        {
            if (txtRegisEmail.Text.Trim() == "")
            {
                txtRegisEmail.Text = "Enter Email";
            }
        }

        private void txtRegisPass_Enter(object sender, EventArgs e)
        {
            if (txtRegisPass.Text.Trim() == "Enter Password")
            {
                txtRegisPass.Text = "";
                txtRegisPass.PasswordChar = '*';
            }
        }

        private void txtRegisPass_Leave(object sender, EventArgs e)
        {

            if (txtRegisPass.Text.Trim() == "")
            {
                txtRegisPass.Text = "Enter Password";
                txtRegisPass.PasswordChar = '\0';
            }
        }
    }
}
