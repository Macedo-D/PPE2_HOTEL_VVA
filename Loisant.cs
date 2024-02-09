using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE2_HOTEL_VVA
{
    public class Loisant
    {
        private int noL;
        private string user;
        private string nomL;
        private string prenomL;
        private DateTime dateDebSej;
        private DateTime dateFinSej;
        private string dateNaisL;

        public Loisant()
        {
        }
        public Loisant(int unNo, string unUser, string unNom, string unPrenom, DateTime uneDtDeb, DateTime uneDtFin, string uneDateNais)
        {
            this.noL = unNo;
            this.user = unUser;
            this.nomL = unNom;
            this.prenomL = unPrenom;
            this.dateDebSej = uneDtDeb;
            this.dateFinSej = uneDtFin;
            this.dateNaisL = uneDateNais;
        }
        public int GetNoL()
        {
            return noL;
        }
        public void SetNoL(int unNo)
        {
            this.noL = unNo;
        }
        public string GetUser()
        {
            return user;
        }
        public string GetNom()
        {
            return nomL;
        }
        public string GetPrenom()
        {
            return prenomL;
        }
        public DateTime GetdtDebSej()
        {
            return dateDebSej;
        }
        public DateTime GetdtFinSej()
        {
            return dateFinSej;
        }
        public string GetdtNais()
        {
            return dateNaisL;
        }
        public void SetUser(string unUser)
        {
            this.user = unUser;
        }
        public override string ToString()
        {
            return "Loisant : N°" + noL + " ; user : " + user + "; nom : " + nomL + "; prenom : " + prenomL + "; Date début séjour : "+dateDebSej+"; Date fin séjour : "+dateFinSej+"; Date de naissance : "+dateNaisL;
        }

    }
}
