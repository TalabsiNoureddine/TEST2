using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace DéBUT
{
    [Serializable]
    class Produit
    {
        private string Catégorie_Produitn;
        private string ID_du_produit;
        private  string Description_du_produit ;
        private int Quantité_Stockée;
        private int prix_du_produit;
        private Image Image_Produit;
      //  private List<Image> Image_Produit = new List<Image>();

        public Produit(Image Image,string catégorie_Produitn, string iD_du_produit, string description_du_produit, int quantité_Stockée, int prix_du_produit)
        {
           this. Catégorie_Produitn = catégorie_Produitn;
           this. ID_du_produit = iD_du_produit;
          this.  Description_du_produit = description_du_produit;
          this.  Quantité_Stockée = quantité_Stockée;
          this.prix_du_produit = prix_du_produit;
            Image_Produit = Image;
        }

        public string Catégorie_Produitn1 { get => Catégorie_Produitn; set => Catégorie_Produitn = value; }
        public string ID_du_produit1 { get => ID_du_produit; set => ID_du_produit = value; }
        public string Description_du_produit1 { get => Description_du_produit; set => Description_du_produit = value; }
        public int Quantité_Stockée1 { get => Quantité_Stockée; set => Quantité_Stockée = value; }
        public int Prix_du_produit { get => prix_du_produit; set => prix_du_produit = value; }
        public Image Image_Produit1 { get => Image_Produit; set => Image_Produit = value; }
        // private Image;

        //public override string ToString()
        //{
        //    return 
        //}
    }
}
