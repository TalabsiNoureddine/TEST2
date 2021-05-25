using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DéBUT
{
    [Serializable]

    class Utilisateur
    {
        private string nom_Comlpet_utilisateur;
        private string mot_passe;
        private string type_utilisateur;

        public Utilisateur(string nom_Comlpet_utilisateur, string mot_passe, string type_utilisateur)
        {
            this.nom_Comlpet_utilisateur = nom_Comlpet_utilisateur;
            this.mot_passe = mot_passe;
            this.type_utilisateur = type_utilisateur;
        }

        public string Nom_Comlpet_utilisateur { get => nom_Comlpet_utilisateur; set => nom_Comlpet_utilisateur = value; }
        public string Mot_passe { get => mot_passe; set => mot_passe = value; }
        public string Type_utilisateur { get => type_utilisateur; set => type_utilisateur = value; }
    }
}
