namespace PPE2_HOTEL_VVA
{
    partial class FormAdmin
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
            this.bt_Quitter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_AnnulRes = new System.Windows.Forms.Button();
            this.listb_Res = new System.Windows.Forms.ListBox();
            this.gb_AjoutCh = new System.Windows.Forms.GroupBox();
            this.bt_AjoutCh = new System.Windows.Forms.Button();
            this.lb_DescCh = new System.Windows.Forms.Label();
            this.lb_EtatC = new System.Windows.Forms.Label();
            this.lb_CatC = new System.Windows.Forms.Label();
            this.lb_noC = new System.Windows.Forms.Label();
            this.tb_DescCh = new System.Windows.Forms.TextBox();
            this.tb_EtatCh = new System.Windows.Forms.TextBox();
            this.tb_CatCh = new System.Windows.Forms.TextBox();
            this.tb_noCh = new System.Windows.Forms.TextBox();
            this.bt_Deconnexion = new System.Windows.Forms.Button();
            this.lb_ConditionsCat = new System.Windows.Forms.Label();
            this.lb_ConditionsEtat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gb_AjoutCh.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Titre
            // 
            this.lb_Titre.AutoSize = true;
            this.lb_Titre.BackColor = System.Drawing.Color.Transparent;
            this.lb_Titre.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titre.ForeColor = System.Drawing.Color.Black;
            this.lb_Titre.Location = new System.Drawing.Point(405, 9);
            this.lb_Titre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Titre.Name = "lb_Titre";
            this.lb_Titre.Size = new System.Drawing.Size(245, 55);
            this.lb_Titre.TabIndex = 14;
            this.lb_Titre.Text = "Hôtel VVA";
            // 
            // bt_Quitter
            // 
            this.bt_Quitter.Location = new System.Drawing.Point(945, 12);
            this.bt_Quitter.Name = "bt_Quitter";
            this.bt_Quitter.Size = new System.Drawing.Size(89, 36);
            this.bt_Quitter.TabIndex = 18;
            this.bt_Quitter.Text = "Quitter";
            this.bt_Quitter.UseVisualStyleBackColor = true;
            this.bt_Quitter.Click += new System.EventHandler(this.bt_Quitter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_AnnulRes);
            this.groupBox1.Controls.Add(this.listb_Res);
            this.groupBox1.Location = new System.Drawing.Point(12, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1007, 239);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les réservations de l\'hôtel :";
            // 
            // bt_AnnulRes
            // 
            this.bt_AnnulRes.Location = new System.Drawing.Point(792, 90);
            this.bt_AnnulRes.Name = "bt_AnnulRes";
            this.bt_AnnulRes.Size = new System.Drawing.Size(121, 56);
            this.bt_AnnulRes.TabIndex = 23;
            this.bt_AnnulRes.Text = "Annuler Reservation";
            this.bt_AnnulRes.UseVisualStyleBackColor = true;
            this.bt_AnnulRes.Click += new System.EventHandler(this.bt_AnnulRes_Click);
            // 
            // listb_Res
            // 
            this.listb_Res.FormattingEnabled = true;
            this.listb_Res.ItemHeight = 16;
            this.listb_Res.Location = new System.Drawing.Point(6, 46);
            this.listb_Res.Name = "listb_Res";
            this.listb_Res.Size = new System.Drawing.Size(687, 164);
            this.listb_Res.TabIndex = 21;
            // 
            // gb_AjoutCh
            // 
            this.gb_AjoutCh.Controls.Add(this.lb_ConditionsEtat);
            this.gb_AjoutCh.Controls.Add(this.lb_ConditionsCat);
            this.gb_AjoutCh.Controls.Add(this.bt_AjoutCh);
            this.gb_AjoutCh.Controls.Add(this.lb_DescCh);
            this.gb_AjoutCh.Controls.Add(this.lb_EtatC);
            this.gb_AjoutCh.Controls.Add(this.lb_CatC);
            this.gb_AjoutCh.Controls.Add(this.lb_noC);
            this.gb_AjoutCh.Controls.Add(this.tb_DescCh);
            this.gb_AjoutCh.Controls.Add(this.tb_EtatCh);
            this.gb_AjoutCh.Controls.Add(this.tb_CatCh);
            this.gb_AjoutCh.Controls.Add(this.tb_noCh);
            this.gb_AjoutCh.Location = new System.Drawing.Point(12, 364);
            this.gb_AjoutCh.Name = "gb_AjoutCh";
            this.gb_AjoutCh.Size = new System.Drawing.Size(1007, 203);
            this.gb_AjoutCh.TabIndex = 20;
            this.gb_AjoutCh.TabStop = false;
            this.gb_AjoutCh.Text = "Ajouter chambre :";
            // 
            // bt_AjoutCh
            // 
            this.bt_AjoutCh.Location = new System.Drawing.Point(626, 94);
            this.bt_AjoutCh.Name = "bt_AjoutCh";
            this.bt_AjoutCh.Size = new System.Drawing.Size(102, 33);
            this.bt_AjoutCh.TabIndex = 8;
            this.bt_AjoutCh.Text = "Valider";
            this.bt_AjoutCh.UseVisualStyleBackColor = true;
            this.bt_AjoutCh.Click += new System.EventHandler(this.bt_AjoutCh_Click);
            // 
            // lb_DescCh
            // 
            this.lb_DescCh.AutoSize = true;
            this.lb_DescCh.Location = new System.Drawing.Point(310, 37);
            this.lb_DescCh.Name = "lb_DescCh";
            this.lb_DescCh.Size = new System.Drawing.Size(87, 17);
            this.lb_DescCh.TabIndex = 7;
            this.lb_DescCh.Text = "Description :";
            // 
            // lb_EtatC
            // 
            this.lb_EtatC.AutoSize = true;
            this.lb_EtatC.Location = new System.Drawing.Point(22, 110);
            this.lb_EtatC.Name = "lb_EtatC";
            this.lb_EtatC.Size = new System.Drawing.Size(122, 17);
            this.lb_EtatC.TabIndex = 6;
            this.lb_EtatC.Text = "Etat Chambre(**) :";
            // 
            // lb_CatC
            // 
            this.lb_CatC.AutoSize = true;
            this.lb_CatC.Location = new System.Drawing.Point(52, 74);
            this.lb_CatC.Name = "lb_CatC";
            this.lb_CatC.Size = new System.Drawing.Size(92, 17);
            this.lb_CatC.TabIndex = 5;
            this.lb_CatC.Text = "Catégorie(*) :";
            // 
            // lb_noC
            // 
            this.lb_noC.AutoSize = true;
            this.lb_noC.Location = new System.Drawing.Point(51, 37);
            this.lb_noC.Name = "lb_noC";
            this.lb_noC.Size = new System.Drawing.Size(93, 17);
            this.lb_noC.TabIndex = 4;
            this.lb_noC.Text = "N° Chambre :";
            // 
            // tb_DescCh
            // 
            this.tb_DescCh.Location = new System.Drawing.Point(403, 37);
            this.tb_DescCh.Multiline = true;
            this.tb_DescCh.Name = "tb_DescCh";
            this.tb_DescCh.Size = new System.Drawing.Size(180, 95);
            this.tb_DescCh.TabIndex = 3;
            // 
            // tb_EtatCh
            // 
            this.tb_EtatCh.Location = new System.Drawing.Point(156, 110);
            this.tb_EtatCh.Name = "tb_EtatCh";
            this.tb_EtatCh.Size = new System.Drawing.Size(100, 22);
            this.tb_EtatCh.TabIndex = 2;
            // 
            // tb_CatCh
            // 
            this.tb_CatCh.Location = new System.Drawing.Point(156, 74);
            this.tb_CatCh.Name = "tb_CatCh";
            this.tb_CatCh.Size = new System.Drawing.Size(100, 22);
            this.tb_CatCh.TabIndex = 1;
            // 
            // tb_noCh
            // 
            this.tb_noCh.Location = new System.Drawing.Point(156, 37);
            this.tb_noCh.Name = "tb_noCh";
            this.tb_noCh.Size = new System.Drawing.Size(100, 22);
            this.tb_noCh.TabIndex = 0;
            // 
            // bt_Deconnexion
            // 
            this.bt_Deconnexion.Location = new System.Drawing.Point(12, 12);
            this.bt_Deconnexion.Name = "bt_Deconnexion";
            this.bt_Deconnexion.Size = new System.Drawing.Size(109, 36);
            this.bt_Deconnexion.TabIndex = 21;
            this.bt_Deconnexion.Text = "Déconnexion";
            this.bt_Deconnexion.UseVisualStyleBackColor = true;
            this.bt_Deconnexion.Click += new System.EventHandler(this.bt_Deconnexion_Click);
            // 
            // lb_ConditionsCat
            // 
            this.lb_ConditionsCat.AutoSize = true;
            this.lb_ConditionsCat.Location = new System.Drawing.Point(32, 150);
            this.lb_ConditionsCat.Name = "lb_ConditionsCat";
            this.lb_ConditionsCat.Size = new System.Drawing.Size(263, 17);
            this.lb_ConditionsCat.TabIndex = 9;
            this.lb_ConditionsCat.Text = "(*) \"SIMPLE\", \"DOUBLE\" ou \"FAMILIALE\"";
            // 
            // lb_ConditionsEtat
            // 
            this.lb_ConditionsEtat.AutoSize = true;
            this.lb_ConditionsEtat.Location = new System.Drawing.Point(32, 177);
            this.lb_ConditionsEtat.Name = "lb_ConditionsEtat";
            this.lb_ConditionsEtat.Size = new System.Drawing.Size(232, 17);
            this.lb_ConditionsEtat.TabIndex = 10;
            this.lb_ConditionsEtat.Text = "(**) \"V\" (valide) ou \"I\"(indisponnible)";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 593);
            this.Controls.Add(this.bt_Deconnexion);
            this.Controls.Add(this.gb_AjoutCh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_Quitter);
            this.Controls.Add(this.lb_Titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.gb_AjoutCh.ResumeLayout(false);
            this.gb_AjoutCh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Titre;
        private System.Windows.Forms.Button bt_Quitter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb_AjoutCh;
        private System.Windows.Forms.ListBox listb_Res;
        private System.Windows.Forms.Button bt_AnnulRes;
        private System.Windows.Forms.Button bt_AjoutCh;
        private System.Windows.Forms.Label lb_DescCh;
        private System.Windows.Forms.Label lb_EtatC;
        private System.Windows.Forms.Label lb_CatC;
        private System.Windows.Forms.Label lb_noC;
        private System.Windows.Forms.TextBox tb_DescCh;
        private System.Windows.Forms.TextBox tb_EtatCh;
        private System.Windows.Forms.TextBox tb_CatCh;
        private System.Windows.Forms.TextBox tb_noCh;
        private System.Windows.Forms.Button bt_Deconnexion;
        private System.Windows.Forms.Label lb_ConditionsCat;
        private System.Windows.Forms.Label lb_ConditionsEtat;
    }
}