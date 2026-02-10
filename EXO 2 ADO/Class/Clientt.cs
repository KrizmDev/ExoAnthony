using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO_2_ADO.Class
{
    internal class Clientt
    {
        public int id { get ; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adresse { get; set; }
        public string codePostal { get; set; }
        public string ville { get; set; }
        public string tel { get; set; }


        public Clientt(int Id , string Nom , string Prenom , string Adresse , string CodePostal,string Ville,string Tel)
        {
            id = Id;
            nom = Nom;
            prenom = Prenom;
            adresse = Adresse;
            codePostal = CodePostal;
            tel = Tel;

        }

        public override string ToString()
        {
            return $"{id} {nom} {prenom} {adresse} {codePostal} {tel}";
        }
    }
}
