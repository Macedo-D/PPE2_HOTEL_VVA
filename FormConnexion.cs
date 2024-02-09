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
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {
            bool connect = ModeleConnexion.Connexion(); // connexion à la base
        }

        private void bt_connexion_Click(object sender, EventArgs e)
        {

            if (tb_id.Text != "" || tb_mdp.Text != "")//Contrôle de saisie
            {
                Profil profilCo = new Profil(tb_id.Text, tb_mdp.Text);
                //on vérifie si le profil existe
                if (ModeleConnexion.ExisteProfil(profilCo) == false)
                {
                    MessageBox.Show("Veuillez saisir un identifiant et mot de passe valide!");
                }
                else
                {
                    profilCo.SetTypeP(ModeleConnexion.GetTypeProfil(profilCo));
                    //On redirige l'utilisateur vers le form lui correspondant "Loisant" ou "Admin"
                    if (profilCo.GetTypeP() == "LO")
                    {
                        //on récupère le loisant pour vérifier que ses dates de séjours ne sont pas passées
                        Loisant loisantCo = new Loisant();
                        List<Loisant> listeL = ModeleConnexion.GetListLoisant();
                        foreach (Loisant lo in listeL)
                        {
                            if (lo.GetUser() == profilCo.GetUser())
                            {
                                //loisantCo.SetNoL(lo.GetNoL());
                                loisantCo = new Loisant(lo.GetNoL(), lo.GetUser(), lo.GetNom(), lo.GetPrenom(), lo.GetdtDebSej(), lo.GetdtFinSej(), lo.GetdtNais());
                            }
                        }
                        if (loisantCo.GetdtDebSej() >= DateTime.Now)
                        {
                            this.Hide();
                            string user = profilCo.GetUser();
                            FormReservation generer = new FormReservation(user);//on redirige vers la page d'accueil du loisant
                            generer.Show();
                        }
                        else
                        {
                            MessageBox.Show("Vos dates de séjours dans notre village vacance sont terminés!");
                        }
                    }
                    else//Si c'est un admin
                    {
                        this.Hide();
                        FormAdmin generer = new FormAdmin();//on le redirige vers ça page d'accueil.
                        generer.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tout les champs!");
            }
        }
    }
}
