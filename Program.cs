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
			Animal wolfman = new Wolfman(true, "Ryssland", "VargPelle", 190, 100, 25);

			List<Animal> animals = new List<Animal>()
			{
				horse,
				dog,
				wolf,
				pelican,
				wolfman
			};

			foreach (Animal animal in animals)
			{
				Console.WriteLine($"Djur: {animal.GetType().Name}.");
				Console.WriteLine(animal.DoSound);

				if (animal is IPerson)
				{
					var person = (IPerson)animal;
					Console.WriteLine($"{person.Talk()}");
				}
			}

			var dog2 = (Dog)dog;
			
			List<Dog> dogs = new List<Dog>
			{
				dog2//,
				//horse
				
				// 3.3.9: Att det inte går att lägga till en horse i dog-lista
				// beror på att typen inte är samma (är Animal, borde vara Dog).
				// 3.3.10: För att alla djur ska kunna lagras i samma lista måste  
				// typen vara Animal(se ovan).
			};

			// 3.3.13: foreach-loopen nedan tar ett djur i taget och skriver ut dess 
			// egenskaper enligt så som egenskaperna är listade för varje djur.
			foreach (Animal animal in animals)
			{
				Console.WriteLine($"\nDjur {animal.GetType().Name}'s Egenskaper:");
				Console.WriteLine(animal.Stats()); 
			}

			foreach (Animal dogAnimal in animals)
			{
				if (dogAnimal is Dog)
				{
					var dogInList = (Dog)dogAnimal;
					Console.WriteLine($"Djur {dogInList.GetType().Name}'s Egenskaper:");
					Console.WriteLine(dogInList.Stats());
				}
			}
		}
	}
}
