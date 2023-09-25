using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_2
{
    public class Bank
    {

        List<Konto> kontoLista = new List<Konto>();
        int antalKonton;


        public Bank()
        {
                
        }

        public void SkrivKontolista()
        {
            foreach (var kont in kontoLista)
            {
                kont.SkrivUt();
                Console.WriteLine();
            }
            // skriver ut en lista med bankens samtliga konton (kontonummer, innehavare, saldo och räntesats)
        }

        public void NyttKonto(int nummer, string innehavare, decimal saldo, decimal rantesats)
        {
            Konto nyttKonto = new Konto(nummer, innehavare, saldo, rantesats);
            kontoLista.Add(nyttKonto);

            // lägger in ett nytt konto längst bak i arrayen
        }

        public void RanteUtbetalning()
        {
            // utbetalar ränta till samtliga konton
        }

        public void SorteraKontoLista()
        {
            // en metod som sorterar en Konto-list efter konto nummer
        }

        public void SokKontoNr(int kontonr)
        {
            bool finns = false;
            foreach (var kont in kontoLista)
            {
                if (kont.GeNummer() == kontonr)
                {
                    finns = true;
                }
            }
            if (finns)
            {
                
            } else
            {
                Console.WriteLine("Kontot finns ej");
            }
            // söker efter ett givet kontonummer, som ska vara en parameter till metoden. Om kontot finns skriver metoden ut dess attribut på skärmen, annars skrivs ett meddelande ut om att kontot inte finns.
        }

        public void Menu()
        {
            bool avsluta = false;
            do
            {
                Console.WriteLine("Välj ett av alternativen: ");
                Console.WriteLine("1 - Lägg in ett nytt konto");
                Console.WriteLine("2 - Skriv ut kontolista");
                Console.WriteLine("3 - Ränteutbetalning");
                Console.WriteLine("4 - Sök efter konto");
                Console.WriteLine("5 - Avsluta");

                int svar = int.Parse(Console.ReadLine());
                Console.Clear();


                switch (svar)
                {
                    case 1:
                        Console.WriteLine("Du valde alternativ {0}.", svar);
                        break;
                    case 2:
                        Console.WriteLine("Du valde alternativ {0}.", svar);
                        break;
                    case 3:
                        Console.WriteLine("Du valde alternativ {0}.", svar);
                        break;
                    case 4:
                        Console.WriteLine("Skriv in kontonummret du vill söka efter: ");
                        SokKontoNr(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Du valde alternativ {0}.", svar);
                        break;
                    case 5:
                        Console.WriteLine("Du valde att avsluta.");
                        avsluta = true;
                        break;
                }


                // Lägg in ett nytt konto
                // Skriv ut kontolista
                // Ränteutbetalning
                // Sök efter konto
                // Avsluta

            } while (!avsluta);


        }

    }
}
