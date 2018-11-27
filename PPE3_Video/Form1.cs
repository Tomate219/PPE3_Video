using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_Video
{
    public partial class FormAcceuil : Form
    {
		public FormAcceuil()
        {
            InitializeComponent();
			Controleur.Init();
        }

        private void validationDunCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormValiderCompte ValiderCompte = new FormValiderCompte();
            ValiderCompte.MdiParent = this ;
            ValiderCompte.Show();
        }

        private void vérificationDunCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVerifCompte VerifCompte = new FormVerifCompte();
            VerifCompte.MdiParent = this;
            VerifCompte.Show();
        }

        private void fermetureDunCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVerouillerCompte VerouillerCompte = new FormVerouillerCompte();
            VerouillerCompte.MdiParent = this;
            VerouillerCompte.Show();
        }

        private void ajoutDunCompteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutCompte AjouterCompte = new FormAjoutCompte();
            AjouterCompte.MdiParent = this;
            AjouterCompte.Show();
        }

		private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void parClientToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormRechercher vueClient = new FormRechercher(1);
			vueClient.Show();
		}

		private void parGenreToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormRechercher vueClient = new FormRechercher(2);
			vueClient.Show();
		}

		private void parSupportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormRechercher vueClient = new FormRechercher(3);
			vueClient.Show();
		}
	}
}