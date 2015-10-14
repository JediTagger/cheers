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
            foreach (char letter in name)
            {
                if (letter == 'e' || letter == 'a' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    
                    System.Console.WriteLine("Give me an.. " + char.ToLower(letter));
                }
                else
                {
                    System.Console.WriteLine("Give me a.. " + char.ToLower(letter));
                }
            }
            System.Console.WriteLine(name.ToUpper() + "'s just GRAND!");
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
