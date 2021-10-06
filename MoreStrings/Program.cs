using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutjalt sisestada eesnime ja perekonnanime
            //programm tervitab kasutajat kasutades tema initsiaale

            Console.WriteLine("Sisesta oma nimi:");
            string userFirstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string userLastName = Console.ReadLine();

            Console.WriteLine($"Tere {userFirstName[0]}. {userLastName[0]}.");
        }
    }
}
