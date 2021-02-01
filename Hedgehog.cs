using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3_2
{
	class Hedgehog : Animal
	{
		public override string DoSound => "En igelkott låteer som att den snarkar.";

		public int AntalTaggar { get; set; }
		public Hedgehog(int antalTaggar, string namn, int längd, int vikt, int ålder) : base(namn, längd, vikt, ålder)
		{
			AntalTaggar = antalTaggar;
		}
		public override string Stats()
		{
			var result = new StringBuilder();
			result.AppendLine($"Antal taggar: {AntalTaggar}, { base.Stats()}");

			return result.ToString();
		}
	}
}
