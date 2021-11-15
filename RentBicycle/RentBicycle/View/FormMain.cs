using DevExpress.Utils.Drawing.Helpers;
using RentBicycle.ViewModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RentBicycle.View
{
    public partial class FormMain : Form
    {
        private MainViewModel _mainViewModel;
        private FormIntroduction _frmIntroduction;
        private FormProducts _frmProducts;
        private FormOrders _frmOrders;
        private FormCustomer _frmCustomer;
        private FormAccountInfor _frmAccountInfor;
        private FormAccountManagement _frmAccountManagement;
        private FormDashboard _frmDashboard;
        private FormLogin _frmLogin;

        private bool _isCollapsed = true;

        public FormMain()
        {
            InitializeComponent();

            _mainViewModel = new MainViewModel();
            _frmIntroduction = new FormIntroduction();
            _frmProducts = new FormProducts();
            _frmOrders = new FormOrders();
            _frmCustomer = new FormCustomer();
            _frmAccountInfor = new FormAccountInfor();
            _frmAccountManagement = new FormAccountManagement();
            _frmDashboard = new FormDashboard();
            _frmLogin = new FormLogin();

            this.Load += delegate { _mainViewModel.ShowInforAccountLogin(lblUserName, lblUserRole, picAvatar,btnAccManagement); };

            btnClose.Click += delegate { _mainViewModel.Close(this); };
            btnMinimize.Click += delegate { _mainViewModel.Minimize(this); };
            btnDashboard.Click += delegate { _mainViewModel.OpenChildForm(_frmDashboard, this.panelContent); };
            btnLogo.Click += delegate { _mainViewModel.OpenChildForm(_frmIntroduction, this.panelContent); };
            btnProducts.Click += delegate { _mainViewModel.OpenChildForm(_frmProducts, this.panelContent); };
            btnOrder.Click += delegate { _mainViewModel.OpenChildForm(_frmOrders, this.panelContent); };
            btnCustomer.Click += delegate { _mainViewModel.OpenChildForm(_frmCustomer, this.panelContent); };
            btnLogout.Click += delegate { _mainViewModel.Logout(this,_frmLogin); };
            btnEditAccount.Click += delegate { _mainViewModel.OpenChildForm(_frmAccountInfor, this.panelContent); };
            btnAccManagement.Click += delegate { _mainViewModel.OpenChildForm(_frmAccountManagement, this.panelContent); };
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnLogo.PerformClick();

            //border radius panel image
            IntPtr picAvatarIntPtr = NativeMethods.CreateRoundRectRgn(0, 0, picAvatar.Width, picAvatar.Height, 110, 110);
            picAvatar.Region = Region.FromHrgn(picAvatarIntPtr);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Products Mangement";
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Dashboard";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Orders";
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Customers Mangement";
        }

        private void btnAccountInfor_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Account Information";
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Setting";
        }

        private void btnAccManagement_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Account Management";
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Introduction";
        }

        /*
         * button Cog click
         */
        private void btnCog_Click(object sender, EventArgs e)
        {
            timerPnlSetting.Start();
        }

        private void timerPnlSetting_Tick_1(object sender, EventArgs e)
        {
            if (_isCollapsed)
            {
                pnlSettingDropDown.Height += 10;
                if (pnlSettingDropDown.Size == pnlSettingDropDown.MaximumSize)
                {
                    timerPnlSetting.Stop();
                    _isCollapsed = false;
                }
            }
            else
            {
                pnlSettingDropDown.Height -= 10;
                if (pnlSettingDropDown.Size == pnlSettingDropDown.MinimumSize)
                {
                    timerPnlSetting.Stop();
                    _isCollapsed = true;
                }
            }
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Account Information";
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
