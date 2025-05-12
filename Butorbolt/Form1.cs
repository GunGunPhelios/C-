using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butorbolt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<butorbolt> butorok = new List<butorbolt>();
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] sorok = File.ReadAllLines("butorbolt.txt");
            foreach(string s in sorok)
            {
                string[] adatok = s.Split(';');
                butorbolt butor = new butorbolt(adatok[0], adatok[1], adatok[2], adatok[3], adatok[4]);
                butorok.Add(butor);

            }

            foreach (var b in butorok)
            {
                dataGridView1.Rows.Add(b.kategoria,b.termeknev,b.ar,b.raktar_db,b.eladott_db);
                if(!comboBox1.Items.Contains(b.kategoria))
                {
                    comboBox1.Items.Add(b.kategoria);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int legdragabb = 0;
            string legdragabbnev = "";
            foreach(var b in butorok)
            {
                int bevetel = b.ar*b.eladott_db;
                if(bevetel> legdragabb)
                {
                    legdragabb = bevetel;
                    legdragabbnev = b.termeknev;

                    
                }

                dataGridView2.Rows.Add(b.termeknev,bevetel);

            }
          label1.Text=($"A legdrágább termék: {legdragabbnev}, ar: {legdragabb}");
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (var b in butorok)
            {


                if (b.kategoria == comboBox1.SelectedItem.ToString())
                {
                    listBox1.Items.Add(b.termeknev);

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
