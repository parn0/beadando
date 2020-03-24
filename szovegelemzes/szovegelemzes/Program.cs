using System;

namespace szovegelemzes
{
    
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Adj meg egy szót/szöveget: ");
            string be = Console.ReadLine();
            Console.WriteLine($"A szöveg hossza: {Szoveg.HanyBetu(be,Szoveg.nembetukarakterek)}db");
            Console.WriteLine($"Magánhangzók száma: {Szoveg.HanyMaganhangzo(be,Szoveg.maganhangzok)}db");
            Console.WriteLine($"Mássalhangzók száma: {Szoveg.HanyMassalhangzo(be,Szoveg.massalhangzok)}db");
            Console.ReadKey();
        }
    }
}
