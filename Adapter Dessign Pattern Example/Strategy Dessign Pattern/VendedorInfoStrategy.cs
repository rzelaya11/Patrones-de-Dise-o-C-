using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Dessign_Pattern
{
	public abstract class VendedorInfoStrategy
	{
		public abstract double ObtenerPrecio(string Isbn);
		public virtual List<String> obtenerRecomendaciones() { return new List<String>(); }
		public double getDiscount(double porcentaje, string isbn) {
			return ObtenerPrecio(isbn) * porcentaje / 100;
		}

		public abstract string obtenerUrl(string Isbn);
	}
}
