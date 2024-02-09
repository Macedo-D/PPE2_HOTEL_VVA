using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PPE2_HOTEL_VVA
{
    public partial class FormMesReservations : Form
    {
        private static hotel hotelVVA = new hotel();//on instancie l'hôtel pour charger la liste des chambres et des loisants récupérés à partir de la bdd
        private static Profil profilCo = new Profil();//Profil récuperé à partir de l'user saisit lors de la co
        private static Loisant loisantCo = new Loisant();//on récupère le loisant à partir de l'user 
        public FormMesReservations(Profil profil, Loisant lo)
        {
            InitializeComponent();
            //on récupère les données du loisant depuis la page de réservation
            profilCo = profil;
            loisantCo = lo;
        }
        private void FormMesReservations_Load(object sender, EventArgs e)
        {
            //On charge la liste des réservations du loisant
            foreach (Reservation r in Modele_LO_MesReservations.GetMesReservations(loisantCo.GetNoL()))
            {
                listb_MesRes.Items.Add(r);
            }
        }
        //Bouton permettant au loisant de retourner à la page de réservation
        private void bt_RetourAccueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReservation generer = new FormReservation(profilCo.GetUser());
            generer.Show();
        }
        
        private void bt_Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();//Quitter l'application
        }

        private void bt_AnnulRes_Click(object sender, EventArgs e)
        {
            //Annuler une réservation
            //Controle de saisie
            if (listb_MesRes.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner une réservation pour pouvoir l'annuler !");
            }
            else
            {
                //on récupère les données de la réservation
                Reservation r = (Reservation)listb_MesRes.SelectedItem;
                //on éxecute l'annulation (Etat_Res=A (Annulée)) et on vérifie qu'elle s'est effectuée avec succès
                if (Modele_LO_MesReservations.AnnulerReservation(r.GetNoR()) == true)
                {
                    Modele_LO_Reservation.ModifEtatChambre(r.GetNoCh(), "V");//On modifie l'etat de la chambre "V" pour Valide
                    MessageBox.Show("Annulation validée");
                }
                else 
                {
                    MessageBox.Show("Echec!");
                }
            }
            //on rafraichit la liste des réservations
            listb_MesRes.Items.Clear();
            foreach (Reservation r in Modele_LO_MesReservations.GetMesReservations(loisantCo.GetNoL()))
            {
                listb_MesRes.Items.Add(r);
            }
        }
    }
}
