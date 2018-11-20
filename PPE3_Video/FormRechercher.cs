﻿using System;
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
	public partial class FormRechercher : Form
	{
		private bool chargement = true;
		public int fenêtre;
		public FormRechercher(int x)
		{
			InitializeComponent();
			fenêtre = x;
		}

		private void FormRechercher_Load(object sender, EventArgs e)
		{
			bsRecherche.DataSource = Controleur.Liste(fenêtre);
			dgRecherche.DataSource = bsRecherche;
			chargement = false;
			if (fenêtre == 1)
			{
				dgRecherche.Columns[1].HeaderText = "Id";
				dgRecherche.Columns[2].HeaderText = "Nom";
				dgRecherche.Columns[3].HeaderText = "Prénom";
				dgRecherche.Columns[4].HeaderText = "Adresse mail";
				dgRecherche.Columns[5].HeaderText = "Date d'abonement";
				dgRecherche.Columns[6].HeaderText = "Login";
				dgRecherche.Columns[7].HeaderText = "Mot de passe";
			}

		}
	}
}
