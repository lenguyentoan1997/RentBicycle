using RentBicycle.Model;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RentBicycle.ViewModel
{
    public class ProductViewModel
    {
        private RentBicycleEntities database;
        public ProductViewModel() => database = new RentBicycleEntities();
        public BindingSource ProductBidingSource { get; set; }
        private string _sourceFileName { get; set; }

        /*
         * Load datagridview
         */
        public void Load()
        {
            //Get data table Products from db
            database.Products.Load();
            //data transmission in ProductBidingSource
            ProductBidingSource.DataSource = database.Products.Local.ToBindingList();
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

        public void Add() => ProductBidingSource.AddNew();

        public void Delete()
        {
            if (MessageBox.Show("Do you want to Delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProductBidingSource.RemoveCurrent();
            }
        }

        public void Save()
        {
            if (MessageBox.Show("Do you want to save", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProductBidingSource.EndEdit();

                if (!string.IsNullOrEmpty(_sourceFileName))
                {
                    string imgName = Helper.GetImgName(_sourceFileName);
                    string fullFilePathImg = Path.Combine(Helper.GetPathFolderAsset(), imgName);
                    //Check if the image already exists in the file
                    if (!File.Exists(fullFilePathImg))
                    {
                        File.Copy(_sourceFileName, fullFilePathImg);
                    }
                }

                database.SaveChanges();
                MessageBox.Show("Save Successfull", "Notification", MessageBoxButtons.OK);
            }

        }


        //Load img product to PirctureBox from Datagridview
        public void LoadImgProduct(TextBox txtImgName, PictureBox picProduct)
        {
            if (!string.IsNullOrEmpty(txtImgName.Text))
            {
                picProduct.Image = Image.FromFile(Helper.GetPathImg(txtImgName.Text));
            }
        }
    }
}
