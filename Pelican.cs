using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3_2
{
	class Pelican : Bird
	{
		public int NäbbVolym { get; set; }
		public Pelican(int näbbVolym, bool kanFlyga, string namn, int längd, int vikt, int ålder) : base(kanFlyga, namn, längd, vikt, ålder)
		{
			NäbbVolym = näbbVolym;
		}
		public override string Stats()
		{
			var result = new StringBuilder();
			result.AppendLine(base.Stats() + ", Näbbvolym: " + NäbbVolym);

			return result.ToString();
		}
	}
}
