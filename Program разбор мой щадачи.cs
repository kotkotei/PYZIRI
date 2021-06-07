using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            int[] b = new int[n];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] >= 0)
                {
                    b[k] = a[i];
                    k = k + 1;
                    
                }
                
            }
            Console.WriteLine();
            for(int i = 0; i < k; i++)
            {
                Console.WriteLine(b[i]);
            }
            Console.ReadKey();

        }
    }
}
