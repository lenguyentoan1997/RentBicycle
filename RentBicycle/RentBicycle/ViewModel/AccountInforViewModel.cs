using DevComponents.Editors.DateTimeAdv;
using RentBicycle.Model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RentBicycle.ViewModel
{
    class AccountInforViewModel
    {
        private RentBicycleEntities _database;
        private string _sourceFileName { get; set; }
        private bool _isPassMatch = false;

        public AccountInforViewModel() => _database = new RentBicycleEntities();

        public void LoadAccountInfor(TextBox txtAccountName, PictureBox picAccountAvatar, TextBox txtImgName, TextBox txtAccontPhone, DateTimeInput dob)
        {
            txtAccountName.Text = Helper.InforAccountLogin.Name;
            txtAccontPhone.Text = Helper.InforAccountLogin.Phone;
            dob.Text = Helper.InforAccountLogin.DOB.ToString();

            if (Helper.InforAccountLogin.Avatar != null)
            {
                picAccountAvatar.Image = Image.FromFile(Helper.GetPathImg(Helper.InforAccountLogin.Avatar));
                txtImgName.Text = Helper.InforAccountLogin.Avatar;
            }
        }

        public void OpenFile(PictureBox picProduct, TextBox txtImgName)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Img Format(*.jpg)|*.jpg|Img Format(*.png)|*.png";
            openFileDialog.ShowDialog();

            if (!string.IsNullOrEmpty(openFileDialog.FileName))
            {
                string filePath = openFileDialog.FileName;
                _sourceFileName = filePath;

                //Load Img to PictureBox
                picProduct.Image = Image.FromFile(filePath);
                //Load ImgName to TextBox
                txtImgName.Text = Helper.GetImgName(filePath);
            }
        }

        public void PasswordMatch(TextBox txtNewPassword, TextBox txtConfirmPassword, TextBox txtPasswordMatch)
        {
            string newPassword = txtNewPassword.Text;
            string oldPassword = txtConfirmPassword.Text;

            if (!string.IsNullOrEmpty(newPassword) && !string.IsNullOrEmpty(oldPassword))
            {
                if (newPassword == oldPassword)
                {
                    txtPasswordMatch.Text = "Password Match";
                    _isPassMatch = true;
                }
                else
                {
                    txtPasswordMatch.Text = "Password Not Match";
                    _isPassMatch = false;
                }
            }
            else
            {
                _isPassMatch = false;
            }

        }

        public void Save(TextBox txtAccountName, TextBox txtAccoutOldPass, TextBox txtAccountNewPass, TextBox txtConfirmPassword, TextBox txtImgName, DateTimeInput dob, TextBox txtAccountPhone)
        {
            if (MessageBox.Show("Do You want to Save", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtAccoutOldPass.Text) && string.IsNullOrEmpty(txtConfirmPassword.Text))
                {
                    if (!string.IsNullOrEmpty(txtAccountName.Text) && !string.IsNullOrEmpty(txtImgName.Text))
                    {
                        //Coppy Img to Folder Asset
                        if (!string.IsNullOrEmpty(_sourceFileName) && _sourceFileName != Helper.InforAccountLogin.Avatar)
                        {
                            string imgName = Helper.GetImgName(_sourceFileName);
                            string fullFilePathImg = Path.Combine(Helper.GetPathFolderAsset(), imgName);
                            //Check if the image already exists in the file
                            if (!File.Exists(fullFilePathImg))
                            {
                                File.Copy(_sourceFileName, fullFilePathImg);
                            }
                        }

                        DateTime dobUser = dob.Value;
                        _database.usp_UpdateAccount(Helper.InforAccountLogin.Id, txtAccountName.Text, txtImgName.Text, dobUser, txtAccountPhone.Text);
                        MessageBox.Show("Save Sucess", "Notification");
                    }
                    else
                    {
                        MessageBox.Show("Name Or Avatar Cannot be left blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(txtAccoutOldPass.Text) && !string.IsNullOrEmpty(txtAccountNewPass.Text) && !string.IsNullOrEmpty(txtConfirmPassword.Text))
                    {
                        if (txtAccoutOldPass.Text == Helper.InforAccountLogin.Password)
                        {
                            if (_isPassMatch)
                            {
                                _database.usp_UpdatePassword(Helper.InforAccountLogin.Id, Helper.EncryptMD5(txtConfirmPassword.Text));

                                txtAccoutOldPass.Text = string.Empty;
                                txtAccountNewPass.Text = string.Empty;
                                txtConfirmPassword.Text = string.Empty;

                                MessageBox.Show("Save Sucess", "Notification");
                            }
                            else
                            {
                                MessageBox.Show("Confirm Password Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Old Password is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fields Password cannot be left blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
           

        }
    }
}
