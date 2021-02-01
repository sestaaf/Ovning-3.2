using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3_2
{
	class Horse : Animal
	{
		public override string DoSound => "En häst gnäggar.";

		public int Mankhöjd { get; set; }
		
			public Horse(int mankhöjd, string namn, int längd, int vikt, int ålder) : base(namn, längd, vikt, ålder)
			{
				Mankhöjd = mankhöjd;
			}
		public override string Stats()
		{
			var result = new StringBuilder();
			result.AppendLine(base.Stats() + "Mankhöjd: " + Mankhöjd);

			return result.ToString();
		}
	}
}
