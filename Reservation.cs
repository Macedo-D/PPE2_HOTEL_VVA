using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE2_HOTEL_VVA
{
    public class Reservation
    {
        private int noR;
        private int noL;
        private string noCh;
        private DateTime dtDeb;
        private DateTime dtFin;
        private float mtRes;

        public Reservation(int unNoR, string unNoCh, DateTime uneDtDeb, DateTime uneDtFin, float unMtRes)
        {
            this.noR = unNoR;
            this.noCh= unNoCh;
            this.dtDeb = uneDtDeb;
            this.dtFin = uneDtFin;
            this.mtRes = unMtRes;
        }
        public Reservation(int unNoR, int unNoL, string unNoCh, DateTime uneDtDeb, DateTime uneDtFin, float unMtRes)
        {
            this.noR = unNoR;
            this.noL = unNoL;
            this.noCh = unNoCh;
            this.dtDeb = uneDtDeb;
            this.dtFin = uneDtFin;
            this.mtRes = unMtRes;
        }
        public int GetNoR()
        {
            return noR;
        }
        public int GetNoL()
        {
            return noL;
        }
        public string GetNoCh()
        {
            return noCh;
        }
        public float GetMontantRes()
        {
            return mtRes;
        }
        public override string ToString()
        {
            return "Réservation n°" + noR + ", Chambre n°" + noCh + ", date de début :" + dtDeb.ToString("yyyy/MM/dd") + ", date de fin :" + dtFin.ToString("yyyy/MM/dd") + ", montant:" + mtRes;
        }
    }
}
