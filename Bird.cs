using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3.2
{
	class Bird : Animal
	{
		public override string DoSound => "En fågel kvittrar.");

		public bool KanFlyga { get; set; }
		public Bird(bool kanFlyga, string namn, int längd, int vikt, int ålder) : base(namn, längd, vikt, ålder)
		{
			KanFlyga = kanFlyga;
		}
	}
}
