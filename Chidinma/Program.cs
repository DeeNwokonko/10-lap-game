using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Chidinma
{
    class Program

    {
        static void Main(string[] args)
        {

           Stopwatch k = new Stopwatch();

            for (int i=1; i<=10; i++)
            {
                k.Start();
                 for (int j=1; j<=400; j++)
                {
                    Console.WriteLine(j + "miles");
                    //get the stop watch to start at j=0 and stop at j=399 
                }
                k.Stop();

                Console.WriteLine("lap "+ i +" "+ k.ElapsedMilliseconds + " milliseconds"  );
                Console.ReadLine();

            }

        }

    }
}
