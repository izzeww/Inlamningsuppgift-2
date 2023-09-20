using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_2
{
    internal class Konto
    {
        private int nummer;
        private string innehavare;
        private decimal saldo;
        private decimal rantesats;

        public Konto(int nummer, string innehavare, decimal saldo, decimal rantesats)
        {
            this.nummer = nummer;
            this.innehavare = innehavare;
            this.saldo = saldo;
            this.rantesats = rantesats;
                // konstruktor
        }

        public void SkrivUt()
        {
            Console.WriteLine(nummer);
            Console.WriteLine(innehavare);
            Console.WriteLine(saldo);
            Console.WriteLine(rantesats);
            // skriver ut samtliga attribut
        }

        public int GeNummer()
        {
            // returnerar kontonumret
            return nummer;
        }

        public void RanteUtbetalning()
        {
            saldo *= (1 + rantesats);
            // beräknar räntan och adderar den till saldot
        }

    }
}
