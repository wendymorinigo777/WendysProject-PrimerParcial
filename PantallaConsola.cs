using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPTATIVO_III
{



    public class Menu:CRUD
    {
        string opcion_menu = "";
        public void iniciar()
        {
            do
            {
                cabezeraMenu();

            } while (opcion_menu != "0");
        }

        private void cabezeraMenu()
        {
            Console.WriteLine("~~~~Selección de la Base de Datos~~~~~");
            Console.WriteLine("\n");
            Console.WriteLine("~~~~Menu Principal~~~~");
            Console.WriteLine("\n");
            Console.WriteLine("1 [  Ciudad  ]  | 3 [Cliente]");
            Console.WriteLine("2 [ Persona  ]  | 4 [Cuentas]");
            Console.WriteLine("5 [Movimientos] | 0 [ Salir ]");
            Console.WriteLine("Seleccione la tabla que desea revisar");
            opcion_menu = Console.ReadLine();
            seleccion_menu1(opcion_menu);
        }

        private void seleccion_menu1(string op)
        {
            if (op == "")
                return;
            switch (op)
            {
                case "1":
                    Console.Clear();
                    cabezeraCiudad();
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    cabezeraPersona();
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    cabezeraCliente();
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    cabezeraCuenta();
                    Console.ReadKey();
                    break;
                case "5":
                    Console.Clear();
                    cabezeraMovimiento();
                    Console.ReadKey();
                    break;
                case "r":
                    Console.Clear();
                    cabezeraMenu();
                    Console.ReadKey();
                    break;
                case "0":
                    Environment.Exit(0);  
                    break;

                default:
                    Console.WriteLine("Selección Inválida");
                    break;
            }
        }




        private void cabezeraCiudad()
        {
            Console.WriteLine("~~~~Control de Ciudad~~~~");
            Console.WriteLine("\n");
            Console.WriteLine("~~~~Menu De Tabla~~~~");
            Console.WriteLine("\n");
            Console.WriteLine("1 [ Crear registro  ] | 3 [Eliminar registro]");
            Console.WriteLine("2 [Lista de Ciudades] | 4 [Modificar Ciudad]");
            Console.WriteLine("5 [  Buscar Ciudad  ] | 0 [      Salir     ]");
            Console.WriteLine("Seleccione una opción");
            opcion_menu = Console.ReadLine();
            seleccion_menu(opcion_menu);
        }

        private void seleccion_menu(string op)
        {
            if (op == "")
                return;
            switch(op)
            {
                case "1":
                    Console.Clear();
                    Crear_Ciudad();
                    retornar_menu(); 
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    lista();
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    Eliminar();
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    Modificar();
                    retornar_menu();
                    Console.ReadKey();
                    break;

                case "5":
                    Console.Clear();
                    imprimir();
                    retornar_menu();
                    Console.ReadKey();
                    break;

                case "r":
                    Console.Clear();
                    cabezeraCiudad();
                    Console.ReadKey();
                    break;

                case "0":
                    Console.Clear();
                    cabezeraMenu();
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Selección Inválida");
                    break;
            }
        }



        private void cabezeraPersona()
        {
            Console.WriteLine("~~~~Control de Persona~~~~");
            Console.WriteLine("\n");
            Console.WriteLine("~~~~Menu De Tabla~~~~");
            Console.WriteLine("\n");
            Console.WriteLine("1 [ Crear registro  ] | 3 [Eliminar registro]");
            Console.WriteLine("2 [Lista de Personas] | 4 [Modificar Persona]");
            Console.WriteLine("5 [ Buscar Persona  ] | 0 [     Salir       ]");
            Console.WriteLine("Seleccione una opción");
            opcion_menu = Console.ReadLine();
            seleccion_menuPersona(opcion_menu);
        }

        private void seleccion_menuPersona(string op)
        {
            if (op == "")
                return;
            switch (op)
            {
                case "1":
                    Console.Clear();
                    Crear_Persona();
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    lista_Persona();
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    Eliminar_Persona();
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    Modificar_Persona();
                    retornar_menu();
                    Console.ReadKey();
                    break;

                case "5":
                    Console.Clear();
                    imprimir_Persona();
                    retornar_menu();
                    Console.ReadKey();
                    break;

                case "r":
                    Console.Clear();
                    cabezeraPersona();
                    Console.ReadKey();
                    break;

                case "0":
                    Console.Clear();
                    cabezeraMenu();
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Selección Inválida");
                    break;
            }
        }




        private void cabezeraCliente()
        {
            Console.WriteLine("~~~~Control de Cliente~~~~");
            Console.WriteLine("\n");
            Console.WriteLine("~~~~Menu De Tabla~~~~");
            Console.WriteLine("\n");
            Console.WriteLine("1 [ Crear registro  ] | 3 [Eliminar registro]");
            Console.WriteLine("2 [Lista de Clientes] | 4 [Modificar Cliente]");
            Console.WriteLine("5 [ Buscar Cliente  ] | 0 [      Salir      ]");
            Console.WriteLine("Seleccione una opción");
            opcion_menu = Console.ReadLine();
            seleccion_menuCliente(opcion_menu);
        }

        private void seleccion_menuCliente(string op)
        {
            if (op == "")
                return;
            switch (op)
            {
                case "1":
                    Console.Clear();
                    Crear_Cliente();
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    lista_Cliente();
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    Eliminar_Cliente();
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    Modificar_Cliente();
                    retornar_menu();
                    Console.ReadKey();
                    break;

                case "5":
                    Console.Clear();
                    imprimir_Cliente();
                    retornar_menu();
                    Console.ReadKey();
                    break;

                case "r":
                    Console.Clear();
                    cabezeraCliente();
                    Console.ReadKey();
                    break;

                case "0":
                    Console.Clear();
                    cabezeraMenu();
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Selección Inválida");
                    break;
            }
        }



        private void cabezeraCuenta()
        {
            Console.WriteLine("~~~~Control de Cuenta~~~~");
            Console.WriteLine("\n");
            Console.WriteLine("~~~~Menu De Tabla~~~~");
            Console.WriteLine("\n");
            Console.WriteLine("1 [ Crear registro ] | 3 [Eliminar registro]");
            Console.WriteLine("2 [Lista de Cuentas] | 4 [Modificar Cuenta]");
            Console.WriteLine("5 [ Buscar Cuenta  ] | 0 [    Salir       ] ");
            Console.WriteLine("Seleccione una opción");
            opcion_menu = Console.ReadLine();
            seleccion_menuCuenta(opcion_menu);
        }

        private void seleccion_menuCuenta(string op)
        {
            if (op == "")
                return;
            switch (op)
            {
                case "1":
                    Console.Clear();
                    Crear_Cuenta();
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    lista_Cuenta();
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    Eliminar_Cuenta();
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    Modificar_Cuenta();
                    retornar_menu();
                    Console.ReadKey();
                    break;

                case "5":
                    Console.Clear();
                    imprimir_Cuenta();
                    retornar_menu();
                    Console.ReadKey();
                    break;

                case "r":
                    Console.Clear();
                    cabezeraCuenta();
                    Console.ReadKey();
                    break;

                case "0":
                    Console.Clear();
                    cabezeraMenu();
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Selección Inválida");
                    break;
            }
        }



        private void cabezeraMovimiento()
        {
            Console.WriteLine("~~~~Control de Movimientos~~~~");
            Console.WriteLine("\n");
            Console.WriteLine("~~~~Menu De Tabla~~~~");
            Console.WriteLine("\n");
            Console.WriteLine("1 [   Crear registro    ] | 3 [Eliminar registro]");
            Console.WriteLine("2 [Lista de Movimientos ] | 4 [Modificar Movimiento]");
            Console.WriteLine("5 [ Buscar Movimiento   ] | 0 [       Salir        ]");
            Console.WriteLine("Seleccione una opción");
            opcion_menu = Console.ReadLine();
            seleccion_menuMovimiento(opcion_menu);
        }

        private void seleccion_menuMovimiento(string op)
        {
            if (op == "")
                return;
            switch (op)
            {
                case "1":
                    Console.Clear();
                    Crear_Movimiento();
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    lista_Movimiento();
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    Eliminar_Movimiento();
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    Modificar_Movimiento();
                    retornar_menu();
                    Console.ReadKey();
                    break;

                case "5":
                    Console.Clear();
                    imprimir_Movimiento();
                    retornar_menu();
                    Console.ReadKey();
                    break;

                case "r":
                    Console.Clear();
                    cabezeraMovimiento();
                    Console.ReadKey();
                    break;

                case "0":
                    Console.Clear();
                    cabezeraMenu();
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Selección Inválida");
                    break;
            }
        }

        private void retornar_menu()
        {
            string op;
            Console.WriteLine("Presione R para retornar al menu principal");
            op = Console.ReadLine();
            seleccion_menu(op);
        }
    }
}
