using System;

namespace ArbolBinarioBusqueda
{
    class Program
    {
        class Nodo
        {
            public int informacion;
            public Nodo izquierda;
            public Nodo derecha;

            /// <summary>
            /// [cjocol]-09/04/2021 Constructor de la clase Nodo
            /// </summary>
            /// <param name="data">Dato a almacenar dentro de nodo</param>
            public Nodo(int data)
            {
                this.informacion = data;
                this.izquierda = null;
                this.derecha = null;
            }

            /// <summary>
            /// [cjocol]-09/04/2021 Método encargado de agregar un nodo al árbol
            /// </summary>
            /// <param name="root">Nodo de arbol que deseamos evaluar</param>
            public void agregarNodo(Nodo root)
            {
                if (root == null) //Valida que la raiz no venga con valor null
                {
                    Console.WriteLine("El valor de la raiz es nulo, por favor verificarlo e intentar de nuevo...");
                    return;
                }
                else if (root.informacion == informacion)
                {
                    // validando que no exista información igual
                    Console.WriteLine("No es posible ingresar valores duplicados, intentelo de nuevo...");
                    return;
                }
                else if (informacion < root.informacion) // validando subarbol izquierdo
                {
                    // verificando si nodo actual posee hijos a la izquierda
                    if (root.izquierda != null)
                    {
                        agregarNodo(root.izquierda);
                    }
                    else
                    {
                        // de no tenerlos, es nodo terminal, se procede a agregar nuevo nodo
                        Console.WriteLine("El valor " + informacion + " fue agrado a la izquierda del nodo " + root.informacion);
                        root.izquierda = this;
                    }
                }
                else if (informacion > root.informacion) // validando subarbol derecho
                {
                    // verificando si nodo actual  posee hijos a la derecha
                    if (root.derecha != null)
                    {
                        agregarNodo(root.derecha);
                    }
                    else
                    {
                        // de no tenerlos, es nodo terminal, se procede a agregar nuevo nodo
                        Console.WriteLine("El valor " + informacion + " fue agrado a la derecha del nodo " + root.informacion);
                        root.derecha = this;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Nodo root = null;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int x = rnd.Next(0, 100);
                Nodo n = new Nodo(x);
                if (root == null)
                {
                    root = n;
                    Console.WriteLine("El valor " + n.informacion + " fue agregada a la raiz");
                }
                else
                {
                    n.agregarNodo(root);
                }
            }
        }
    }
}
