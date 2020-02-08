using System;

namespace Extension_Methodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Edgar!");
            Console.WriteLine($"Anzahl Buchstaben: {Model.Data.AnzahlBuchstaben()}");
            Console.WriteLine($"Anzahl Wörter: {Model.Data.AnzahlWörter()}");
            Console.WriteLine();

            Console.WriteLine(Model.Data.AddCopyright( "Bitlc Erkrath", 15));

            Console.ReadLine();
        }
    }
}
