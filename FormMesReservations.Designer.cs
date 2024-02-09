namespace PPE2_HOTEL_VVA
{
    partial class FormMesReservations
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
            this.bt_RetourAccueil = new System.Windows.Forms.Button();
            this.listb_MesRes = new System.Windows.Forms.ListBox();
            this.lb_MesRes = new System.Windows.Forms.Label();
            this.bt_AnnulRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Titre
            // 
            this.lb_Titre.AutoSize = true;
            this.lb_Titre.BackColor = System.Drawing.Color.Transparent;
            this.lb_Titre.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titre.ForeColor = System.Drawing.Color.Black;
            this.lb_Titre.Location = new System.Drawing.Point(246, 9);
            this.lb_Titre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Titre.Name = "lb_Titre";
            this.lb_Titre.Size = new System.Drawing.Size(245, 55);
            this.lb_Titre.TabIndex = 13;
            this.lb_Titre.Text = "Hôtel VVA";
            // 
            // bt_Quitter
            // 
            this.bt_Quitter.Location = new System.Drawing.Point(619, 12);
            this.bt_Quitter.Name = "bt_Quitter";
            this.bt_Quitter.Size = new System.Drawing.Size(89, 36);
            this.bt_Quitter.TabIndex = 17;
            this.bt_Quitter.Text = "Quitter";
            this.bt_Quitter.UseVisualStyleBackColor = true;
            this.bt_Quitter.Click += new System.EventHandler(this.bt_Quitter_Click);
            // 
            // bt_RetourAccueil
            // 
            this.bt_RetourAccueil.Location = new System.Drawing.Point(12, 12);
            this.bt_RetourAccueil.Name = "bt_RetourAccueil";
            this.bt_RetourAccueil.Size = new System.Drawing.Size(89, 31);
            this.bt_RetourAccueil.TabIndex = 19;
            this.bt_RetourAccueil.Text = "<-";
            this.bt_RetourAccueil.UseVisualStyleBackColor = true;
            this.bt_RetourAccueil.Click += new System.EventHandler(this.bt_RetourAccueil_Click);
            // 
            // listb_MesRes
            // 
            this.listb_MesRes.FormattingEnabled = true;
            this.listb_MesRes.ItemHeight = 16;
            this.listb_MesRes.Location = new System.Drawing.Point(12, 154);
            this.listb_MesRes.Name = "listb_MesRes";
            this.listb_MesRes.Size = new System.Drawing.Size(676, 84);
            this.listb_MesRes.TabIndex = 20;
            // 
            // lb_MesRes
            // 
            this.lb_MesRes.AutoSize = true;
            this.lb_MesRes.Location = new System.Drawing.Point(12, 134);
            this.lb_MesRes.Name = "lb_MesRes";
            this.lb_MesRes.Size = new System.Drawing.Size(124, 17);
            this.lb_MesRes.TabIndex = 21;
            this.lb_MesRes.Text = "Mes réservations :";
            // 
            // bt_AnnulRes
            // 
            this.bt_AnnulRes.Location = new System.Drawing.Point(15, 244);
            this.bt_AnnulRes.Name = "bt_AnnulRes";
            this.bt_AnnulRes.Size = new System.Drawing.Size(121, 56);
            this.bt_AnnulRes.TabIndex = 22;
            this.bt_AnnulRes.Text = "Annuler Reservation";
            this.bt_AnnulRes.UseVisualStyleBackColor = true;
            this.bt_AnnulRes.Click += new System.EventHandler(this.bt_AnnulRes_Click);
            // 
            // FormMesReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.bt_AnnulRes);
            this.Controls.Add(this.lb_MesRes);
            this.Controls.Add(this.listb_MesRes);
            this.Controls.Add(this.bt_RetourAccueil);
            this.Controls.Add(this.bt_Quitter);
            this.Controls.Add(this.lb_Titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMesReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMesReservations";
            this.Load += new System.EventHandler(this.FormMesReservations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Titre;
        private System.Windows.Forms.Button bt_Quitter;
        private System.Windows.Forms.Button bt_RetourAccueil;
        private System.Windows.Forms.ListBox listb_MesRes;
        private System.Windows.Forms.Label lb_MesRes;
        private System.Windows.Forms.Button bt_AnnulRes;
    }
}