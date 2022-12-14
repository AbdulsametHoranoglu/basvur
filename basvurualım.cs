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
namespace _202503024__Mercan_Esen_
{
    public partial class basvurualım : Form
    {
        public basvurualım()
        {
            InitializeComponent();
        }
     
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        

        private void button1_Click(object sender, EventArgs e)
        {
 
            formkurs fr3 = new formkurs();
            fr3.ShowDialog();
        }
        

    }
}
