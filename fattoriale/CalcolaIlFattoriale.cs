using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fattoriale
{
    class CalcolaIlFattoriale
    {
        internal static void Start()
        {

            //il fattoriale è 5*  4  *3*2*1
            //che tradotto è  5*(5-1)
            //                    4* (4-1)


            int numeroDaCalcolare = 5;
            FattorialeIterazione(numeroDaCalcolare);

            FattorialeRicorsione(numeroDaCalcolare);
        }

        private static int FattorialeRicorsione(int numeroDaCalcolare)
        {
            int totale = 1;
            Console.WriteLine($"Il Valore del numero da calcolare è {numeroDaCalcolare}");
            if (numeroDaCalcolare > 1)
            {
                totale = numeroDaCalcolare * FattorialeRicorsione(numeroDaCalcolare - 1);
                Console.WriteLine($"Il totale parziale è {totale}");
            }
            Console.WriteLine($"Il fattoriale di {numeroDaCalcolare} è {totale}");
            return totale;
        }

        private static void FattorialeIterazione(int numero)
        {
            Console.WriteLine("Sto calcolando con l'iterazione");
            var totale = 1;
            for (var i = numero; i>0; i--)
            {
                Console.WriteLine($"il valore di i è {i}");
                totale = totale * 1;
                Console.WriteLine($"Il totale provvisorio è {totale}");
            }
            Console.WriteLine($"Il fattoriale di {numero} è {totale}");
        }
    }
}
