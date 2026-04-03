internal class Program
{
    private static void Main(string[] args)
    {
        bool Salir = false;
        while (!Salir)
        {
            //Menu Principal
            Console.WriteLine("-------Menu Principal-------");
            Console.WriteLine(" 1 Menu Clientes");
            Console.WriteLine(" 2 Menu Productos");

            Console.Write("Seleccione una opcion ");
            string Opcion = Console.ReadLine();

            //Validacion

            if (string.IsNullOrWhiteSpace(Opcion))
            {
                Console.WriteLine("Debe ingresar una opcion");
                continue;
            }

            if (Opcion != "1" && Opcion != "2")
            {
                Console.WriteLine("Opcion invalida. Intente nuevamente");
                continue;
            }

            switch (Opcion)
            {
                //Menu Clientes
                case "1":
                    Console.Clear();
                    bool SalirCliente = false;
                    while (!SalirCliente)
                    {
                        Console.WriteLine("-------Menu Clientes-------");
                        Console.WriteLine(" 1 Dar alta a cliente");
                        Console.WriteLine(" 2 Dar Baja a cliente");
                        Console.WriteLine(" 3 Buscar cliente");
                        Console.WriteLine(" 4 Atras");

                        Console.Write("Seleccione una opción: ");
                        string OpcionCliente = Console.ReadLine();

                        //Validacion

                        if (string.IsNullOrWhiteSpace(OpcionCliente))
                        {
                            Console.WriteLine("Debe ingresar una opcion");
                            continue;
                        }

                        if (OpcionCliente != "1" && OpcionCliente != "2" && OpcionCliente != "3" && OpcionCliente != "4")
                        {
                            Console.WriteLine("Opcion invalida. Intente nuevamente");
                            continue;
                        }

                        switch (OpcionCliente)
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
                                Console.WriteLine("Desea Volver a Menu Principal?");
                                string OpcionSalirCliente = Console.ReadLine();

                                //Validacion

                                if (string.IsNullOrWhiteSpace(OpcionSalirCliente))
                                {
                                    Console.WriteLine("Debe ingresar una opcion");
                                    continue;
                                }

                                if (OpcionSalirCliente != "S" && OpcionSalirCliente != "N")
                                {
                                    Console.WriteLine("Opcion invalida. Intente nuevamente");
                                    continue;
                                }
                                SalirCliente = true;
                                break;
                        }

                    }

                    break;

                //Menu Productos
                case "2":
                    bool SalirProductos = false;
                    while (!SalirProductos)
                    {
                        //Menu Principal
                        Console.WriteLine("-------Menu de Productos-------");
                        Console.WriteLine(" 1 Agregar Producto");
                        Console.WriteLine(" 2 Eliminar Producto");
                        Console.WriteLine(" 3 Modificar Producto");
                        Console.WriteLine(" 4 Salir");

                        Console.Write("Seleccione una opcion");
                        string OpcionProductos = Console.ReadLine();

                        //Validacion

                        if (string.IsNullOrWhiteSpace(OpcionProductos))
                        {
                            Console.WriteLine("Debe ingresar una opcion");
                            continue;
                        }

                        if (OpcionProductos != "1" && OpcionProductos != "2" && OpcionProductos != "3" && OpcionProductos != "4")
                        {
                            Console.WriteLine("Opcion invalida. Intente nuevamente");
                            continue;
                        }
                        switch (OpcionProductos)
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
                                Console.WriteLine("Desea Volver a Menu Principal?");
                                string OpcionSalirProducto = Console.ReadLine();

                                //Validacion

                                if (string.IsNullOrWhiteSpace(OpcionSalirProducto))
                                {
                                    Console.WriteLine("Debe ingresar una opcion");
                                    continue;
                                }

                                if (OpcionSalirProducto != "S" && OpcionSalirProducto != "N")
                                {
                                    Console.WriteLine("Opcion invalida. Intente nuevamente");
                                    continue;
                                }
                                SalirProductos = true;
                                break;
                                


                            }
                    }
                break;

            }
        }
    }
}