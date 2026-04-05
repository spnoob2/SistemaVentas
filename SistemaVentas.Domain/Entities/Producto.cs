using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Domain.Entities
{
    public class Producto
    {
        public string Nombre { get; set; }
        public Decimal Precio { get; set; }
        public int Idproducto { get; set; }
        public int Stock { get; set; }



        public Producto(string nombre, Decimal precio, int idproducto, int stock )
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("El nombre no puede estar vacío");
            Nombre = nombre;
            Precio = precio;
            Idproducto= idproducto;
            Stock = stock;
        }
    }
}
