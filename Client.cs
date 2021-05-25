using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DéBUT
{
    class Client
    {
        private string Nom;
        private string Prenom;
        private int Télléphone;
        private string Emaile;
        private string ville;

        public Client(string nom, string prenom, int télléphone, string emaile, string ville)
        {
           this. Nom = nom;
            Prenom = prenom;
            Télléphone = télléphone;
            Emaile = emaile;
            this.ville = ville;
           
        }

        public string Nom1 { get => Nom; set => Nom = value; }
        public string Prenom1 { get => Prenom; set => Prenom = value; }
        public int Télléphone1 { get => Télléphone; set => Télléphone = value; }
        public string Emaile1 { get => Emaile; set => Emaile = value; }
        public string Ville { get => ville; set => ville = value; }
    }
}
