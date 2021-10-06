using System;

namespace HOCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu 'h', 'o' ja 'l' tähte on lauses "hello, world"

            string HelloW = "Hello, World";
            int counterH = 0;
            int counterO = 0;
            int counterL = 0;

            for(int i = 0; i < HelloW.Length; i++)
            {
                if(HelloW[i] == 'h')
                {
                    counterH++;
                }
                else if(HelloW[i] == 'o')
                {
                    counterO++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"Lauses {HelloW} on {counterH} 'h' tähte, {counterO} 'o' tähte ja {counterL} 'l' tähte");
                
               
        


        }
    }
}
