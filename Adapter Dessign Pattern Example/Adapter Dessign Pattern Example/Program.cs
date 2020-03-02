using System;
using System.Collections.Generic;

namespace Adapter_Dessign_Pattern_Example
{
	class Program
	{
		static void Main(string[] args)
		{
			LibroLegacy l1 = new LibroLegacy(9780590353427, "0590353427",
											"arry Potter has never been the star of a Quidditch team, scoring points while riding a broom far above the ground",
											 "Harry Potter and the Sorcerer's Stone");
			Libro l2 = new Libro("1607967774", "9781607967774", 
				@"Las mil y una noches es, sin lugar a dudas, el texto más popular de la literatura árabe y desde su introducción en Europa, 
				  se ha convertido en uno de los clásicos indiscutibles de la literatura de todos los tiempos. Se trata de una compilación 
					de cuentos del Oriente Medio, relatos fantásticos por los que desfilan héroes, villanos, reyes, mendigos, genios, magos y seres extraordinarios. 
					Nos muestra las exoticas ciudades de Oriente, los paisajes de lejanas tierras, los mercados, los puertos, las selvas... y viajaremos con sus 
					personajes sabiendo que olvidaremos en ocasiones el motivo y que nos dejaremos llevar por el paisaje y las emociones.",
				"Las mil y una noches es, sin lugar a dudas, el texto más popular de la literatura árabe, uno de los clásicos indiscutibles de la literatura de todos los tiempos",
				"Cuentos de Las Mil Y Una Noches");

			List<Libro> misLibros = new List<Libro>();
			misLibros.Add(new LibroAdapter(l1));
			misLibros.Add(l2);

			misLibros.ForEach(l => Console.WriteLine(l.ToString()));
		}
	}
}
