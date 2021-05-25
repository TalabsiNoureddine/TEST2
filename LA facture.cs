using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DéBUT
{
    [Serializable]
    class LA_facture :Client 
    {
        private int numéro_du_facture;
        private string déscription_du_facture;
        private DateTime la_date_de_la_vente ;
        private string nom_du_vendeur;

        public LA_facture(string a, string b ,int c ,string d , string e , int numéro_du_facture, string déscription_du_facture, DateTime la_date_de_la_vente, string nom_du_vendeur) :base(a,b,c,d,e)
        {
            this.numéro_du_facture = numéro_du_facture;
            this.déscription_du_facture = déscription_du_facture;
            this.la_date_de_la_vente = la_date_de_la_vente;
            this.nom_du_vendeur = nom_du_vendeur;
        }

        public int Numéro_du_facture { get => numéro_du_facture; set => numéro_du_facture = value; }
        public string Déscription_du_facture { get => déscription_du_facture; set => déscription_du_facture = value; }
        public DateTime La_date_de_la_vente { get => la_date_de_la_vente; set => la_date_de_la_vente = value; }
        public string Nom_du_vendeur { get => nom_du_vendeur; set => nom_du_vendeur = value; }
    }
}
