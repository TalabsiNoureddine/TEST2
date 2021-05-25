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
    public partial class Form_image_produit : Form
    {
        int indice; string catégor,UneImage;
       Image LstImg;
     //   List<Image> Lstmg = new List<Image>();
        public Form_image_produit()
        {
            InitializeComponent();
        }
        public Form_image_produit(Image LI,string S)
        {
            InitializeComponent();
            catégor = S;
           LstImg=LI ;
        }

        private void Form_image_produit_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = LstImg;
            label2.Text = catégor;
            //pictureBox1.Image = Lstmg[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //i = 0;
            //pictureBox1.Image = Lstmg[i];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //i = Lstmg.Count-1;
            //pictureBox1.Image = Lstmg[i];
        }
        int i=0;
        private void button3_Click(object sender, EventArgs e)
        {
           
            //if (i < Lstmg.Count-1)
            //{
            //    i ++;
            //    pictureBox1.Image = Lstmg[i];
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (i>0)
            //{
            //    i--;
            //    pictureBox1.Image = Lstmg[i];
            //}
        }
    }
}
