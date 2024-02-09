namespace PPE2_HOTEL_VVA
{
    partial class FormConnexion
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
            this.bt_connexion = new System.Windows.Forms.Button();
            this.lb_mdp = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.tb_mdp = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_hotelVVA = new System.Windows.Forms.Label();
            this.lb_coBase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_connexion
            // 
            this.bt_connexion.Location = new System.Drawing.Point(304, 231);
            this.bt_connexion.Name = "bt_connexion";
            this.bt_connexion.Size = new System.Drawing.Size(103, 28);
            this.bt_connexion.TabIndex = 11;
            this.bt_connexion.Text = "Connexion";
            this.bt_connexion.UseVisualStyleBackColor = true;
            this.bt_connexion.Click += new System.EventHandler(this.bt_connexion_Click);
            // 
            // lb_mdp
            // 
            this.lb_mdp.AutoSize = true;
            this.lb_mdp.Location = new System.Drawing.Point(137, 186);
            this.lb_mdp.Name = "lb_mdp";
            this.lb_mdp.Size = new System.Drawing.Size(101, 17);
            this.lb_mdp.TabIndex = 10;
            this.lb_mdp.Text = "Mot de passe :";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(137, 140);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(77, 17);
            this.lb_user.TabIndex = 9;
            this.lb_user.Text = "Identifiant :";
            // 
            // tb_mdp
            // 
            this.tb_mdp.Location = new System.Drawing.Point(244, 186);
            this.tb_mdp.Name = "tb_mdp";
            this.tb_mdp.Size = new System.Drawing.Size(163, 22);
            this.tb_mdp.TabIndex = 8;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(244, 140);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(163, 22);
            this.tb_id.TabIndex = 7;
            // 
            // lb_hotelVVA
            // 
            this.lb_hotelVVA.AutoSize = true;
            this.lb_hotelVVA.Location = new System.Drawing.Point(64, 58);
            this.lb_hotelVVA.Name = "lb_hotelVVA";
            this.lb_hotelVVA.Size = new System.Drawing.Size(94, 17);
            this.lb_hotelVVA.TabIndex = 6;
            this.lb_hotelVVA.Text = "HOTEL VVA :";
            // 
            // lb_coBase
            // 
            this.lb_coBase.AutoSize = true;
            this.lb_coBase.Location = new System.Drawing.Point(325, 41);
            this.lb_coBase.Name = "lb_coBase";
            this.lb_coBase.Size = new System.Drawing.Size(0, 17);
            this.lb_coBase.TabIndex = 12;
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(599, 365);
            this.Controls.Add(this.lb_coBase);
            this.Controls.Add(this.bt_connexion);
            this.Controls.Add(this.lb_mdp);
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.tb_mdp);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_hotelVVA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConnexion";
            this.Load += new System.EventHandler(this.FormConnexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_connexion;
        private System.Windows.Forms.Label lb_mdp;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.TextBox tb_mdp;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lb_hotelVVA;
        private System.Windows.Forms.Label lb_coBase;
    }
}

