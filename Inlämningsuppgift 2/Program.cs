namespace Inlämningsuppgift_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Konto konto1 = new Konto(1234, "Isak Wiik", 29845.249m, 0.0365m);
            konto1.SkrivUt();

            konto1.RanteUtbetalning();
            Console.WriteLine();

            konto1.SkrivUt();

            Console.WriteLine(konto1.GeNummer());

            Bank bank1 = new Bank();
            bank1.Menu();

            // comment
        }
    }
}