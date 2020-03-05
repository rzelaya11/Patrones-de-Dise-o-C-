using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Dessign_Pattern
{
	public class VendedorDeLibro
	{
		public string Nombre { get; set; }
		public double PorcentajeDescuento { get; set; }
		public VendedorInfoStrategy Info { get; set; }
		public VendedorDeLibro(VendedorInfoStrategy info, string nombre) {
			this.Info = info;
			this.Nombre = nombre;
		}
		public String ObtenerInfoDeLibro(string isbn) {
			List<string> recomendaciones = Info.obtenerRecomendaciones();
			return String.Format("--------Informacion de libro:{0}------------\n"+
								 "Nombre Vendedor: {1}\nprecio Libro: {2}\nURL:{3}\n{4}",
						isbn, 
						Nombre, 
						Info.ObtenerPrecio(isbn), 
						Info.obtenerUrl(isbn), 
						(recomendaciones.Count>0 ? "Cantidad Recomendaciones:"+recomendaciones.Count+"\n": "")
					);
		}

	}
}
