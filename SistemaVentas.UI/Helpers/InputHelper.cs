using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.UI.Helpers
{
    public static class InputHelper
    {
        public static string LeerOpcionValida(List<string> opcionesValidas)
        {
            string opcion = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(opcion))
            {
                Console.WriteLine("Debe ingresar una opción");
                return null;
            }

            if (!opcionesValidas.Contains(opcion))
            {
                Console.WriteLine("Opción inválida");
                return null;
            }

            return opcion;
        }
    }
}
