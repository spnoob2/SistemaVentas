using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.UI.Helpers;

namespace SistemaVentas.UI.Menus
{
    public class MenuClientes
    {
        public void MostrarMenuClientes() 
        {
            Console.Clear();
            bool salircliente = false;
            while (!salircliente)
            {
                Console.WriteLine("-------Menu Clientes-------");
                Console.WriteLine(" 1 Dar alta a cliente");
                Console.WriteLine(" 2 Dar Baja a cliente");
                Console.WriteLine(" 3 Buscar cliente");
                Console.WriteLine(" 4 Atras");

                Console.Write("\nSeleccione una opción: ");

                //Validacion

                string opcioncliente = InputHelper.LeerOpcionValida(new List<string> { "1", "2", "3","4" });

                if (opcioncliente == null) continue;

                switch (opcioncliente)
                {
                    case "1":
                        //Invocar a SistemaVentas.Service
                        break;

                    case "2":
                        //Invocar a SistemaVentas.Service

                        break;

                    case "3":
                        //Invocar a SistemaVentas.Service

                        break;

                    case "4":
                        Console.Clear();
                        salircliente = true;
                        break;
                }

            }


        }
    }
}
