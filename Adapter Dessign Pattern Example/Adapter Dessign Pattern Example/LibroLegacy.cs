using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Dessign_Pattern_Example
{
	public class LibroLegacy
	{
		public LibroLegacy(double Isbn, string Isbn10, string DescripcionCorta, string Titulo)
		{
			this.Isbn = Isbn;
			this.Titulo = Titulo;
			this.DescripcionCorta = DescripcionCorta;
			this.Isbn10 = Isbn10;
		}

		public string Isbn10 { get; set; }
		public double Isbn { get; set; }
		public string DescripcionCorta { get; set; }
		public string Titulo { get; set; }
	}
}
