using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Dessign_Pattern
{
	public class AmazonRetailInfoStrategy : VendedorInfoStrategy
	{
		public override double ObtenerPrecio(string Isbn){
		// {To-do} implementar llamado al API del retail para obtener el precio
			return 25;
		}

		
		public override List<string> obtenerRecomendaciones()
		{
		// {To-do } implementar llamado al API del retail para obtener las recomendaciones
			return new List<string>() { "9012383092381", "901238301234", "9012383095678" }; 
		}

		public override string obtenerUrl(string Isbn)
		{
			// {To-do } implementar llamado al API del retail para obtener URL
			return "www.amazon.com/{" + Isbn + "}";
		}
	}
}
