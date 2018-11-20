using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_Video
{
	class Controleur
	{
		private static VideoPPE3Groupe4Entities Connexion { get => Connexion; set => Connexion = value; }

		public static void Init()
		{
			Connexion = new VideoPPE3Groupe4Entities();
		}

		public static object Liste(int fenêtre)
		{
			switch (fenêtre)
			{
				case 1:
					return Connexion.client.Tolist();
			}
		}


	}
}
