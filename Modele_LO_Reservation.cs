using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;

namespace PPE2_HOTEL_VVA
{
    public static class Modele_LO_Reservation
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
        /// Renvoie true si une chambre est disponible pour la catégorie voulue.
        /// </summary>
        /// <returns></returns>
        public static bool ExisteChambre(string uneCategorieChambre)
        {
            Modele_LO_Reservation.Connexion();
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            string reqQuery;
            cmd = connect.CreateCommand();
            reqQuery = "Select * from chambre WHERE NO_CAT='" + uneCategorieChambre + "'AND ETAT='V'";
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
        /// Renvoie la liste des suppléments disponibles.
        /// </summary>
        /// <returns></returns>
        public static ArrayList GetNomSupp()
        {
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            string reqQuery;
            cmd = connect.CreateCommand();
            reqQuery = "Select * from type_supplement";
            cmd.CommandText = reqQuery;
            rdr = cmd.ExecuteReader();
            ArrayList supp = new ArrayList();
            while (rdr.Read())
            {
                supp.Add(rdr.GetString("NOMTYPESUP"));
            }
            rdr.Close();
            return supp;
        }
        /// <summary>
        /// Renvoie le tarif/jours en fonction de la categorie choisie.
        /// </summary>
        /// <returns></returns>
        public static float GetTarifJ(string uneCategorieChambre)
        {
            Modele_LO_Reservation.Connexion();
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            string reqQuery;
            cmd = connect.CreateCommand();
            reqQuery = "Select TARIF_JOUR from categorie WHERE NO_CAT='" + uneCategorieChambre + "'";
            cmd.CommandText = reqQuery;
            rdr = cmd.ExecuteReader();
            float result;
            rdr.Read();
            result = rdr.GetFloat("TARIF_JOUR");
            rdr.Close();
            return result;
        }
        /// <summary>
        /// Renvoie le tarif du supplément choisie.
        /// </summary>
        /// <returns></returns>
        public static float GetTarifSupp(string supp)
        {
            Modele_LO_Reservation.Connexion();
            MySqlCommand cmd = null;
            MySqlDataReader rdr = null;
            string reqQuery;
            cmd = connect.CreateCommand();
            reqQuery = "SELECT SUM(TARIF) as ta FROM supplement S,type_supplement TS WHERE S.CODETYPESUP=TS.CODETYPESUP AND TS.NOMTYPESUP='"+supp+"'";
            cmd.CommandText = reqQuery;
            rdr = cmd.ExecuteReader();
            float result;
            rdr.Read();
            result = rdr.GetFloat("ta");
            rdr.Close();
            return result;
        }
        /// <summary>
        /// Renvoie true si reservation ok.
        /// </summary>
        /// <returns></returns>
        public static bool AddReservation(int unNoLo, string unNoCh, string uneDtDeb, string uneDtFin, double unMtRes)
        {
            Modele_LO_Reservation.Connexion();
            MySqlCommand cmd = null;
            string reqI;
            cmd = connect.CreateCommand();
            string etat = "V";
            reqI = "INSERT INTO reservation(NOLOISANT,NO_CH,ETAT_RES,DATE_DEBUT,DATE_FIN,MONTANT_RES) VALUES('"+unNoLo+"','"+unNoCh+"','"+ etat +"','"+uneDtDeb+"','"+uneDtFin+"','"+unMtRes+"')";
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
        /// Renvoie true si la modification de l'etat de la chambre a été effectué.
        /// </summary>
        /// <returns></returns>
        public static bool ModifEtatChambre(string unNoCh,string unNvEtat)
        {
            Modele_LO_Reservation.Connexion();
            MySqlCommand cmd = null;
            string reqI;
            cmd = connect.CreateCommand();
            reqI = "UPDATE chambre SET ETAT='" + unNvEtat + "' WHERE NO_CH='" + unNoCh + "'";
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
