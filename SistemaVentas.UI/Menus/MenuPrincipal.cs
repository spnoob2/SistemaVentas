using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.UI.Helpers;

namespace SistemaVentas.UI.Menus
{
    public class MenuPrincipal
    {
        MenuClientes menuclientes = new MenuClientes();
        MenuProductos menuproductos = new MenuProductos();

        public void MostrarMenuPrincipal()
        {
            bool salir = false;
            while (!salir)
            {
                //Menu Principal
                Console.WriteLine("\n\n-------Menu Principal-------");
                Console.WriteLine(" 1 Menu Clientes");
                Console.WriteLine(" 2 Menu Productos");

                Console.Write("\n\nSeleccione una opcion ");

                //Validacion

                string opcion = InputHelper.LeerOpcionValida(new List<string> { "1", "2" });

                if (opcion == null) continue;

                switch (opcion)
                {
                    //Menu Clientes
                    case "1":
                        menuclientes.MostrarMenuClientes();
                    break;

                    case "2":
                    menuproductos.MostrarMenuProdutos();
                    break;

                }
            }
        }
    }
}
       