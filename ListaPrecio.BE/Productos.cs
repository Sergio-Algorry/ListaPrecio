using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPrecio.BE
{
    public class Productos
    {
        public Producto[] Lista { get; set; } = new Producto[10];
        private int fila = 0;

        public void Agregar(Producto aProd) 
        {
            Lista[fila] = aProd;
            fila = fila + 1;
        }

        public string Listar()
        {
            string res = "";

            for (int i = 0; i < fila; i++)
            {
                res = res + Lista[i].Listar() + "\r\n";
            }

            return res;
        }

        public Producto Buscar(string aCodigo) 
        { 
            for (int i = 0;i < fila; i++)
            {
                if (Lista[i].Codigo==aCodigo)
                {
                    return Lista[i];
                }
            }
            return null;
        }
    }
}
