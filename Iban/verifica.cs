using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iban
{
    public static class verifica
    {
        static void Main(string[] args)
        {
            var numeriInseriti = InsertNumbers();
            var dispari = RaddoppioDispari(numeriInseriti);


            static int[] InsertNumbers()
            {
                int[] numeriCarta = new int[6];
                Console.WriteLine("Inserisci i 16 numeri della Carta di Credito per verificarne la validità");
                for (int i = 0; i < numeriCarta.Length; i++)
                {
                    int numero;
                    while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 9)
                    {
                        Console.WriteLine("Puoi inserire solo numeri interi compresi tra 1 e 9");
                    }
                    numeriCarta[i] = numero;
                }
                return numeriCarta;
            }

            int[] RaddoppioDispari(int[] doppi)
            {
                int[] numeriDispariRaddoppiati = new int[] { };
                for (int i = 0; i < doppi.Length; i=i+2)
                {
                            numeriDispariRaddoppiati[i] = (doppi[i] * 2);
                }
                return numeriDispariRaddoppiati;
            }
        }
    }
}
