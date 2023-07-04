using System;

namespace CiclosForyWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Probaremos un ejemplo de cómo se comporta un ciclo For mediante listas de arreglos en C#.

            Console.WriteLine("CICLO FOR");
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Crearemos una lista de arreglos con 10 números consecutivos.
            for (int i = 0; i < array.Length; i++) // Por cada número en una lista de arreglos.
            {
                Console.WriteLine(array[i]); // Se imprimen los números de la lista.
            }

            // Probaremos otro ejemplo de cómo manejaremos un ciclo While mediante arreglos utilizando un contador numérico.

            Console.WriteLine("CICLO WHILE");
            int cont = 0; // Iniciaremos en 0 el contador.
            while (cont < array.Length) // Mientras el contador es menor que la longitud de una lista de arreglos.
            {
                Console.WriteLine(array[cont]); // Crearemos una lista de arreglos.
                cont++; // Número secuencial incrementado al crear un arreglo.
            }
        }
    }
}
