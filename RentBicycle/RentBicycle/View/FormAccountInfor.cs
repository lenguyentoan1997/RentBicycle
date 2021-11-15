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
    public partial class FormAccountInfor : Form
    {
        private AccountInforViewModel _accountInforViewModel;

        public FormAccountInfor()
        {
            _accountInforViewModel = new AccountInforViewModel();

            InitializeComponent();

            this.Load += delegate { _accountInforViewModel.LoadAccountInfor(txtAccountName, picAccountAvatar, txtImgName, txtAccountPhone, dateTimeDOB); };
            btnOpenFile.Click += delegate { _accountInforViewModel.OpenFile(picAccountAvatar, txtImgName); };

            btnAccSave.Click += delegate { _accountInforViewModel.Save(txtAccountName, txtAccOldPass, txtAccNewPass, txtConfirmPass, txtImgName, dateTimeDOB, txtAccountPhone); };

            txtAccNewPass.TextChanged += delegate { _accountInforViewModel.PasswordMatch(txtAccNewPass, txtConfirmPass, txtPassMatch); };
            txtConfirmPass.TextChanged += delegate { _accountInforViewModel.PasswordMatch(txtAccNewPass, txtConfirmPass, txtPassMatch); };
        }

        private void FormAccountInfor_Load(object sender, EventArgs e)
        {
            IntPtr picAvatarIntPtr = NativeMethods.CreateRoundRectRgn(0, 0, picAccountAvatar.Width, picAccountAvatar.Height, 200, 200);
            picAccountAvatar.Region = Region.FromHrgn(picAvatarIntPtr);

        }
    }
}
