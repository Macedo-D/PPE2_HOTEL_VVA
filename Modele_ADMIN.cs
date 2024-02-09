using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;

namespace PPE2_HOTEL_VVA
{
    public static class Modele_ADMIN
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
        /// Renvoie la liste des réservations de l'hôtel >= date du jour
        /// </summary>
        /// <returns></returns>
        public static List<Reservation> GetReservations()
        {
            Modele_ADMIN.Connexion();
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            string reqQuery;
            cmd = connect.CreateCommand();
            string etat = "V";
            reqQuery = "Select * from reservation WHERE DATE_DEBUT >= CURDATE() AND ETAT_RES='" + etat + "'";
            cmd.CommandText = reqQuery;
            rdr = cmd.ExecuteReader();
            List<Reservation> listeRes = new List<Reservation>();
            while (rdr.Read())
            {
                int noR = rdr.GetInt32("NO_RES");
                int noL = rdr.GetInt32("NOLOISANT");
                string noCh = rdr.GetString("NO_CH");
                DateTime dtDeb = rdr.GetDateTime("DATE_DEBUT");
                DateTime dtFin = rdr.GetDateTime("DATE_FIN");
                float mtRes = rdr.GetFloat("MONTANT_RES");
                Reservation res = new Reservation(noR,noL,noCh, dtDeb, dtFin, mtRes);
                listeRes.Add(res);
            }
            rdr.Close();
            return listeRes;
        }
        /// <summary>
        /// Renvoie l'ajout de la chambre a été effectué avec succès.
        /// </summary>
        /// <returns></returns>
        public static bool AddChambre(string unNoCh, string unNoCat, string unEtat, string uneDescrip)
        {
            MySqlCommand cmd = null;
            string reqI;
            cmd = connect.CreateCommand();
            reqI = "INSERT INTO chambre(NO_CH, NO_CAT, ETAT, description) VALUES('"+unNoCh+"','"+unNoCat+"','"+unEtat+"','"+uneDescrip+"')";
            cmd.CommandText = reqI;
            bool result;
            int nbMaj = cmd.ExecuteNonQuery();
            if (nbMaj > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        /// <summary>
        /// Renvoie true si le No de la chambre est déjà pris
        /// </summary>
        /// <returns></returns>
        public static bool ExisteNoChambre(string unNoCh)
        {
            Modele_LO_Reservation.Connexion();
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            string reqQuery;
            cmd = connect.CreateCommand();
            reqQuery = "Select NO_CH from chambre WHERE NO_CH='" + unNoCh + "'";
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
    }
}
