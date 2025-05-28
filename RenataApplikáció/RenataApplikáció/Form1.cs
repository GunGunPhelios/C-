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
using System.Globalization;
using System.Text.RegularExpressions;


namespace RenataApplikáció
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTerulet_Click(object sender, EventArgs e)
        {

        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            // Szövegek beolvasása
            string orszag = textBox1.Text.Trim();
            string fovaros = textBox4.Text.Trim();

            // Számok megtisztítása minden nem szám karaktertől
            string teruletStr = Regex.Replace(textBox2.Text, @"[^\d]", "");
            string nepessegStr = Regex.Replace(textBox3.Text, @"[^\d]", "");
            string fovarosLakossagStr = Regex.Replace(textBox5.Text, @"[^\d]", "");

            

            // Megpróbáljuk parse-olni
            bool sikeresTerulet = long.TryParse(teruletStr, out long terulet);
            bool sikeresNepesseg = long.TryParse(nepessegStr, out long nepesseg);
            bool sikeresFovarosLakossag = long.TryParse(fovarosLakossagStr, out long fovarosLakossag);

            if (sikeresTerulet && sikeresNepesseg && sikeresFovarosLakossag)
            {
                if (fovarosLakossag >= nepesseg)
                {
                    lblUzenet.Text = "A főváros lakossága nem lehet több a népességnél!";
                    lblUzenet.ForeColor = Color.Red;
                }
                else
                {
                    string sor = $"{orszag};{terulet};{nepesseg};{fovaros};{fovarosLakossag}";
                    try
                    {
                        File.AppendAllText("ujadat.txt", sor + Environment.NewLine, Encoding.UTF8);
                        lblUzenet.Text = "A mentés sikeres!";
                        lblUzenet.ForeColor = Color.Green;
                    }
                    catch (Exception ex)
                    {
                        lblUzenet.Text = $"Hiba a fájl mentése közben: {ex.Message}";
                        lblUzenet.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                lblUzenet.Text = "Hibás számformátum! (Lehet, hogy nem számot írtál be?)";
                lblUzenet.ForeColor = Color.Red;
            }
        }

    }


}


