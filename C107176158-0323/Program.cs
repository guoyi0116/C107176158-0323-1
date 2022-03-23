using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C107176158_0323
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fib = new int[20];
            fib[0] = 1;
            fib[1] = 1;
            for(int i = 2; i <20; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            for (int j= 0; j < 20; j++)
                Console.WriteLine(fib[j]);
            

            Console.ReadLine();

           
        }
    }
}
