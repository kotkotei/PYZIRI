using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пузырь3
{
    class Program
    {
        static void Main(string[] args)
        {//145 б
            Console.WriteLine("Введи длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(10, 1000);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine(" ");
            int x = 0;
            for (int i = 0; i < n; i = i + 2)
            {
                x = mas[i];
                mas[i + 1] = mas[i];
                mas[i + 1] = x;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i] + "  ");
            }
            Console.ReadKey();
        }
    }
}
