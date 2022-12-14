using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace _202503024__Mercan_Esen_
{
    public partial class md5_şifreleme : Form
    {
        public md5_şifreleme()
        {
            InitializeComponent();
        }
        public string sqlcon = "Server=localhost\\SQLEXPRESS;Initial Catalog = 202503024; Integrated Security = True";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                richTextBox1.Text = MD5sifrele(textBox1.Text);
            }


        }
        public static string MD5sifrele(string sifrelenecekmetin)
        {
            MD5CryptoServiceProvider md5_şifreleme = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekmetin);

            dizi = md5_şifreleme.ComputeHash(dizi);

            StringBuilder sb = new StringBuilder();

            foreach (byte item in dizi)

            sb.Append(item.ToString("x2").ToLower());
            return sb.ToString();


        }

        private void md5_şifreleme_Load(object sender, EventArgs e)
        {

        }
    }
}
