using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3_2
{
	class Dog : Animal
	{
	public override string DoSound => "En hund skäller.";

		public string Ras { get; set; }
		public Dog(string ras, string namn, int längd, int vikt, int ålder) : base(namn, längd, vikt, ålder)
		{
			Ras = ras;
		}
		public override string Stats()
		{
			var result = new StringBuilder();
			result.AppendLine(base.Stats() + "Ras: " + Ras);

			return result.ToString();
		}
	}
}
