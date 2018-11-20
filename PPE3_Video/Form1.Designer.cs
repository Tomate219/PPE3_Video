namespace PPE3_Video
{
    partial class FormAcceuil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parRéférenceEmpruntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parDateAbonnementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validationDunCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vérificationDunCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermetureDunCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDunCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.composantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.rechercheToolStripMenuItem,
            this.compteToolStripMenuItem,
            this.composantsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // rechercheToolStripMenuItem
            // 
            this.rechercheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parGenreToolStripMenuItem,
            this.parSupportToolStripMenuItem,
            this.parClientToolStripMenuItem,
            this.parRéférenceEmpruntToolStripMenuItem,
            this.parDateAbonnementToolStripMenuItem});
            this.rechercheToolStripMenuItem.Name = "rechercheToolStripMenuItem";
            this.rechercheToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.rechercheToolStripMenuItem.Text = "Recherches";
            // 
            // parGenreToolStripMenuItem
            // 
            this.parGenreToolStripMenuItem.Name = "parGenreToolStripMenuItem";
            this.parGenreToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.parGenreToolStripMenuItem.Text = "Par Genre";
            // 
            // parSupportToolStripMenuItem
            // 
            this.parSupportToolStripMenuItem.Name = "parSupportToolStripMenuItem";
            this.parSupportToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.parSupportToolStripMenuItem.Text = "Par Support";
            // 
            // parClientToolStripMenuItem
            // 
            this.parClientToolStripMenuItem.Name = "parClientToolStripMenuItem";
            this.parClientToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.parClientToolStripMenuItem.Text = "Par Client";
            // 
            // parRéférenceEmpruntToolStripMenuItem
            // 
            this.parRéférenceEmpruntToolStripMenuItem.Name = "parRéférenceEmpruntToolStripMenuItem";
            this.parRéférenceEmpruntToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.parRéférenceEmpruntToolStripMenuItem.Text = "Par Référence Emprunt";
            // 
            // parDateAbonnementToolStripMenuItem
            // 
            this.parDateAbonnementToolStripMenuItem.Name = "parDateAbonnementToolStripMenuItem";
            this.parDateAbonnementToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.parDateAbonnementToolStripMenuItem.Text = "Par date Abonnement";
            // 
            // compteToolStripMenuItem
            // 
            this.compteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validationDunCompteToolStripMenuItem,
            this.vérificationDunCompteToolStripMenuItem,
            this.fermetureDunCompteToolStripMenuItem,
            this.ajoutDunCompteToolStripMenuItem});
            this.compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            this.compteToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.compteToolStripMenuItem.Text = "Comptes";
            // 
            // validationDunCompteToolStripMenuItem
            // 
            this.validationDunCompteToolStripMenuItem.Name = "validationDunCompteToolStripMenuItem";
            this.validationDunCompteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.validationDunCompteToolStripMenuItem.Text = "Validation d\'un compte";
            this.validationDunCompteToolStripMenuItem.Click += new System.EventHandler(this.validationDunCompteToolStripMenuItem_Click);
            // 
            // vérificationDunCompteToolStripMenuItem
            // 
            this.vérificationDunCompteToolStripMenuItem.Name = "vérificationDunCompteToolStripMenuItem";
            this.vérificationDunCompteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.vérificationDunCompteToolStripMenuItem.Text = "Vérification d\'un compte";
            this.vérificationDunCompteToolStripMenuItem.Click += new System.EventHandler(this.vérificationDunCompteToolStripMenuItem_Click);
            // 
            // fermetureDunCompteToolStripMenuItem
            // 
            this.fermetureDunCompteToolStripMenuItem.Name = "fermetureDunCompteToolStripMenuItem";
            this.fermetureDunCompteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.fermetureDunCompteToolStripMenuItem.Text = "Fermeture d\'un compte";
            this.fermetureDunCompteToolStripMenuItem.Click += new System.EventHandler(this.fermetureDunCompteToolStripMenuItem_Click);
            // 
            // ajoutDunCompteToolStripMenuItem
            // 
            this.ajoutDunCompteToolStripMenuItem.Name = "ajoutDunCompteToolStripMenuItem";
            this.ajoutDunCompteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ajoutDunCompteToolStripMenuItem.Text = "Ajout d\'un compte";
            this.ajoutDunCompteToolStripMenuItem.Click += new System.EventHandler(this.ajoutDunCompteToolStripMenuItem_Click);
            // 
            // composantsToolStripMenuItem
            // 
            this.composantsToolStripMenuItem.Name = "composantsToolStripMenuItem";
            this.composantsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.composantsToolStripMenuItem.Text = "Composants";
            // 
            // FormAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAcceuil";
            this.Text = "GestionVideo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem composantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parSupportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parRéférenceEmpruntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parDateAbonnementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validationDunCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vérificationDunCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermetureDunCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDunCompteToolStripMenuItem;
    }
}

