using System;

namespace KonsoleEinAus
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            double x;
            int a;

            /* Eingabe eines Textes */
            Console.Write("Bitte einen Text eingeben: ");
            s = Console.ReadLine();
            Console.WriteLine("Text " + s + " eingegeben");

            /* Eingabe einer Zahl */
            Console.WriteLine();
            try
            {
                Console.Write("Bitte eine Zahl eingeben: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Zahl " + x + " eingegeben");
            }
            catch
            {
                Console.WriteLine("Keine Zahl eingegeben");
            }

            /* Eingabe einer ganzen Zahl, bis zum Erfolg */
            Console.WriteLine();
            do
            {
                try
                {
                    Console.Write("Bitte ganze Zahl eingeben: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Fehler, bitte noch einmal");
                }
            }
            while (true);
            Console.WriteLine("Ganze Zahl " + a + " eingegeben");
        }
    }
}
