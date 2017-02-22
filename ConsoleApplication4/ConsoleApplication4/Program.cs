using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            int Number;
            Console.WriteLine("anna luku:");
            Number = int.Parse(Console.ReadLine());

            int Number2;
            Console.WriteLine("anna luku2:");
            Number2 = int.Parse(Console.ReadLine());

            float kerroin = 2;


            if (Number < 0)
            {
                Console.WriteLine("väärä numeroarvo");
            }
                        
            {
                Console.WriteLine("Lukusi ovat {0}", Number * kerroin);
            }
                Console.WriteLine("Lukusi ovat {0},{0}", Number2 * kerroin);

            Console.ReadLine();
        }
    }
}
