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
			result.AppendLine($"Ras: {Ras}, {base.Stats()}");

			return result.ToString();
		}
		
		// 3.3.17: Kommer inte åt nedanstående från Animal då ärvningen går åt andra hållet.
		//         Får också ett felmeddelande som jag inte fixar.

		//public string ExtraInfo()
		//{
		//	if (Ras == "Tax")
		//	{
		//		var result = new StringBuilder();
		//		result.AppendLine($"En {Ras} är lång och smal.");
		//		return result.ToString();
		//	}
		//}
	}
}
