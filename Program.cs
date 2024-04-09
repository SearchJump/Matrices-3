using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_3
{
    
        class Program
        {
            static void Main(string[] args)
            {
                // Declaramos las variables
                int filas;
                int columnas;
                int[,] matriz;

                // Solicitamos las dimensiones de la matriz
                Console.WriteLine("Ingrese la cantidad de filas:");
                filas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de columnas:");
                columnas = Convert.ToInt32(Console.ReadLine());

                // Creamos la matriz
                matriz = new int[filas, columnas];

                // Cargamos los datos de la matriz
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write("Matriz[{0},{1}] = ", i, j);// Imprime el elemento de la matriz en la fila i y columna j
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                // Mostramos la matriz
                Console.WriteLine("Matriz:");
                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        Console.Write("{0} ", matriz[i, j]);// la expresión "{0} " se utiliza para formatear la salida de la matriz.
                                                            // En este caso, se utiliza para insertar un espacio entre cada elemento de la matriz.
                }
                    Console.WriteLine();
                }
            }
        }
    

}
