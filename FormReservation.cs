using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PPE2_HOTEL_VVA
{
    public partial class FormReservation : Form
    {
        private static hotel hotelVVA = new hotel();//on instancie l'hôtel pour charger la liste des chambres et des loisants
        private static Profil profilCo = new Profil();//Profil récuperé à partir de l'user saisit lors de la co
        private static Loisant loisantCo;//on récupère le loisant à partir de l'user 
        public FormReservation(string user)
        {
            InitializeComponent();
      
            lb_sousTitre.Text = "Bonjour " + user;
            profilCo.SetUser(user);
            List<Loisant> listeL = hotelVVA.GetListLoisant();//on récupère la liste des loisants de l'hotel
            foreach (Loisant lo in listeL)
            {
                if (lo.GetUser() == profilCo.GetUser())//on vérifie que les users correspondent
                {
                    //loisantCo.SetNoL(lo.GetNoL());
                    loisantCo = new Loisant(lo.GetNoL(), lo.GetUser(), lo.GetNom(), lo.GetPrenom(), lo.GetdtDebSej(), lo.GetdtFinSej(), lo.GetdtNais());
                }
            }
        }

        private void FormReservation_Load(object sender, EventArgs e)
        {
            gb_chambre.Visible = false;
            gb_tarifFinal.Visible = false;
        }

        private void bt_Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //En fonction du choix de catégorie de chambre on vérifie si une chambre est disponnible
        private void bt_simple_Click(object sender, EventArgs e)
        {
            clb_supplements.Items.Clear();
            string catChambre = "SIMPLE";
            if (Modele_LO_Reservation.ExisteChambre(catChambre) == true)//si chambre de catégorie"SIMPLE" existe on affichele formulaire de réservation
            {
                gb_chambre.Visible = true;
                gb_chambre.Text = "SIMPLE";
                ArrayList listeSupp = Modele_LO_Reservation.GetNomSupp();//on charge les suppléments que propose l'hôtel
                foreach (String supp in listeSupp)
                {
                    clb_supplements.Items.Add(supp);
                }
            }
            else//si aucune chambre disponible (Etat_CH=I(INDISPONNIBLE)).
            {
                MessageBox.Show("Nous sommes dans le regret de vous annoncer qu'il n'y a plus de chambre simple disponible.");
            }
        }
        //On fait la même chose que pour le bouton de catégorie simple
        private void bt_double_Click(object sender, EventArgs e)
        {
            clb_supplements.Items.Clear();
            string catChambre = "DOUBLE";
            if (Modele_LO_Reservation.ExisteChambre(catChambre) == true)
            {
                gb_chambre.Visible = true;
                gb_chambre.Text = "DOUBLE";
                ArrayList listeSupp = Modele_LO_Reservation.GetNomSupp();
                foreach (String supp in listeSupp)
                {
                    clb_supplements.Items.Add(supp);
                }
            }
            else
            {
                MessageBox.Show("Nous sommes dans le regret de vous annoncer qu'il n'y a plus de chambre double disponible.");
            }
        }
        //On fait la même chose que pour le bouton de catégorie simple
        private void bt_fami_Click(object sender, EventArgs e)
        {
            clb_supplements.Items.Clear();
            string catChambre = "FAMILIALE";
            if (Modele_LO_Reservation.ExisteChambre(catChambre) == true)
            {
                gb_chambre.Visible = true;
                gb_chambre.Text = "FAMILIALE";
                ArrayList listeSupp = Modele_LO_Reservation.GetNomSupp();
                foreach (String supp in listeSupp)
                {
                    clb_supplements.Items.Add(supp);
                }
            }
            else
            {
                MessageBox.Show("Nous sommes dans le regret de vous annoncer qu'il n'y a plus de chambre familiale disponible.");
            }
        }

        private void bt_confirmerRes_Click(object sender, EventArgs e)
        {
            //Si le loisant souhaite réserver on vérifie la cohérence des dates voulues
            if (dateTimePicker_dtDeb.Value.Date < dateTimePicker_dtFin.Value.Date)
            {
                //on récupère les données saisies pour afficher le prix de réservation correspondant
                ArrayList listSupplement = new ArrayList();
                foreach (object itemChecked in clb_supplements.CheckedItems)
                {
                    listSupplement.Add(itemChecked.ToString());
                }
                float tarifSupp = 0;
                foreach (string supp in listSupplement)
                {
                    tarifSupp = tarifSupp + Modele_LO_Reservation.GetTarifSupp(supp);
                }
                DateTime dtDeb = dateTimePicker_dtDeb.Value.Date;
                DateTime dtFin = dateTimePicker_dtFin.Value.Date;
                float totD = (float)((dtFin - dtDeb).TotalDays);
                //on calcule le prix de la réservation (prix_chambre + suppléments_choisies)*nb_de_jours
                float tarif = (Modele_LO_Reservation.GetTarifJ(gb_chambre.Text) + tarifSupp) * totD;
                // on affiche le prix de la réservation
                gb_tarifFinal.Visible = true;
                lb_Tarif.Text = tarif.ToString();
            }
            else
            {
                MessageBox.Show("Veuillez saisir un date d'arrivée et de départ cohérentes");
            }
        }

        private void bt_validerTarif_Click(object sender, EventArgs e)
        {
            //si le loisant valide la réservation on récupère les données saisies
            string noCh= "";
            List<Chambre> listeC = hotelVVA.GetListChambre();
            // on récupère un numéro de chambre de l'hôtel correspondant à la catégorie choisie
            foreach (Chambre ch in listeC)
            {
                if (ch.GetCategorie() == gb_chambre.Text && ch.GetEtat() == "V")
                {
                    noCh = ch.GetNum();
                }
            }
            if (noCh != "")//on vérifie quand même si une chambre existe
            {
                DateTime dtdeb = dateTimePicker_dtDeb.Value;
                DateTime dtfin = dateTimePicker_dtFin.Value;
                double mTRes = double.Parse(lb_Tarif.Text);
                //On vérifie que les dates de réservation sont cohérentes par rapport aux dates de sejourt du loisant
                if (dtdeb>= loisantCo.GetdtDebSej() && dtfin <= loisantCo.GetdtFinSej())
                {
                    //on éxecute la réservation
                    bool reservation = Modele_LO_Reservation.AddReservation(loisantCo.GetNoL(), noCh, dtdeb.ToString("yyyy-MM-dd HH:mm:ss"), dtfin.ToString("yyyy-MM-dd HH:mm:ss"), mTRes);
                    if (reservation == true)
                    {
                        //on change l'état de la chambre I pour indisponnible
                        Modele_LO_Reservation.ModifEtatChambre(noCh, "I");
                        //on redirige vers la liste des réservations du loisant
                        this.Hide();
                        FormMesReservations generer = new FormMesReservations(profilCo, loisantCo);//on récupère au passage les données du loisant
                        generer.Show();
                    }
                    else// si l'éxecution de la réservation a échoué
                    {
                        MessageBox.Show("Une erreur s'est produite lors de la réservation veuillez réessayer plus tard.");
                    }
                }
                else//si les dates de res et de séjourts du loisant ne sont pas cohérentes
                {
                    MessageBox.Show("Il faut que vos dates de réservations à l'hôtel soient cohérentes par rapport à vos dates de séjours dans le village vacance. Rappel : Date début de séjour(" + (loisantCo.GetdtDebSej()).ToString("yyyy-MM-dd") + "), Date fin de séjour(" + loisantCo.GetdtFinSej().ToString("yyyy-MM-dd") + ")");
                }
            }
            else 
            {
                MessageBox.Show("Aucune Chambre n'est disponnible.");
            }
        }

        //Bouton permettant au loisant de consulter ses réservations
        private void bt_MesRes_Click(object sender, EventArgs e)
        {
            //on vérifie que le loisant à min 1 réservation dans l'hôtel
            if (Modele_LO_MesReservations.ExisteReservation(loisantCo.GetNoL()) == true)
            {
                this.Hide();
                FormMesReservations generer = new FormMesReservations(profilCo,loisantCo);
                generer.Show();

            }
            else 
            {
                MessageBox.Show("Vous n'avez aucunes réservations en cours.");
            }
        }
        //Bouton permettant au loisant de se déconnecter
        private void bt_Deconnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConnexion generer = new FormConnexion();
            generer.Show();
        }
        
    }
}