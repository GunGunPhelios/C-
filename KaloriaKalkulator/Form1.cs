using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaloriaKalkulator
{
    public partial class KaloriaKalkulator : Form
    {
        public KaloriaKalkulator()
        {
            InitializeComponent();
        }

        public static double
        private void KaloriaKalkulator_Load(object sender, EventArgs e)
        {

        }

        public static double ZsirKcalkiszamol(double zsir)
        {
            return zsír *4 ;

             
        }
        public static double Szenhidratkcalszamol(double szénhidrát)
        {
            return szénhidrát * 9;
        }

        public static double Összesitettkcal(double kiszamoltzsír, double kiszamoltszénhidrát)
        {
            return kiszamoltzsír + kiszamoltszénhidrát;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public static List<double> összesítettkcal =new List<double>();
        double zsír;
        zsír=Convert.ToInt32(textBox1.Text);
            double szénhidrát = Convert.ToInt32(textBox2.Text);
        private void button1_Click(object sender, EventArgs e)
        {
            while(zsír>0)
       
            double kiszamoltzsir = ZsirKcalkiszamol(zsír);
            double kiszamoltszénhidrát = Szenhidratkcalszamol(szénhidrát);
            double osszesitett= Összesitettkcal(kiszamoltzsir,kiszamoltszénhidrát);
                

            label6.Text = $"{zsír}g, {kiszamoltzsir} kcal";
            label7.Text = $"{szénhidrát}g, {kiszamoltszénhidrát}kcal";
            label9.Text = $"Az összesített kcal érteke: {osszesitett}";
            összesitettkcal.Add(osszesitett);

            label10.Text = $"Az összesített kalóriak {osszesitettkcal.Count}";






        }
    }
}
