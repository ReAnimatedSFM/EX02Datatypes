using System;

namespace EX02Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Karsten";
            string efternavn = "Hansen";
            int alder = 35;

            Console.WriteLine(fornavn);
            Console.WriteLine(efternavn);
            Console.WriteLine(alder);

            Console.WriteLine($"fornavn: {fornavn} efternavn: {efternavn} og alder: {alder}.");


            string titel = "Lord Of The Rings - The Two Towers";
            long isbn = 9780007117116;
            int sider = 450;
            double pris = 249.95;
            Console.WriteLine();
            Console.WriteLine(titel);
            Console.WriteLine(isbn);
            Console.WriteLine(sider);
            Console.WriteLine(pris);

            int maxInt = int.MaxValue;
            int minInt = int.MinValue;

            Console.WriteLine();
            Console.WriteLine("Maks og mindste int værdier");
            Console.WriteLine(maxInt);
            Console.WriteLine(minInt);






            Console.ReadKey();




        }
    }
}
