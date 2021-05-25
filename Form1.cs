using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DéBUT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forme_seconnecter FC = new Forme_seconnecter();
            FC.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_Add_Produit FAP = new Form_Add_Produit();
            FAP.ShowDialog();
        }
    

        private void button7_Click(object sender, EventArgs e)
        {
            From_gestion_du_produit FGP = new From_gestion_du_produit();
            FGP.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("../../Sauv-Les-produit.dat"))
            {
                FileStream fl = new FileStream("../../Sauv-Les-produit.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter x = new BinaryFormatter();
                List<Produit> ListeP = (List<Produit>)x.Deserialize(fl);
                foreach(Produit P in ListeP)
                {
                    Program.LP.Add(P);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter B = new BinaryFormatter();

                FileStream fl = new FileStream("../../Sauv-Les-produit.dat", FileMode.Append, FileAccess.Write);
                B.Serialize(fl, Program.LP);

                fl.Close();
                MessageBox.Show("Les information   a été Sauvgarder");
            }catch(Exception E)
            {

            }
        }
    }
}
