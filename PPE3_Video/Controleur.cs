using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3_Video
{
	class Controleur
	{
		private static VideoPPE3Groupe4Entities maConnexion;

		public static VideoPPE3Groupe4Entities Connexion { get => maConnexion; set => maConnexion = value; }

		public static void Init()
		{
			Connexion = new VideoPPE3Groupe4Entities();
		}

		public static object Liste(int fenêtre)
		{
			switch (fenêtre)
			{
				case 1:
					return Connexion.client.ToList();
				case 2:
					return Connexion.genre.ToList();
				case 3:
					return Connexion.support.ToList();
				case 4:
					return Connexion.client.ToList();
				case 5:
					return Connexion.client.ToList();
				case 6:

			}
			return null;
		}


	}
}
