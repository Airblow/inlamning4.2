using System;
using System.Linq.Expressions;

namespace inlamning4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stopProg = false;
            int biggestDigit = 0;

            while (stopProg != true)
            {
                Console.WriteLine("Skriv ett heltal eller 'n' för att avsluta");
                string answer = Console.ReadLine().ToLower();

                try
                {
                    if (answer == "n")
                    {
                        stopProg = true;

                    }
                    else if(biggestDigit < int.Parse(answer))
                    {
                        biggestDigit = int.Parse(answer);

                    }


                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Du kan endast skriva heltal eller 'n'");

                }

            }  

            if(biggestDigit >0)
            {
                Console.WriteLine("De största talet du angav var " + biggestDigit);

            }

            Console.ReadKey();

        }

    }

}
 
