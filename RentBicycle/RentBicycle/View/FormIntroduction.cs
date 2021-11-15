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
    public partial class FormIntroduction : Form
    {
        public FormIntroduction()
        {
            InitializeComponent();

            timerNow.Start();
        }

        private void timerNow_Tick(object sender, EventArgs e)
        {
            lblDatetime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
