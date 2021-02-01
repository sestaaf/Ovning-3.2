using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3_2
{
	class Flamingo : Bird
	{
		public int BenLängd { get; set; }
		public Flamingo(int benLängd, bool kanFlyga, string namn, int längd, int vikt, int ålder) : base(kanFlyga, namn, längd, vikt, ålder)
		{
			BenLängd = benLängd;
		}
		public override string Stats()
		{
			var result = new StringBuilder();
			result.AppendLine(base.Stats() + ", Benlängd: " + BenLängd);

			return result.ToString();
		}
	}
}
