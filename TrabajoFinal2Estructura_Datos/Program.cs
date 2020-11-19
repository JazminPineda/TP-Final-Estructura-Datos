using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrabajoFinal2Estructura_Datos
{
    class Program
    {


        static void Main(string[] args)
        {
            Principal metodos = new Principal(); //instancia de clase de las funciones principales
            int opcion_Nro = 0;
            while (opcion_Nro != 12)
            {
                string opcionUsuario;
                //Console.Clear();// Limpia pantalla
                Console.WriteLine(" \n");

                Console.WriteLine("Bienvenido a TU PedidO, que deseas hacer? ");
                Console.WriteLine("Menu Usuario: " +
                    "\n" +
                    "\n1 - Crear Cola" +
                    "\n2 - Eliminar Compra Cola " +
                    "\n3 - Agregar Pedido " +
                    "\n4 - Borrar Pedido" +
                    "\n5 - Listar todos los pedidos" +
                    "\n6 - Listar último Pedido" +
                    "\n7 - Listar primer Pedido " +
                    "\n8 - Cantidad de Pedido " +
                    "\n9 - Buscar Pedido" +
                    "\n10 - Borrar ultimo Pedido " +
                    "\n11 - Guardar archivo" +
                    "\n12 - Salir");

                Console.WriteLine("\nIngrese una opción:");
                opcionUsuario = Console.ReadLine();
                bool opop  = int.TryParse(opcionUsuario, out opcion_Nro);// Intenta convertirlo sino puede lo deja al valor inicial 
                Console.WriteLine(" \n");

                
                switch (opcion_Nro)
                {
                    case 1:
                        metodos.Crear_Cola();
                        break;

                    case 2:
                        metodos.Borrar_Cola();
                        break;

                    case 3:
                        metodos.Agregar_Pedido();
                        break;

                    case 4:
                        metodos.Borrar_Pedido();
                        break;

                    case 5:
                        metodos.Listar_Pedidos();
                        break;

                    case 6:
                        metodos.listar_Ultimo_Pedido();
                        break;

                    case 7:
                        metodos.listar_Primer_Pedido();
                        break;

                    case 8:
                        metodos.Cantidad_pedidos();
                        break;

                    case 9:
                        metodos.Buscar_pedido();
                        break;
                   
                    case 10:
                        metodos.borar_Ultimo_Pedido();
                        break;

                    case 11:
                        metodos.imprimir_csv();
                        break;

                    case 12:
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n Codigo invalido, volvé a intentarlo");
                        Thread.Sleep(2800);
                        Console.ResetColor();
                        break;
                }
            }



        }
        //no cerrar aplicacion


    }
}
