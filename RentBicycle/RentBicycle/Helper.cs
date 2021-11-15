using RentBicycle.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RentBicycle
{
    public class Helper
    {
        /*
         * Handle file or directory path
         */
        public static string GetPathFolderAsset()
        {
            string workDirectory = Environment.CurrentDirectory;
            string pathFolder = Directory.GetParent(workDirectory).Parent.FullName + "\\Asset\\Img";

            return pathFolder;
        }

        public static string GetPathImg(string imgName)
        {
            var pathImg = Path.Combine(GetPathFolderAsset(), imgName);

            return pathImg;
        }

        /*
         * Handle Image
         */
        //Get image name From file path
        public static string GetImgName(string filePath)
        {
            string imgName = filePath.Substring(filePath.LastIndexOf(@"\")).Remove(0, 1);

            return imgName;
        }

        internal static usp_Login_Result InforAccountLogin { get; set; }

        /*
         * password encryption MD5
         */
        internal static string EncryptMD5(string password)
        {
            StringBuilder passEncrypMD5 = new StringBuilder();

            //encryption MD5
            var bytes = MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(password));

            for (int i = 0; i < bytes.Length; i++)
            {
                passEncrypMD5.Append(bytes[i].ToString());
            }

            return passEncrypMD5.ToString();
        }
    }
}
