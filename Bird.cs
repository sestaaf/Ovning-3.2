using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3_2
{
	class Bird : Animal
	{
		// 3.2.13: Om alla fåglar ska få ett nytt attribut läggs det i den här klassen.
		
		public override string DoSound => "En fågel kvittrar, sjunger eller väser.";

		public bool KanFlyga { get; set; }
		public Bird(bool kanFlyga, string namn, int längd, int vikt, int ålder) : base(namn, längd, vikt, ålder)
		{
			KanFlyga = kanFlyga;
		}
		public override string Stats()
		{
			var result = new StringBuilder();
			result.AppendLine($"Kan flyga: {KanFlyga}, { base.Stats()}");

			return result.ToString();
		}
	}
}
