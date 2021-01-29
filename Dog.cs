using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3.2
{
	class Dog : Animal
	{
	public override string DoSound => "En hund skäller.";

		public int Ras { get; set; }
		public Dog(int ras, string namn, int längd, int vikt, int ålder) : base(namn, längd, vikt, ålder)
		{
			Ras = ras;
		}
	}
}
