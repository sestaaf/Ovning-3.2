using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3_2
{
	class Swan : Bird
	{
		public string Färg { get; set; }
		public Swan(string färg, bool kanFlyga, string namn, int längd, int vikt, int ålder) : base(kanFlyga,namn, längd, vikt, ålder)
		{
			Färg = färg;
		}
	}
}
