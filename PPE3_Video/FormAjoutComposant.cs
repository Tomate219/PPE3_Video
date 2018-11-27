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
    public partial class FormAjoutComposant : Form
    {
        private string cas;
        
        public FormAjoutComposant(string s)
        {
            InitializeComponent();
            Controleur.Init();
            cas = s;
        }

        private void FormAjoutComposant_Load(object sender, EventArgs e)
        {
           
        }

        public bool verifExist()
        {
            switch (cas)
            {
                case "genre":
                    //List<genre> a = ;
                    //dgRecherche.DataSource = bsRecherche;
                    bs.DataSource = Controleur.Liste(1);

                    foreach (genre l in bs)


                        break;
                case "film":
                    return Connexion.genre.ToList();
                case "série":
                    return Connexion.support.ToList();
                case "saison":
                    return Connexion.client.ToList();
                case "clien":
                    return Connexion.client.ToList();

            }



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
