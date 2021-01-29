using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3_2
{
	class Pelican : Bird
	{
		public int NäbbVolym { get; set; }
		public Swan(int näbbVolym, bool kanFlyga, string namn, int längd, int vikt, int ålder) : base(kanFlyga, namn, längd, vikt, ålder)
		{
			NäbbVolym = näbbVolym;
		}
	}
}
