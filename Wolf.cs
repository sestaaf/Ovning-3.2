using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3_2
{
	class Wolf : Animal
	{
		public override string DoSound => "En varg ylar.";

		public string FrånLand { get; set; }
		public Wolf(string frånLand, string namn, int längd, int vikt, int ålder) : base(namn, längd, vikt, ålder)
		{
			FrånLand = frånLand;
		}
	}
}
