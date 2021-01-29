﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Övning_3.2
{
	class Horse : Animal
{
	public override string DoSound => "En häst gnäggar.";

	public int Mankhöjd { get; set; }
		public Horse(int mankhöjd, string namn, int längd, int vikt, int ålder) : base(namn, längd, vikt, ålder)
		{
			Mankhöjd = mankhöjd;
		}
	}
}