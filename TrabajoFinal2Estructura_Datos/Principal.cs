using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace TrabajoFinal2Estructura_Datos
{
    class Principal
    {
        public Queue<int> miCola; //atributo comparte en diferentes funciones en diferentes clases; se le agrega el tipo para que traiga la func revers

        public void Crear_Cola()
        {
            miCola = new Queue<int>(); // cración de Cola en atributo
            Console.WriteLine("Se creo la Cola ");
        }


        public void Borrar_Cola()
        {
            if (miCola == null)
            {
                Console.WriteLine("No hay cola, favor crear cola opción 1 ");
            }

            else
            {
                miCola.Clear();
                Console.WriteLine("La cola fue eliminada ");
            }

        }

        public void Agregar_Pedido()
        {
            if (miCola == null)
            {
                Console.WriteLine("No hay cola. Crea la cola con opción 1 ");
            }

            else
            {
                Console.WriteLine("Ingrese pedido ");
                string pedido = Console.ReadLine();
                int pedidos = 0;


                bool EsNumero = int.TryParse(pedido, out pedidos); //out salida del entero, resultado se guarada booleano para usar en validaciones V o F resultado
                while (!EsNumero)// cuando no se puede convertir en int queda en F, tenemos la negacion conviert el F o V y entra al while

                {
                    Console.WriteLine("\n\nEl pedido no es un número");
                    Console.WriteLine("\n\nIngrese nuevamente el pedido");
                    pedido = Console.ReadLine();
                    EsNumero = int.TryParse(pedido, out pedidos);
                }
                //cuando lo puede convertir a numero es falso

                miCola.Enqueue(pedidos);


            }


        }
        public void Borrar_Pedido()
        {

            if (miCola == null)
            {
                Console.WriteLine("No hay cola o no hay pedidos para borrar ");
            }

            else
            {
                int Borrado_elemento = 0;

                Console.WriteLine("Cual No. de pedido desea borrar? ");
                string Element_borrar = Console.ReadLine();

                int.TryParse(Element_borrar, out Borrado_elemento);
                Queue<int> Recorrer_Cola = new Queue<int>(); // creo nueva cola

                while (miCola.Count > 0)
                {
                    if ((int)miCola.Peek() == Borrado_elemento) //Peek devuelve un elemento y se converte a entero.  Se compara primer elemento con 
                    {
                        miCola.Dequeue();// elemento que se eliminar
                    }
                    else
                    {

                        Recorrer_Cola.Enqueue((int)miCola.Dequeue()); //elemento que se enconlan en la nueva cola cuando no es la opcion seleccionada

                    }
                }
                miCola = Recorrer_Cola; // se reemplaza  cola

                Console.WriteLine("El No. de pedido {0} fue eliminado de la cola ", Element_borrar);
                //como hacer una obcion de menu volver a elegir otra opcion y q no se termine otra arriba falta el while cuando la opcion es respues si
                //q sea swicht y cuando eleija laopcion salir se frena q sea while true

            }

        }

        public void Listar_Pedidos()
        {
            if (miCola == null)
            {
                Console.WriteLine("No hay cola. Crea la cola con opción 1 ");
            }

            else
            {
                foreach (var elem in miCola)
                {

                    Console.WriteLine("Su pedido es: {0} ", elem);
                }
            }

        }

        public void listar_Ultimo_Pedido()
        {
            if (miCola == null)
            {
                Console.WriteLine("No hay cola. Crea la cola con opción 1 ");
            }

            else
            {

                miCola = new Queue<int>(miCola.Reverse()); // reverse devuelve una cola
                int pedido_ulti = miCola.Peek();
                miCola = new Queue<int>(miCola.Reverse());//vuelven las pocisiones al estado original
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("El último pedido es {0}", pedido_ulti);
                Console.ResetColor();
            }

        }

        public void borar_Ultimo_Pedido()
        {
            if (miCola == null)
            {
                Console.WriteLine("No hay cola. Crea la cola con opción 1 ");
            }

            else
            {
                miCola = new Queue<int>(miCola.Reverse());
                int ultimo_pedido = miCola.Dequeue();// saca el ultimo pedido
                miCola = new Queue<int>(miCola.Reverse());//vuelven las pocisiones al estado original
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Se eliminó último pedido de la lista");
                Console.ResetColor();
            }

        }

        public void listar_Primer_Pedido()

        {
            if (miCola == null)
            {
                Console.WriteLine("No hay cola. Crea la cola con opción 1 ");
            }

            else
            {
                int primer_pedido = miCola.Peek();//Muestra el primer elemento sin eliminarlo
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("El {0}, es el primer pedido de la lista", primer_pedido);
                Console.ResetColor();
            }

        }

        public void Cantidad_pedidos()
        {
            if (miCola == null)
            {
                Console.WriteLine("No hay cola o no a ingresado pedidos ");
            }

            else
            {
                int cantid_pedid = miCola.Count();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("El total de pedidos es de {0}", cantid_pedid);
                Console.ResetColor();
            }

        }

        public void Buscar_pedido()
        {
            if (miCola == null)
            {
                Console.WriteLine("No hay cola o no a ingresado pedidos ");
            }

            else
            {
                Console.WriteLine("Cual pedido desea buscar? ");
                string buscar_pedido = Console.ReadLine();
                int buscar = 0;
                int.TryParse(buscar_pedido, out buscar); // lo convierto en numero
                int numers = 0; // contador


                if (miCola.Contains(buscar)) // Determina si el elemento se encuentra dentro de la cola
                {
                    foreach (var item in miCola) //foreach recorre por cada elemento que contiene la cola
                    {
                        if (item == buscar)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("El pedido se encuentra en la pocisión {0}", numers + 1);
                            Console.ResetColor();
                        }
                        numers++;
                    }
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine("El pedido no se encuentra en la lista");
                }
            }

        }
        public void imprimir_csv()
        {
            if (miCola == null)
            {
                Console.WriteLine("No hay cola. Crea la cola con opción 1 ");
            }

            else
            {
                TextWriter archivo;
                archivo = new StreamWriter("miCola.txt");
                foreach (var elem in miCola)
                {
                    archivo.WriteLine(elem);
                }

                archivo.Close();
                Console.WriteLine("Se a guardado el archivo. ");
                Console.ReadKey();

            }


        }
    }

}
