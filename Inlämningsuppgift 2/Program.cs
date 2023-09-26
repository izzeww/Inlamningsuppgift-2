namespace Inlämningsuppgift_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank1 = new Bank();

            //Konto konto1 = new Konto(1234, "Isak Wiik", 29845.249m, 0.0365m);
            //konto1.SkrivUt();
            //bank1.SkrivKontolista();

            //konto1.RanteUtbetalning();
            //Console.WriteLine();

            //konto1.SkrivUt();


            
            //Console.WriteLine(konto1.GeNummer());

            /*bank1.NyttKonto(Convert.ToInt32(Console.ReadLine()),
                Console.ReadLine(),
                Convert.ToDecimal(Console.ReadLine()),
                Convert.ToDecimal(Console.ReadLine())
                );
            bank1.SkrivKontolista();
            Console.WriteLine();
            */
            bank1.Menu();
            

            // comment
        }
    }
}