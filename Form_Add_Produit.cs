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
    public partial class Form_Add_Produit : Form
    {
        public string[] T = new string[] { "Télephone ", "Pc portable", "Chargeur", "pochette" };
       List<Image> lst = new List<Image>();

        public Form_Add_Produit()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        String F;
        int i = 0,j,Load=0;
        private void button1_Click(object sender, EventArgs e)
        {
            Load++;
            OpenFileDialog OF = new OpenFileDialog();
            DialogResult D = OF.ShowDialog();
            Image I = Image.FromFile(OF.FileName);
            F = OF.FileName;

           if (D == DialogResult.OK)
            //{
            //    if (i < 4)
            //    {
            //        i++;
                    pictureBox1.Image = I;
                    
                  //  lst.Add(I) ;
                    //if (i == 1) { pictureBox2.Image = I; }
                    //if (i == 2) { pictureBox3.Image = I; }
                    //if (i == 3) { pictureBox4.Image = I; }
                    //if (i == 4) { pictureBox5.Image = I; }
                //}else
                //{
                //    MessageBox.Show("Maximume 4 Image . impossible d'ajouter une autre image !!","Attention",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //}
            //}
        }

       
        public void inisialier()
        {
            comboBox1.Text = null;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            pictureBox1.Image = Image.FromFile("../../Resources/traitementPhoto.png");
            pictureBox2.Image = Image.FromFile("../../Resources/traitementPhoto.png");
            pictureBox3.Image = Image.FromFile("../../Resources/traitementPhoto.png");
            pictureBox4.Image = Image.FromFile("../../Resources/traitementPhoto.png");
            pictureBox5.Image = Image.FromFile("../../Resources/traitementPhoto.png");


        }
        public void vidéListe (List<Image>LI)
        {
            for(int i=0;i<LI.Count;i++)
            {
                LI.RemoveAt(i);
                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (Load > 0)// il faux load image pour ajouter le produit
                {
                    Produit P = new Produit(pictureBox1.Image, comboBox1.SelectedItem.ToString(), textBox2.Text, textBox3.Text, int.Parse(textBox4.Text), int.Parse(textBox5.Text));

                    Program.LP.Add(P);
                    MessageBox.Show("Le prouduit a éte ajouter ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Load = 0;
                 //i = 0;
                    inisialier();
                }else
                {
                    MessageBox.Show("il faux Load image pour ajouter le produit ", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
             // vidéListe(lst);
            }

            catch (Exception E )
            {
                MessageBox.Show(E.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //private void pictureBox4_Click_1(object sender, EventArgs e)
        //{
        //  DialogResult D =  MessageBox.Show("voulez-vous supprimer cette image ", pictureBox2.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if(D==DialogResult.Yes)
        //    {

        //   MessageBox.Show(" La supprission avec succée", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //}

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("voulez-vous supprimer cette image ", pictureBox2.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                Supprimer_Image(pictureBox2.Image);
                pictureBox2.Image = null;
                MessageBox.Show(" La supprission avec succée", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Supprimer_Image(Image I)
        {
            foreach(Image Ig in lst)
            {
                if(Ig==I)
                {
                    lst.Remove(Ig);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("voulez-vous supprimer cette image ", pictureBox3.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                Supprimer_Image(pictureBox3.Image);
                pictureBox3.Image = null;

                MessageBox.Show(" La supprission avec succée", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("voulez-vous supprimer cette image ", pictureBox4.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                Supprimer_Image(pictureBox4.Image);

                pictureBox4.Image = null;

                MessageBox.Show(" La supprission avec succée", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      
     

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form_Add_Produit_Shown(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(T);
            pictureBox1.Image = Image.FromFile("../../Resources/traitementPhoto.png");
            pictureBox2.Image = Image.FromFile("../../Resources/traitementPhoto.png");
            pictureBox3.Image = Image.FromFile("../../Resources/traitementPhoto.png");
            pictureBox4.Image = Image.FromFile("../../Resources/traitementPhoto.png");
            pictureBox5.Image = Image.FromFile("../../Resources/traitementPhoto.png");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("voulez-vous supprimer cette image ", pictureBox5.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (D == DialogResult.Yes)
            {
                Supprimer_Image(pictureBox5.Image);

                pictureBox5.Image = null;

                MessageBox.Show(" La supprission avec succée", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
