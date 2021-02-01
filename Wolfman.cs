using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3_2
{
	class Wolfman : Wolf, IPerson
	{
		// public override string DoSound => Talk();
		public bool ÄrVargmänniska { get; set; }
		public Wolfman(bool ärVargmänniska, string frånLand, string namn, int längd, int vikt, int ålder) :
			base(frånLand, namn, längd, vikt, ålder)
		{
			ÄrVargmänniska = ärVargmänniska;
		}
		public string Talk()
		{
			return "Ja, en sån kan yla som en varg.";
		}
	}
}
