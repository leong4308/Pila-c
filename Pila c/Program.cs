using System;

class Program
{
    static void Main()
    {
        const int capacidad = 10;
        int[] elementos = new int[capacidad];
        int tope = -1;

        Console.WriteLine("Tecla elemento de la pila (termina con -1)");

        const int CLAVE = -1;

        while (tope != CLAVE) // Usar != en lugar de =
        {
            try
            {
                int x = int.Parse(Console.ReadLine());

                if (tope < capacidad - 1)
                {
                    tope++;
                    elementos[tope] = x;
                }
                else
                {
                    Console.WriteLine("Excepción: Pila llena");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Excepción: Entrada no válida");
            }
        }

        if (tope >= 0)
        {
            Console.Write("Elementos de la Pila: ");
            while (tope >= 0)
            {
                int s = elementos[tope];
                tope--;
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Pila vacía");
        }
    }
}
