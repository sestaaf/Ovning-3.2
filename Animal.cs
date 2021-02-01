using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3_2
{
	abstract class Animal
	{
		// 3.2.14: Om ALLA djur ska få ett nytt attribut läggs det i den här klassen.

		public string Namn { get; set; }
		public int Längd { get; set; }
		public int Vikt { get; set; }
		public int Ålder { get; set; }

		public abstract string DoSound { get; }

		public virtual string Stats()
		{
			return $"Namn: {Namn}, Längd: {Längd}, Vikt: {Vikt}, Ålder: {Ålder}";
		}

		public Animal(string namn, int längd, int vikt, int ålder)
		{
			Namn = namn;
			Längd = längd;
			Vikt = vikt;
			Ålder = ålder;
		}
	}
}
