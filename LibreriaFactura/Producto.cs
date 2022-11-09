using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFactura
{
    public class Producto
    {
        public Producto()
        {
        }

        public Producto(string nombre, double precio, Categoria categoria, List<DetalleFactura> detallesFactura)
        {
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
            DetallesFactura = detallesFactura;
        }

        public string Nombre { get; set; }

        public double Precio { get; set; }

        public Categoria Categoria { get; set; }

        public List<DetalleFactura> DetallesFactura { get; set; }
    }
}
