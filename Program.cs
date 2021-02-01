using System;
using System.Collections.Generic;

namespace Övning_3_2
{
	class Program
	{
		static void Main(string[] args)
		{

			Animal horse = new Horse(190, "Svarten", 250, 550, 12);
			Animal dog = new Dog("Tax", "Pass", 120, 20, 7);
			Animal wolf = new Wolf("Sverige", "Kalle", 200, 50, 18);
			Animal pelican = new Pelican(15, true, "StorNäbb", 100, 7, 2);

			List<Animal> animals = new List<Animal>()
			{
				horse,
				dog,
				wolf,
				pelican
			};

			foreach (Animal animal in animals)
			{
				Console.WriteLine(animal);
			}
		}
	}
}
