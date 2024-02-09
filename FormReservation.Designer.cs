namespace PPE2_HOTEL_VVA
{
    partial class FormReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Titre = new System.Windows.Forms.Label();
            this.lb_sousTitre = new System.Windows.Forms.Label();
            this.gb_choixC = new System.Windows.Forms.GroupBox();
            this.bt_simple = new System.Windows.Forms.Button();
            this.bt_double = new System.Windows.Forms.Button();
            this.bt_fami = new System.Windows.Forms.Button();
            this.bt_Quitter = new System.Windows.Forms.Button();
            this.gb_chambre = new System.Windows.Forms.GroupBox();
            this.clb_supplements = new System.Windows.Forms.CheckedListBox();
            this.bt_confirmerRes = new System.Windows.Forms.Button();
            this.lb_supplement = new System.Windows.Forms.Label();
            this.dateTimePicker_dtFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_dtDeb = new System.Windows.Forms.DateTimePicker();
            this.lb_dtFin = new System.Windows.Forms.Label();
            this.lb_dtdeb = new System.Windows.Forms.Label();
            this.gb_tarifFinal = new System.Windows.Forms.GroupBox();
            this.label_valeurMontant = new System.Windows.Forms.Label();
            this.bt_validerTarif = new System.Windows.Forms.Button();
            this.lb_Tarif = new System.Windows.Forms.Label();
            this.bt_MesRes = new System.Windows.Forms.Button();
            this.lb_VoirRes = new System.Windows.Forms.Label();
            this.bt_Deconnexion = new System.Windows.Forms.Button();
            this.gb_choixC.SuspendLayout();
            this.gb_chambre.SuspendLayout();
            this.gb_tarifFinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Titre
            // 
            this.lb_Titre.AutoSize = true;
            this.lb_Titre.BackColor = System.Drawing.Color.Transparent;
            this.lb_Titre.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titre.ForeColor = System.Drawing.Color.Black;
            this.lb_Titre.Location = new System.Drawing.Point(174, 9);
            this.lb_Titre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Titre.Name = "lb_Titre";
            this.lb_Titre.Size = new System.Drawing.Size(245, 55);
            this.lb_Titre.TabIndex = 12;
            this.lb_Titre.Text = "Hôtel VVA";
            // 
            // lb_sousTitre
            // 
            this.lb_sousTitre.AutoSize = true;
            this.lb_sousTitre.Location = new System.Drawing.Point(248, 91);
            this.lb_sousTitre.Name = "lb_sousTitre";
            this.lb_sousTitre.Size = new System.Drawing.Size(92, 17);
            this.lb_sousTitre.TabIndex = 13;
            this.lb_sousTitre.Text = "Reservation :";
            // 
            // gb_choixC
            // 
            this.gb_choixC.Controls.Add(this.bt_simple);
            this.gb_choixC.Controls.Add(this.bt_double);
            this.gb_choixC.Controls.Add(this.bt_fami);
            this.gb_choixC.Location = new System.Drawing.Point(161, 123);
            this.gb_choixC.Name = "gb_choixC";
            this.gb_choixC.Size = new System.Drawing.Size(274, 108);
            this.gb_choixC.TabIndex = 15;
            this.gb_choixC.TabStop = false;
            this.gb_choixC.Text = "Quelle Chambre avez-vous besoin ? :";
            // 
            // bt_simple
            // 
            this.bt_simple.Location = new System.Drawing.Point(9, 32);
            this.bt_simple.Name = "bt_simple";
            this.bt_simple.Size = new System.Drawing.Size(75, 23);
            this.bt_simple.TabIndex = 16;
            this.bt_simple.Text = "SIMPLE";
            this.bt_simple.UseVisualStyleBackColor = true;
            this.bt_simple.Click += new System.EventHandler(this.bt_simple_Click);
            // 
            // bt_double
            // 
            this.bt_double.Location = new System.Drawing.Point(187, 32);
            this.bt_double.Name = "bt_double";
            this.bt_double.Size = new System.Drawing.Size(81, 23);
            this.bt_double.TabIndex = 17;
            this.bt_double.Text = "DOUBLE";
            this.bt_double.UseVisualStyleBackColor = true;
            this.bt_double.Click += new System.EventHandler(this.bt_double_Click);
            // 
            // bt_fami
            // 
            this.bt_fami.Location = new System.Drawing.Point(90, 67);
            this.bt_fami.Name = "bt_fami";
            this.bt_fami.Size = new System.Drawing.Size(94, 25);
            this.bt_fami.TabIndex = 18;
            this.bt_fami.Text = "FAMILIALE";
            this.bt_fami.UseVisualStyleBackColor = true;
            this.bt_fami.Click += new System.EventHandler(this.bt_fami_Click);
            // 
            // bt_Quitter
            // 
            this.bt_Quitter.Location = new System.Drawing.Point(547, 12);
            this.bt_Quitter.Name = "bt_Quitter";
            this.bt_Quitter.Size = new System.Drawing.Size(89, 36);
            this.bt_Quitter.TabIndex = 16;
            this.bt_Quitter.Text = "Quitter";
            this.bt_Quitter.UseVisualStyleBackColor = true;
            this.bt_Quitter.Click += new System.EventHandler(this.bt_Quitter_Click);
            // 
            // gb_chambre
            // 
            this.gb_chambre.Controls.Add(this.clb_supplements);
            this.gb_chambre.Controls.Add(this.bt_confirmerRes);
            this.gb_chambre.Controls.Add(this.lb_supplement);
            this.gb_chambre.Controls.Add(this.dateTimePicker_dtFin);
            this.gb_chambre.Controls.Add(this.dateTimePicker_dtDeb);
            this.gb_chambre.Controls.Add(this.lb_dtFin);
            this.gb_chambre.Controls.Add(this.lb_dtdeb);
            this.gb_chambre.Location = new System.Drawing.Point(131, 246);
            this.gb_chambre.Name = "gb_chambre";
            this.gb_chambre.Size = new System.Drawing.Size(327, 216);
            this.gb_chambre.TabIndex = 17;
            this.gb_chambre.TabStop = false;
            // 
            // clb_supplements
            // 
            this.clb_supplements.FormattingEnabled = true;
            this.clb_supplements.Location = new System.Drawing.Point(120, 79);
            this.clb_supplements.Name = "clb_supplements";
            this.clb_supplements.Size = new System.Drawing.Size(201, 89);
            this.clb_supplements.TabIndex = 7;
            // 
            // bt_confirmerRes
            // 
            this.bt_confirmerRes.Location = new System.Drawing.Point(217, 174);
            this.bt_confirmerRes.Name = "bt_confirmerRes";
            this.bt_confirmerRes.Size = new System.Drawing.Size(104, 26);
            this.bt_confirmerRes.TabIndex = 6;
            this.bt_confirmerRes.Text = "confirmer";
            this.bt_confirmerRes.UseVisualStyleBackColor = true;
            this.bt_confirmerRes.Click += new System.EventHandler(this.bt_confirmerRes_Click);
            // 
            // lb_supplement
            // 
            this.lb_supplement.AutoSize = true;
            this.lb_supplement.Location = new System.Drawing.Point(6, 86);
            this.lb_supplement.Name = "lb_supplement";
            this.lb_supplement.Size = new System.Drawing.Size(108, 17);
            this.lb_supplement.TabIndex = 4;
            this.lb_supplement.Text = "Supplément(s) :";
            // 
            // dateTimePicker_dtFin
            // 
            this.dateTimePicker_dtFin.Location = new System.Drawing.Point(117, 51);
            this.dateTimePicker_dtFin.Name = "dateTimePicker_dtFin";
            this.dateTimePicker_dtFin.Size = new System.Drawing.Size(171, 22);
            this.dateTimePicker_dtFin.TabIndex = 3;
            // 
            // dateTimePicker_dtDeb
            // 
            this.dateTimePicker_dtDeb.Location = new System.Drawing.Point(117, 23);
            this.dateTimePicker_dtDeb.Name = "dateTimePicker_dtDeb";
            this.dateTimePicker_dtDeb.Size = new System.Drawing.Size(171, 22);
            this.dateTimePicker_dtDeb.TabIndex = 2;
            // 
            // lb_dtFin
            // 
            this.lb_dtFin.AutoSize = true;
            this.lb_dtFin.Location = new System.Drawing.Point(6, 51);
            this.lb_dtFin.Name = "lb_dtFin";
            this.lb_dtFin.Size = new System.Drawing.Size(111, 17);
            this.lb_dtFin.TabIndex = 1;
            this.lb_dtFin.Text = "Date de départ :";
            // 
            // lb_dtdeb
            // 
            this.lb_dtdeb.AutoSize = true;
            this.lb_dtdeb.Location = new System.Drawing.Point(6, 23);
            this.lb_dtdeb.Name = "lb_dtdeb";
            this.lb_dtdeb.Size = new System.Drawing.Size(105, 17);
            this.lb_dtdeb.TabIndex = 0;
            this.lb_dtdeb.Text = "Date d\'arrivée :";
            // 
            // gb_tarifFinal
            // 
            this.gb_tarifFinal.Controls.Add(this.label_valeurMontant);
            this.gb_tarifFinal.Controls.Add(this.bt_validerTarif);
            this.gb_tarifFinal.Controls.Add(this.lb_Tarif);
            this.gb_tarifFinal.Location = new System.Drawing.Point(464, 260);
            this.gb_tarifFinal.Name = "gb_tarifFinal";
            this.gb_tarifFinal.Size = new System.Drawing.Size(178, 100);
            this.gb_tarifFinal.TabIndex = 8;
            this.gb_tarifFinal.TabStop = false;
            this.gb_tarifFinal.Text = "Tarif Final :";
            // 
            // label_valeurMontant
            // 
            this.label_valeurMontant.AutoSize = true;
            this.label_valeurMontant.Location = new System.Drawing.Point(106, 28);
            this.label_valeurMontant.Name = "label_valeurMontant";
            this.label_valeurMontant.Size = new System.Drawing.Size(16, 17);
            this.label_valeurMontant.TabIndex = 2;
            this.label_valeurMontant.Text = "€";
            // 
            // bt_validerTarif
            // 
            this.bt_validerTarif.Location = new System.Drawing.Point(51, 65);
            this.bt_validerTarif.Name = "bt_validerTarif";
            this.bt_validerTarif.Size = new System.Drawing.Size(75, 23);
            this.bt_validerTarif.TabIndex = 1;
            this.bt_validerTarif.Text = "valider";
            this.bt_validerTarif.UseVisualStyleBackColor = true;
            this.bt_validerTarif.Click += new System.EventHandler(this.bt_validerTarif_Click);
            // 
            // lb_Tarif
            // 
            this.lb_Tarif.AutoSize = true;
            this.lb_Tarif.Location = new System.Drawing.Point(58, 28);
            this.lb_Tarif.Name = "lb_Tarif";
            this.lb_Tarif.Size = new System.Drawing.Size(0, 17);
            this.lb_Tarif.TabIndex = 0;
            // 
            // bt_MesRes
            // 
            this.bt_MesRes.Location = new System.Drawing.Point(547, 54);
            this.bt_MesRes.Name = "bt_MesRes";
            this.bt_MesRes.Size = new System.Drawing.Size(89, 31);
            this.bt_MesRes.TabIndex = 18;
            this.bt_MesRes.Text = "->";
            this.bt_MesRes.UseVisualStyleBackColor = true;
            this.bt_MesRes.Click += new System.EventHandler(this.bt_MesRes_Click);
            // 
            // lb_VoirRes
            // 
            this.lb_VoirRes.AutoSize = true;
            this.lb_VoirRes.Location = new System.Drawing.Point(417, 61);
            this.lb_VoirRes.Name = "lb_VoirRes";
            this.lb_VoirRes.Size = new System.Drawing.Size(124, 17);
            this.lb_VoirRes.TabIndex = 19;
            this.lb_VoirRes.Text = "Mes réservations :";
            // 
            // bt_Deconnexion
            // 
            this.bt_Deconnexion.Location = new System.Drawing.Point(12, 12);
            this.bt_Deconnexion.Name = "bt_Deconnexion";
            this.bt_Deconnexion.Size = new System.Drawing.Size(109, 36);
            this.bt_Deconnexion.TabIndex = 20;
            this.bt_Deconnexion.Text = "Déconnexion";
            this.bt_Deconnexion.UseVisualStyleBackColor = true;
            this.bt_Deconnexion.Click += new System.EventHandler(this.bt_Deconnexion_Click);
            // 
            // FormReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(648, 474);
            this.Controls.Add(this.bt_Deconnexion);
            this.Controls.Add(this.lb_VoirRes);
            this.Controls.Add(this.bt_MesRes);
            this.Controls.Add(this.gb_tarifFinal);
            this.Controls.Add(this.gb_chambre);
            this.Controls.Add(this.bt_Quitter);
            this.Controls.Add(this.gb_choixC);
            this.Controls.Add(this.lb_sousTitre);
            this.Controls.Add(this.lb_Titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReservation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReservation";
            this.Load += new System.EventHandler(this.FormReservation_Load);
            this.gb_choixC.ResumeLayout(false);
            this.gb_chambre.ResumeLayout(false);
            this.gb_chambre.PerformLayout();
            this.gb_tarifFinal.ResumeLayout(false);
            this.gb_tarifFinal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Titre;
        private System.Windows.Forms.Label lb_sousTitre;
        private System.Windows.Forms.GroupBox gb_choixC;
        private System.Windows.Forms.Button bt_simple;
        private System.Windows.Forms.Button bt_double;
        private System.Windows.Forms.Button bt_fami;
        private System.Windows.Forms.Button bt_Quitter;
        private System.Windows.Forms.GroupBox gb_chambre;
        private System.Windows.Forms.Label lb_supplement;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dtFin;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dtDeb;
        private System.Windows.Forms.Label lb_dtFin;
        private System.Windows.Forms.Label lb_dtdeb;
        private System.Windows.Forms.Button bt_confirmerRes;
        private System.Windows.Forms.CheckedListBox clb_supplements;
        private System.Windows.Forms.GroupBox gb_tarifFinal;
        private System.Windows.Forms.Button bt_validerTarif;
        private System.Windows.Forms.Label lb_Tarif;
        private System.Windows.Forms.Label label_valeurMontant;
        private System.Windows.Forms.Button bt_MesRes;
        private System.Windows.Forms.Label lb_VoirRes;
        private System.Windows.Forms.Button bt_Deconnexion;

    }
}