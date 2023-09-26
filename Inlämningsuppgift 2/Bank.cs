using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Channels;
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

        public void NyttKonto()
        {
            Console.Write("Skriv in vilket kontonummer du vill ha: ");
            int kontoNr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in vem som är kontoinnehavare: ");
            string kontoInnehavare = Console.ReadLine();
            Console.Write("Skriv in saldot: ");
            decimal saldo = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Skriv in räntesatsen i procent: ");
            decimal räntesats = Convert.ToDecimal(Console.ReadLine());
            Konto nyttKonto = new Konto(kontoNr, kontoInnehavare, saldo, räntesats);
            kontoLista.Add(nyttKonto);
            Console.WriteLine("Det nya kontot har skapats och lagts in i kontolistan");

            // lägger in ett nytt konto längst bak i arrayen
        }

        public void RanteUtbetalning()
        {
            foreach (var kont in kontoLista)
            {
                kont.RanteUtbetalning();
            }
            // utbetalar ränta till samtliga konton
        }

        public void SorteraKontoLista()
        {
            kontoLista.Sort((x, y) => x.GeNummer().CompareTo(y.GeNummer()));
            Console.WriteLine("Kontolistan har sorterats");
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
                    kont.SkrivUt();
                }
            }
            if (!finns)
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
                Console.WriteLine("5 - Sortera kontolistan");
                Console.WriteLine("6 - Avsluta");

                int svar = int.Parse(Console.ReadLine());
                Console.Clear();


                switch (svar)
                {
                    case 1:
                        NyttKonto();
                        break;
                    case 2:
                        SkrivKontolista();
                        break;
                    case 3:
                        RanteUtbetalning();
                        break;
                    case 4:
                        Console.WriteLine("Skriv in kontonummret du vill söka efter: ");
                        SokKontoNr(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 5:
                        SorteraKontoLista();
                        break;
                    case 6:
                        Console.WriteLine("Du valde att avsluta");
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
