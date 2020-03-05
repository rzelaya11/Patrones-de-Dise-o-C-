using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Dessign_Pattern
{
	public class BarnesAndNobleInfoStrategy : VendedorInfoStrategy
	{
		public override double ObtenerPrecio(string Isbn){
		// {To-do} implementar llamado al API del retail para obtener el precio
			return 23;
		}
		public override string obtenerUrl(string Isbn)
		{
			// {To-do } implementar llamado al API del retail para obtener URL
			return "www.barnesandnoble.com/{" + Isbn + "}";
		}
	}
}
