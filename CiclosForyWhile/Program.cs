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

            // Por el momento vamos a comentarlo todo el while para poder probarlo con el "do while".

            Console.WriteLine("CICLO WHILE"); // Probaremos otro ejemplo de cómo manejaremos un ciclo While mediante arreglos utilizando un contador numérico.
            int cont = 9; // Iniciaremos en 10 el contador.
            // while (cont < array.Length) // Mientras el contador es menor que la longitud de una lista de arreglos.
            // {
            // Console.WriteLine(array[cont]); // Crearemos una lista de arreglos.
            // cont++; // Número secuencial incrementado al crear un arreglo.
            // }
            do
            {
               Console.WriteLine(array[cont]); // Para cada elemento de la lista de arreglos.
               cont++; // El contador se incrementa desde 10 según inicialización de la variable.
            }

            while (cont < 9);

            // Ahora probaremos un ITERADOR para cada elemento de un arreglo en una lista.

            Console.WriteLine("ITERADOR FOREACH");
            foreach (int item in array) // Por cada elemento de la lista de arreglos.
            {
                Console.WriteLine(item); // Más ordenado y eficiente.
            }
        }
    }
}
