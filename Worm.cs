using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3_2
{
	class Worm : Animal
	{
		public override string DoSound => "En orm väser.";

		public bool ÄrGiftig { get; set; }
		public Worm(bool ärGiftig, string namn, int längd, int vikt, int ålder) : base(namn, längd, vikt, ålder)
		{
			ÄrGiftig = ärGiftig;
		}
	}
}
