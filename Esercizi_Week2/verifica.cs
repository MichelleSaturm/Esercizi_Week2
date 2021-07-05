using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio1
{
    public class static verifica

    #region Comanda
        //Le carte di pagamento sono lunghe 16 cifre.

        // Hans Peter ha inventato un metodo per determinare se un numero di carta di credito
        // è sintatticamente valido


        // Step 1 : Vengono raddoppiate le cifre che si trovano in posizione dispari
        // Step 2 : Se questo "raddoppio" risulta in un numero a due cifre,
        // viene sottratto 9 da esso per ottenere una sola cifra.
        // Step 3 : Vengono sommante tutte le cifre ottenute
        // Step 4 : Vengono aggiunte le cifre nelle posizioni dispari
        // Step 5 : Se il risultato è divisibile per 10, il numero della carta è valido;
        // in caso contrario, non è valido.


        // Esempi
        // Carta di pagamento : 4  5  5  6    7  3  7  5   8  6  8  9   9  8  5  5
        // Step 1             : 8  5 10  6   14  3 14  5   16 6  16 9   18 8  10 5
        // Step 2             : 8  5  1  6    5  3  5  5   7  6  7  9   9  8  1  5
        // Step 3             : 8 + 1 + 5 + 5 + 7 + 7 + 9 + 1 = 43
        // Step 4             : 43 + (5+6+3+5+6+9+8+5) = 43 + 47 = 90
        // Step 5             : 90/10 = 9 resto 0 -> Numero della carta valido


        // Esempi
        // Carta di pagamento : 4  0  2  4    0  0  7  1   0  9  0  2   2  1  4  3
        // Step 1             : 8  0  4  4    0  0 14  1   0  9  0  2   4  1  8  3
        // Step 2             : 8  0  4  4    0  0  5  1   0  9  0  2   4  1  8  3
        // Step 3             : 8 + 4 + 0 + 5 + 0 + 0 + 4 + 8 = 29
        // Step 4             : 29 + (0+4+0+1+9+2+1+3) = 29 + 20 = 49
        // Step 5             : 49/10 = 4 resto 9 -> Numero della carta non valido
    #endregion
        public static void start();
    {
}

    var numeriInseriti = InsertNumbers();
    var dispari = RaddoppioDispari(numeriInseriti);


int[] InsertNumbers()
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
    for (int i = 1; i < doppi.Length + 1; i++)
    {
        if (i % 2 == 0)
        {
            numeriDispariRaddoppiati[i] = doppi[i];
        }
        else
        {
            if ((doppi[i] * 2) < 9)
            {
                numeriDispariRaddoppiati[i] = (doppi[i] * 2);
            }
            else
            {
                numeriDispariRaddoppiati[i] = ((doppi[i] * 2) - 9);
            }
        }
    }
    return numeriDispariRaddoppiati;
}
