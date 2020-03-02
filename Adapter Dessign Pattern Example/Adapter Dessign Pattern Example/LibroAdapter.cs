using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Dessign_Pattern_Example
{
	public class LibroAdapter:Libro
	{
		private LibroLegacy instancia;

		public LibroAdapter(LibroLegacy instancia) 
		:base(instancia.Isbn.ToString(), instancia.Isbn10, instancia.DescripcionCorta, instancia.DescripcionCorta, instancia.Titulo)
		{
			this.instancia = instancia;
		}
		public string Isbn { 
			get { return instancia.Isbn.ToString(); }
		}
		public string Ean { get { return instancia.Isbn10; } }
		public string DescripcionLarga { get { return instancia.DescripcionCorta; } }
		public string DescripcionCorta { get { return instancia.DescripcionCorta; } }
		public string Titulo { get { return instancia.Titulo; } }
	}
}
