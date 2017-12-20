using System;

namespace KonsoleEinAus
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.Write("Bitte einen Text eingeben: ");
            s = Console.ReadLine();
            if (s == ""){
                do
                {
                    Console.Write("Text darf nicht leer sein.");
                    Console.Write("\nBitte einen Text eingeben: ");
                    s = Console.ReadLine();
                }
                while (s == "");
                Console.WriteLine("Text " + s + " wurde eingegeben.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Text " + s + " wurde eingegeben.");
                Console.ReadLine();
                
            }
            
            
        }
    }
}
