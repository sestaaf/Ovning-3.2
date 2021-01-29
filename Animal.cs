using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3_2
{
	abstract class Animal
	{
		public string Namn { get; set; }
		public int Längd { get; set; }
		public int Vikt { get; set; }
		public int Ålder { get; set; }

		public abstract string DoSound { get; }

		public Animal(string namn, int längd, int vikt, int ålder)
		{
			Namn = namn;
			Längd = längd;
			Vikt = vikt;
			Ålder = ålder;
		}
	}
}
