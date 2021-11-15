using DevComponents.DotNetBar;
using RentBicycle.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentBicycle.ViewModel
{
    class MainViewModel
    {
        public void Close(Form form)
        {
            if (MessageBox.Show("Do you want to exit", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        public void Minimize(Form form) => form.WindowState = FormWindowState.Minimized;

        public void OpenChildForm(Form childForm, Panel panelContent)
        {
            //setting property childForm
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            //panelContent display childForm
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void ShowInforAccountLogin(LabelX lblUserName, LabelX lblUserRole, PictureBox picAvatar,Button btnAccountManagement)
        {
            if (Helper.InforAccountLogin.Role.ToLower() == "admin")
            {
                btnAccountManagement.Show();
            }
            else
            {
                btnAccountManagement.Hide();
            }
            lblUserRole.Text = Helper.InforAccountLogin.Role;

            if (!string.IsNullOrEmpty(Helper.InforAccountLogin.Name) && !string.IsNullOrEmpty(Helper.InforAccountLogin.Avatar))
            {
                lblUserName.Text = Helper.InforAccountLogin.Name;
                picAvatar.Image = Image.FromFile(Helper.GetPathImg(Helper.InforAccountLogin.Avatar));
            }
            else
            {
                MessageBox.Show("Please Update Information Account", "Notification");
            }

        }

        public void Logout(Form frmMain , Form formLogin)
        {
            if (MessageBox.Show("Do You Want To Logout", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Helper.InforAccountLogin = null;
                frmMain.Hide();
                formLogin.Show();
            }              
        }


    }
}
