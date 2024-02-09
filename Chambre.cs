using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE2_HOTEL_VVA
{
    public class Chambre
    {
        private string num;
        private string categorie;
        private string etat;
        private string description;

        public Chambre(string unNum, string uneCat, string unEtat, string uneDes)
        {
            this.num = unNum;
            this.categorie = uneCat;
            this.etat = unEtat;
            this.description = uneDes;
        }
        public string GetNum()
        {
            return num;
        }
        public string GetCategorie()
        {
            return categorie;
        }
        public string GetEtat()
        {
            return etat;
        }
    }
}
