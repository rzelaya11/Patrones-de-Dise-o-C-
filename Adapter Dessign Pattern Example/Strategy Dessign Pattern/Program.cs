using System;

namespace Strategy_Dessign_Pattern
{
	class Program
	{
		static void Main(string[] args)
		{
			VendedorDeLibro vendedor1 = new VendedorDeLibro(new AmazonRetailInfoStrategy(), "Amazon");
			VendedorDeLibro vendedor2 = new VendedorDeLibro(new BarnesAndNobleInfoStrategy(), "Barnes&Noble");
			VendedorDeLibro vendedor3 = new VendedorDeLibro(new IndieBoundInfoStrategy(), "Amazon");
			Console.WriteLine(vendedor1.ObtenerInfoDeLibro("123456"));
			Console.WriteLine(vendedor2.ObtenerInfoDeLibro("123456"));
			Console.WriteLine(vendedor3.ObtenerInfoDeLibro("123456"));
		}
	}
}
