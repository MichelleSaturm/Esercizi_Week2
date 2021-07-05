using System;

namespace fibonacci
{
    class fibonacci
    {
        internal static void start()
        {

            //   Dato in ingresso un numero intero, calcolare la serie di Fibonacci
            //       1, 1, 2, 3, 5, 8, 13, 21.....
            int numero = 10;
            //FibonacciIterativa(numero);

            int risultato = 1;
            if (numero > 1)
            {
                for (int i = 1; i < numero; i++)
                {
                    risultato = FibonacciRicorsione(i);
                    Console.Write($"{risultato} ");
                }
            }
            
        }

        private static int FibonacciRicorsione(int i)
        {
            int risultato = 1;
            if (i > 1)
            {
                risultato = FibonacciRicorsione(i - 1) + FibonacciRicorsione(i - 2);
            }
            return risultato;
        }

        //public static int FibonacciIterativa(int numero)
        //{
        //    Console.Write("Fibonacci Iterativa");
        //    int risultato = 0;
        //    int precedente = 1;
        //    for (int i = 0; i < numero; i++)
        //    {
        //        int num = risultato;
        //        risultato = precedente;
        //        precedente = num + precedente; 
        //        Console.Write($"{risultato} ");
        //    }
        //    return risultato;
        //}


    }
}
