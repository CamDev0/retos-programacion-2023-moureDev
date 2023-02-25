using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto0
{
    class CamDev0
    {
        static void Main(string[] args)
        {
            int aux = 0;

            for (int i = 1; i <= 100; i++)
            {
                aux = i;
                
               if  (aux % 3 == 0 && aux % 5 == 0)
               {
                    Console.WriteLine("fizzbuzz");
               }
               else if (aux % 3 == 0)
               {
                    Console.WriteLine("fizz");
               }
               else if (aux % 5 == 0)

               {
                    Console.WriteLine("buzz");
               }
               else
                {
                    Console.WriteLine(aux);
                }

                Console.ReadKey();
            }
        }
    }
}
