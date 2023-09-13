using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPrecio.BE
{
    public class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public void Agregar (string aCodigo,
                             string aNombre,
                             string aPrecio) 
        { 
            Codigo = aCodigo;
            Nombre = aNombre;
            Precio = Convert.ToDecimal(aPrecio);
        }

        public string Listar() 
        {
            string Res = "";
            Res = Codigo + " - " + Nombre + " - " + Precio.ToString();

            return Res; 
        }

    }
}
