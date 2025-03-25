using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ital_Vásárló
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string termek= textBox1.Text;
            double db = Convert.ToInt32(textBox2.Text);
            double ar = Convert.ToInt32(textBox3.Text);

            double fizetendo = db * ar;

            label5.Text = $"A termék: {termek}, a mennyiség: {db}, a fizetendő összeg: {fizetendo}";




        }
    }
}
