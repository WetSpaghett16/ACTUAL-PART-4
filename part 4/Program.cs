using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_4
{
    
    class Program
    {
       

        static void Main(string[] args)
        {
            Random generator = new Random();

            Console.WriteLine("Random number between zero and the maximum number: ");
            Console.WriteLine(generator.Next());
            Console.WriteLine("Hit ENTER to continue: ");
            Console.ReadLine();

            Console.WriteLine("Random number between 1 and 10: ");
            Console.WriteLine(generator.Next(11));
            Console.WriteLine("Hit ENTER to continue:");
            Console.ReadLine();

            Console.WriteLine("Random integer from 1 to 10");
            Console.WriteLine(generator.Next(1, 11));
            Console.WriteLine("Hit ENTER to continue");
            Console.ReadLine();

            Console.WriteLine("Random integer from -10 to 0");
            Console.WriteLine(generator.Next(-10, 1));
            Console.WriteLine("Hit ENTER to continue");
            Console.ReadLine();

            Console.WriteLine("Random double from 0 to 1");
            Console.WriteLine(generator.NextDouble());
            Console.WriteLine("Hit ENTER to continue");
            Console.ReadLine();

            Console.WriteLine("Random double from 0 to 5");
            Console.WriteLine(generator.NextDouble() * 5);
            Console.WriteLine("Hit ENTER to continue");
            Console.ReadLine();

        }
    }
}
