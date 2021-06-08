using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пузырь2
{
    class Program
    {
        static void Main(string[] args)
        {//144 B
            Console.WriteLine("Введи длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(-100, 100);
                Console.Write(mas[i] + " ");
                
            }
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (mas[k] < mas[i])
                {
                    k = i;
                }
            }
            int f = mas[2];
            mas[2] = mas[k];
            mas[k] = f;
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i] + "  ");
            }
            Console.ReadKey();
            }
        }
    }


        
