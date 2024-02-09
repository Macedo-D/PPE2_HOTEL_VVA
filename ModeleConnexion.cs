using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Globalization;

namespace PPE2_HOTEL_VVA
{
    public static class ModeleConnexion
    {
        private static MySqlConnection connect = null;

        /// <summary>
        /// Renvoie true si la connection à la base a réussi.
        /// </summary>
        /// <returns></returns>
        public static bool Connexion()
        {
            connect = new MySqlConnection(Properties.Settings.Default.Conn);
            connect.Open();
            if (connect == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Renvoie true si le profil existe.
        /// </summary>
        /// <returns></returns>
        public static bool ExisteProfil(Profil unProfil)
        {
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            string reqQuery;
            cmd = connect.CreateCommand();
            reqQuery = "Select * from profil WHERE USER='" + unProfil.GetUser() + "'AND MDP='" + unProfil.GetMdp()+"'";
            cmd.CommandText = reqQuery;
            rdr = cmd.ExecuteReader();
            bool result;
            if (rdr.Read())
            {
                result = true;
            }
            else
            {
                result = false;
            }
            rdr.Close();
            return result;
        }
        /// <summary>
        /// Renvoie true si le profil existe.
        /// </summary>
        /// <returns></returns>
        public static string GetTypeProfil(Profil unProfil)
        {
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            string reqQuery;
            cmd = connect.CreateCommand();
            reqQuery = "Select TYPEPROFIL from profil WHERE USER='" + unProfil.GetUser() + "'AND MDP='" + unProfil.GetMdp() + "'";
            cmd.CommandText = reqQuery;
            rdr = cmd.ExecuteReader();
            string result;
            rdr.Read();
            result = rdr.GetString("TYPEPROFIL");
            rdr.Close();
            return result;
        }
        /// <summary>
        /// Renvoie la liste des loisants.
        /// </summary>
        /// <returns></returns>
        public static List<Loisant> GetListLoisant()
        {
            ModeleConnexion.Connexion();
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            string reqQuery;
            cmd = connect.CreateCommand();
            reqQuery = "Select * from loisant";
            cmd.CommandText = reqQuery;
            rdr = cmd.ExecuteReader();
            List<Loisant> listeLoisant = new List<Loisant>();
            while (rdr.Read())
            {
                string no = rdr.GetString("NOLOISANT");
                string user = rdr.GetString("USER");
                string nomL = rdr.GetString("NOMLOISANT");
                string prenomL = rdr.GetString("PRENOMLOISANT");
                DateTime dtDebSej = rdr.GetDateTime("DATEDEBSEJOUR");
                DateTime dtFinSej = rdr.GetDateTime("DATEFINSEJOUR");
                string dtNais = rdr.GetString("DATENAISLOISANT");
                int noL = Int32.Parse(no);
                Loisant l = new Loisant(noL, user, nomL, prenomL, dtDebSej, dtFinSej, dtNais);
                listeLoisant.Add(l);
            }

            rdr.Close();
            return listeLoisant;
        }
        /// <summary>
        /// Renvoie la liste des chambres.
        /// </summary>
        /// <returns></returns>
        public static List<Chambre> GetListChambre()
        {
            ModeleConnexion.Connexion();
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            string reqQuery;
            cmd = connect.CreateCommand();
            reqQuery = "Select * from chambre";
            cmd.CommandText = reqQuery;
            rdr = cmd.ExecuteReader();
            List<Chambre> listeChambre = new List<Chambre>();
            while (rdr.Read())
            {
                string numC = rdr.GetString("NO_CH");
                string noCat = rdr.GetString("NO_CAT");
                string etat = rdr.GetString("ETAT");
                string description = rdr.GetString("description");
                Chambre ch = new Chambre(numC,noCat,etat,description);
                listeChambre.Add(ch);
            }

            rdr.Close();
            return listeChambre;
        }
    }
}
