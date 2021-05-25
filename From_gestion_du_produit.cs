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
    public partial class From_gestion_du_produit : Form
    {
        public From_gestion_du_produit()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        DataRow dr;
        public void Datagrid()
        {
            DataColumn dc = new DataColumn("ID Produit", typeof(string));
            dt.Columns.Add(dc);
            DataColumn dc1 = new DataColumn("Catégorie", typeof(string));
            dt.Columns.Add(dc1);
            DataColumn dc2 = new DataColumn("Déscription du Produit", typeof(string));
            dt.Columns.Add(dc2);
            DataColumn dc3 = new DataColumn("Quantité Stockée", typeof(int));
            dt.Columns.Add(dc3);
            DataColumn dc4 = new DataColumn("Prix Produit", typeof(float));
            dt.Columns.Add(dc4);

            foreach (Produit P in Program.LP)
            {
                dr = dt.NewRow();
                dr[0] = P.ID_du_produit1;
                dr[1] = P.Catégorie_Produitn1;
                dr[2] = P.Description_du_produit1;
                dr[3] = P.Quantité_Stockée1;
                dr[4] = P.Prix_du_produit;
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
        }
        private void From_gestion_du_produit_Load(object sender, EventArgs e)
        {
            Datagrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Selected==true)
            {
                for (int i = 0; i < Program.LP.Count;i++)
                {
                    if (i == dataGridView1.CurrentRow.Index)
                    {
                       // button2.Text = i.ToString();
                        // pictureBox1.Image = Image.FromFile(Program.LP[i].Image_Produit1);
                        Form_image_produit FIP = new Form_image_produit(Program.LP[i].Image_Produit1, Program.LP[i].Description_du_produit1);
                        FIP.ShowDialog();
                        break;
                    }
                
                }
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="")
            {
                int j = -1;
                for (int i = 0; i < Program.LP.Count; i++)
                {
                    dataGridView1.Rows[i].Selected = false;
                    if (Program.LP[i].ID_du_produit1 == (textBox1.Text))
                    {
                        dataGridView1.Rows[i].Selected = true;
                        j = 1;
                        break;
                    }
                }
                if (j < 0)
                {
                    MessageBox.Show("Le prouduit n'existe pas ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.LP.Count; i++)
            {
                if (i == dataGridView1.Rows[i].Index)
                {

                  //  Produit P = new Produit();
                    FormModifier_produit FM = new FormModifier_produit( i,Program.LP[i].Image_Produit1, Program.LP[i].Catégorie_Produitn1, Program.LP[i].ID_du_produit1, Program.LP[i].Description_du_produit1, Program.LP[i].Quantité_Stockée1, Program.LP[i].Prix_du_produit);
                   
                    FM.ShowDialog();
                    //il a un petite probléme ,ce que je close la page il doit modifier automtiqument les évinmment ??
                    //if (DialogResult.Cancel == FM.DialogResult)
                    //{

                    //    Datagrid();
                    //}
                    break;
                   
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult D = MessageBox.Show("voulez-vous supprimer ? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (DialogResult.Yes == D)
                {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
            }

        private void button5_Click(object sender, EventArgs e)
        {
            Form_Add_Produit FAP = new Form_Add_Produit();
            FAP.ShowDialog();
        }
    }
}
