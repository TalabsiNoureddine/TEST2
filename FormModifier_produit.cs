using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DéBUT
{
    public partial class FormModifier_produit : Form
    {
        Image I;string Catégor, ID, descrp;int stock, prix;
        int indic;
        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult D =MessageBox.Show("voulez-vous modifier cette produit ", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (D == DialogResult.Yes)
            {
                Produit P = new Produit(pictureBox1.Image, comboBox1.Text, textBox2.Text, textBox3.Text, int.Parse(textBox4.Text), int.Parse(textBox5.Text));

                Program.LP[indic]=P;

             //   MessageBox.Show("La Modification avec succée ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
           
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OF = new OpenFileDialog();
            DialogResult D = OF.ShowDialog();
            Image I = Image.FromFile(OF.FileName);
            if (D == DialogResult.OK)
            {
                pictureBox1.Image = I;
            }
        }

        public FormModifier_produit()
        {
            InitializeComponent();
        }
        public FormModifier_produit(int i ,Image Image_Produit1,string Catégorie_Produitn1,string ID_du_produit1,string Description_du_produit1,int Quantité_Stockée1,int Prix_du_produit)
        {
            InitializeComponent();
            indic = i;                                                      
            I = Image_Produit1;
            ID = ID_du_produit1;
            Catégor = Catégorie_Produitn1;
            stock = Quantité_Stockée1;
            prix = Prix_du_produit;
            descrp = Description_du_produit1;

        }

        private void FormModifier_produit_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = I;
            comboBox1.Text = Catégor;
            textBox2.Text = ID;
            textBox3.Text = descrp;
            textBox4.Text = stock.ToString();
            textBox5.Text = prix.ToString();
            
        }
    }
}
