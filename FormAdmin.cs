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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            //On récupère toutes les réservations de l'hôtel
            foreach (Reservation r in Modele_ADMIN.GetReservations())
            {
                listb_Res.Items.Add(r);
            }
        }
        private void bt_Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Bouton permettant à l'admin de se déconnecter
        private void bt_Deconnexion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConnexion generer = new FormConnexion();
            generer.Show();
        }

        private void bt_AnnulRes_Click(object sender, EventArgs e)
        {
            //Pour annuler une réservation
            //on vérifie q'une res a été sélectoinné
            if (listb_Res.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner une réservation pour pouvoir l'annuler !");
            }
            else
            {
                //on récupère les données de la réservation
                Reservation r = (Reservation)listb_Res.SelectedItem;
                //on éxecute l'annulation(Etat_Res=A (Annulée)) et on vérifie que l'annulation s'est effectuée avec succès
                if (Modele_LO_MesReservations.AnnulerReservation(r.GetNoR()) == true)
                {
                    MessageBox.Show("Annulation validée");
                }
                else
                {
                    MessageBox.Show("Echec!");
                }
            }
            //on rafraichit la liste des réservations
            listb_Res.Items.Clear();
            foreach (Reservation r in Modele_ADMIN.GetReservations())
            {
                listb_Res.Items.Add(r);
            }
        }
        
        private void bt_AjoutCh_Click(object sender, EventArgs e)
        {
            //Ajout d'une nouvel chambre
            //Controle de saisie
            if (tb_noCh.Text != "" && tb_CatCh.Text != "" && tb_EtatCh.Text != "" && tb_DescCh.Text != "")
            {
                //Controle du respect des conditions d'ajout de chambre
                if (tb_CatCh.Text == "SIMPLE" || tb_CatCh.Text == "DOUBLE" || tb_CatCh.Text == "FAMILIALE" || tb_EtatCh.Text == "V" || tb_EtatCh.Text == "I")
                {
                    //On vérifie que le num de chambre est déjà pris
                    if(Modele_ADMIN.ExisteNoChambre(tb_noCh.Text)==false)
                    {
                        //on éxecute l'ajout
                        if (Modele_ADMIN.AddChambre(tb_noCh.Text, tb_CatCh.Text, tb_EtatCh.Text, tb_DescCh.Text) == true)
                        {
                            MessageBox.Show("Ajout avec succès !");
                        }
                        else 
                        {
                            MessageBox.Show("Echec de l'ajout !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nous avons déjà une chambre avec ce n°");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez respecter les conditions pour la catégorie et l'etat des chambres!");
                }
            }
            else 
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
            }
        }

    }
}
