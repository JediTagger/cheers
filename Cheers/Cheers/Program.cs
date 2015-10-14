using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello! What's your name?");
            String name = System.Console.ReadLine();
            foreach (char letter in name.ToLower())
            {
                if (Char.IsLetter(letter))
                {
                    if (letter == 'e' || letter == 'a' || letter == 'i' || letter == 'o' || letter == 'u')
                    {
                        System.Console.WriteLine("Give me an.. " + letter);
                    }
                    else
                    {
                        System.Console.WriteLine("Give me a.. " + letter);
                    }
                }
            }
            System.Console.WriteLine(name.ToUpper() + "'s just GRAND!");
            System.Console.WriteLine("Press any key to exit.");
            System.Console.WriteLine("Where is the \"any\" key?");
            System.Console.ReadKey();
        }
    }
}
