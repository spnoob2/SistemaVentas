using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.UI.Helpers;

namespace SistemaVentas.UI.Menus
{
    internal class MenuProductos
    {
        public void MostrarMenuProdutos()
        {
            Console.Clear();
            bool salirproductos = false;
            while (!salirproductos)
            {
                //Menu Productos
                Console.WriteLine("\n\n-------Menu de Productos-------");
                Console.WriteLine(" 1 Agregar Producto");
                Console.WriteLine(" 2 Eliminar Producto");
                Console.WriteLine(" 3 Modificar Producto");
                Console.WriteLine(" 4 Salir");

                Console.Write("\n\nSeleccione una opcion");

                //Validacion

                string opcionproductos = InputHelper.LeerOpcionValida(new List<string> { "1", "2", "3","4" });

                if (opcionproductos == null) continue;

                switch (opcionproductos)
                {
                    case "1":
                        //Invocar a SistemaVentas.Services
                        break;
                    case "2":
                        //Invocar a SistemaVentas.Services
                        break;
                    case "3":
                        //Invocar a SistemaVentas.Services
                        break;
                    case "4":
                        Console.Clear();
                        salirproductos = true;
                        break;
                }
            }
        }
    }
}
