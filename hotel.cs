using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace PPE2_HOTEL_VVA
{
    public class hotel
    {
        private List<Loisant> listLoisant = new List<Loisant>();
        private List<Chambre> listChambre = new List<Chambre>();

        public hotel()
        {
            this.listLoisant = ModeleConnexion.GetListLoisant();//on récupère la liste charger à partir de la base
            this.listChambre = ModeleConnexion.GetListChambre();//idem
        }
        public List<Loisant> GetListLoisant()
        {
            return listLoisant;
        }
        public List<Chambre> GetListChambre()
        {
            this.listChambre = ModeleConnexion.GetListChambre();
            return listChambre;
        }
        
    }
}
