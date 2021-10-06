using System;

namespace ACharCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada eesnime
            //programm küsib kasutajal sisestada perekonnanime
            //programm kuvab, mitu "a" tähte kasutaja eesnimes ja
            //perekonnanimes kokku

            
            // 'a'

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstname = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastname = Console.ReadLine();

            string fullname = $"{firstname}{lastname}".ToLower();

            int counter = 0;
            for(int i = 0; i < fullname.Length; i++)
            {
                if (fullname[i] == 'a')
                {
                    counter++; //counter = counter + 1
                }

            }
            if(counter == 1)
            {
                Console.WriteLine($"Sinu nimes on {counter} 'a' tähte");
            }
            else
            {
                        Console.WriteLine($"Sinu nimes on {counter} 'a' tähte");
            }
    


    
        }
    }
}
