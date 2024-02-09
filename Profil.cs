using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE2_HOTEL_VVA
{
    public class Profil
    {
        private string user;
        private string mdp;
        private string typeProfil;

        public Profil()
        {
        }
        public Profil(string unUser, string unMdp, string unTypeP)
        {
            this.user = unUser;
            this.mdp = unMdp;
            this.typeProfil = unTypeP;
        }
        public Profil(string unUser, string unMdp)
        {
            this.user = unUser;
            this.mdp = unMdp;
        }
        public string GetUser()
        {
            return user;
        }
        public void SetUser(string unUser)
        {
            this.user = unUser;
        }
        public string GetMdp()
        {
            return mdp;
        }
        public string GetTypeP()
        {
            return typeProfil;
        }
        public void SetTypeP(string unTypeP)
        {
            this.typeProfil=unTypeP;
        }
    }
}
