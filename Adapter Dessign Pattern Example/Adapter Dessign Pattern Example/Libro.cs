using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Dessign_Pattern_Example
{
	public class Libro
	{
		public Libro(string Isbn, string Ean, string DescripcionLarga, string DescripcionCorta, string Titulo)
		{
			this.Isbn = Isbn;
			this.Titulo = Titulo;
			this.DescripcionCorta = DescripcionCorta;
			this.DescripcionLarga = DescripcionLarga;
			this.Ean = Ean;
		}

		public string Isbn { get; set; }
		public string Ean { get; set; }
		public string DescripcionLarga { get; set; }
		public string DescripcionCorta { get; set; }
		public string Titulo { get; set; }

		
		public override string ToString() {
			return "ISBN:" + this.Isbn +
				"\nTitulo:" + this.Titulo +
				"\nEan:" + this.Ean +
				"\nDescripcionCorta:" + this.DescripcionCorta +
				"\nDescripcionLarga:" + this.DescripcionLarga;
		}
	}
}
