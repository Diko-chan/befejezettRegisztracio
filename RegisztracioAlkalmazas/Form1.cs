using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SaveButton.Click += (sender, e) =>
            {
                Mentes();

                //MessageBox.Show(FavListBox.Text);
                //FavListBox.Items.Count;
                
                //MessageBox.Show(tmp);
                
            };
            OpenButton.Click += (sender, e) =>
            {
                Megnyitas();
            };
            NewHobbyButton.Click += (sender, e) =>
            {
                Hozzaad();
            };
        }
        private string adatok()
        {
            string nev = NameBox.Text;
            string ev = AgeBox2.Text;
            string nem = null;
            if (FemaleRadioButton.Checked)
            {
                nem = "Nő";    
            }
            else
            {
                nem = "férfi";
            }
            string kedvenclista = FavListBox.Text;
            string osszeslista = "";
            for (int i = 0; i < FavListBox.Items.Count; i++)
            {
                osszeslista += FavListBox.Items[i]+",";
            }



            string tmp = String.Format("{0};{1};{2};{3};{4}", nev, ev, nem, kedvenclista,osszeslista);
            return tmp;
        }
        private void Mentes()
        {
            var eredmeny = saveFileDialog1.ShowDialog(this);
            if (eredmeny == DialogResult.OK)
            {
                string fileNev = saveFileDialog1.FileName;
                using (var file = File.CreateText(fileNev))
                {
                    file.Write(adatok());
                }
            }
        }
        private void Megnyitas()
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                string tartalom = File.ReadAllText(openFileDialog1.FileName);
                string[] reszek = tartalom.Split(';');
                string nev = reszek[0];
                NameBox.Text = nev;
                string ev = reszek[1];
                AgeBox2.Text = ev;

                if (reszek[2] == "Nő") {
                    FemaleRadioButton.PerformClick();

                }
                else if (reszek[2] == "férfi")
                { MaleRadioButton.PerformClick(); }
                string lista = reszek[3];
                

                string[] kedvenc = reszek[4].Split(',');
                for (int i = 0; i < kedvenc.Length; i++)
                {
                    FavListBox.Items.Add(kedvenc[i]);

                    

                }
               FavListBox.SelectedItem = lista;


            }

        }
        private void Hozzaad()
        {
            FavListBox.Items.Add(NewHobbiBox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
