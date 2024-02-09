using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;

namespace PPE2_HOTEL_VVA
{
    public static class Modele_LO_MesReservations
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
        /// Renvoie true si le loisant à min 1 réservation en cours.
        /// </summary>
        /// <returns></returns>
        public static bool ExisteReservation(int unNoLo)
        {
            Modele_LO_MesReservations.Connexion();
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            string reqQuery;
            cmd = connect.CreateCommand();
            reqQuery = "Select * from reservation WHERE NOLOISANT='" + unNoLo.ToString() + "'AND DATE_DEBUT >= CURDATE() AND ETAT_RES='V'";
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
        /// Renvoie la liste des réservations du loisant >= date du jour
        /// </summary>
        /// <returns></returns>
        public static List<Reservation> GetMesReservations(int unNoLo)
        {
            Modele_LO_MesReservations.Connexion();
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            string reqQuery;
            cmd = connect.CreateCommand();
            string etat = "V";
            reqQuery = "Select * from reservation WHERE NOLOISANT='" + unNoLo.ToString() + "'AND DATE_DEBUT >= CURDATE() AND ETAT_RES='"+etat+"'";
            cmd.CommandText = reqQuery;
            rdr = cmd.ExecuteReader();
            List<Reservation> listeMesRes = new List<Reservation>();
            while (rdr.Read())
            {
                int noR = rdr.GetInt32("NO_RES");
                string noL = rdr.GetString("NOLOISANT");
                string noCh = rdr.GetString("NO_CH");
                DateTime dtDeb = rdr.GetDateTime("DATE_DEBUT");
                DateTime dtFin = rdr.GetDateTime("DATE_FIN");
                float mtRes = rdr.GetFloat("MONTANT_RES");
                Reservation res = new Reservation(noR,noCh,dtDeb,dtFin,mtRes);
                listeMesRes.Add(res);
            }
            rdr.Close();
            return listeMesRes;
        }
        /// <summary>
        /// Renvoie true si l'annulation de l'activité a été effectué.(ETAT_RES -> A)
        /// </summary>
        /// <returns></returns>
        public static bool AnnulerReservation(int unNoRes)
        {
            Modele_LO_MesReservations.Connexion();
            MySqlCommand cmd = null;
            string reqI;
            cmd = connect.CreateCommand();
            string etat = "A";
            reqI = "UPDATE reservation SET ETAT_RES='" + etat + "' WHERE NO_RES='"+unNoRes+"'";
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

    }
}
