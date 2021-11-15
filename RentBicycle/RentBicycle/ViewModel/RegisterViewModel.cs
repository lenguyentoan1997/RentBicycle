using RentBicycle.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentBicycle.ViewModel
{
    class RegisterViewModel
    {
        private RentBicycleEntities _database;

        public RegisterViewModel() => _database = new RentBicycleEntities();

        public void InsertAccount(string email, string password,Form form)
        {
            try
            {
                _database.usp_RegisterAccount(email, Helper.EncryptMD5(password));
                if (MessageBox.Show("Register Success", "Notification", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    form.Close();
                };
            }
            catch 
            {
                MessageBox.Show("Email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
