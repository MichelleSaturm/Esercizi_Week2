using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificaIban
{
    public static class VerificaCartaDiCredito
    {
        static int lunghezzaCartaDiCredito = 16;
        public static int Start()
        {
            var carta = InserisciCartaDiCredito();
            var sommaDelleCifre = EseguiOperazioniPerVerifica(carta);
            VerificaValidità(sommaDelleCifre);
        }


        private static int[] InserisciCartaDiCredito()
        {
            Console.WriteLine("Inserisci");
            int[] cartaDiCredito = new int[lunghezzaCartaDiCredito];
            int i = 0;
            do
            {
                bool check = int.TryParse(Console.ReadLine(), out int numero);
                if (check)
                {
                    cartaDiCredito[i] = numero;
                    i++;
                }
            }
            while (i < lunghezzaCartaDiCredito);
            return cartaDiCredito;
        }

        private static int EseguiOperazioniPerVerifica(int[] cc)
        {
            int sommaCifre = 0;
            for (int i = 0; i < lunghezzaCartaDiCredito; i++)
            {
                if (i % 2 == 0)
                {
                    int singolaCifra = CalcolaCifraDaSommare(cc[i]);
                    sommaCifre = sommaCifre + singolaCifra;
                }
                else
                {
                    sommaCifre = sommaCifre + cc[i];
                }
            }
            return sommaCifre;
        }

        private static int CalcolaCifraDaSommare(int cifraSottoEsame)
        {
            int cifraRaddoppiata = cifraSottoEsame * 2;
            int singolaCifra = cifraRaddoppiata;
            if (cifraRaddoppiata > 9)
            {
                singolaCifra = cifraRaddoppiata - 9;
            }

            return singolaCifra;
        }

        private static void VerificaValidità(int sommaDelleCifre)
        {
            if (sommaDelleCifre % 10 == 0)
            { 
                Console.WriteLine("La carta è valida"); 
            }
            else { 
                Console.WriteLine("La carta non è valida"); 
            }
        }




    }
}
