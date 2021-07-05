using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interessi
{
    class CalcoloInteressi
    {
        internal static void Start()
        {
            // Scrivere una funzione che dato un importo di denaro iniziale,
            // un interesse annuo e un numero di anni permette di calcolare
            // l’importo di denaro accresciuto degli interessi dopo il numero di anni passati

            // Esempio
            // Voglio vincolare 10000 euro per 3 anni con un interesse del 3%

            // Dopo 1 anno : 10000 + (10000 * 3 / 100) = 10000 + 300 = 10300
            // Dopo 2 anni : 10300 + (10300 * 3 / 100) = 10300 + 309 = 10609
            // Dopo 3 anni : 10609 + (10609 * 3 / 100) = 10609 + 318,27 = 10927,27

            decimal denaroVincolato = DenaroIniziale();
            decimal interesseDaCalcolare = InteresseAnnuo();
            int durata = NumeroAnni();
            Importo(denaroVincolato, interesseDaCalcolare,durata);
        }

        private static void Importo(decimal denaroVincolato, decimal interesseDaCalcolare, int durata)
        {
            decimal totale = denaroVincolato;
            decimal totInteressi = 0;
            Console.WriteLine($"Stai calcolando l'interesse al {interesseDaCalcolare}% per la cifra di {denaroVincolato}€ per {durata} anno/i");
            for (int i = 0; i < durata; i++)
            {
                totInteressi = (denaroVincolato * interesseDaCalcolare) / 100;
                totale += totInteressi;

                    Console.WriteLine($"{i+1}° anno: {totale - totInteressi} + {totInteressi} = {totale}");
                denaroVincolato = totale;
            }
        }

        private static int NumeroAnni()
        {
            int anni;
            Console.WriteLine("Inserisci per quanti anni vincolare il tuo importo");
            anni = int.Parse(Console.ReadLine());
            return anni;
        }

        private static decimal InteresseAnnuo()
        {
            decimal interesse;
            Console.WriteLine("Inserisci l'interesse annuo");
            interesse = decimal.Parse(Console.ReadLine());
            return interesse;
        }

        private static decimal DenaroIniziale()
        {
            decimal importo;
            Console.WriteLine("Inserisci l'importo di denaro iniziale");
            importo = decimal.Parse(Console.ReadLine());
            return importo;
        }
    }
}
