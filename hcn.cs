using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Chuong trinh in hinh chu nhat");

            int m, n;
            char star = '*', no = '-';

            Console.WriteLine("Nhap chieu rong");
            m = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap chieu dai");
            n = int.Parse(Console.ReadLine());

            //Su dung for
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (i % (m - 1) == 0 || ((i % (m - 1) == 0) && (j % (n - 1) != 0)) || j % (n - 1) == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(star);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(no);
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine() ;
            //Su dung while
            int k = 0;

            while(k < m)
            {
                int u = 0;
                while(u < n)
                {
                    if (k % (m - 1) == 0 || ((k % (m - 1) == 0) && (u % (n - 1) != 0)) || u % (n - 1) == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(star);
                        
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(no);
                    }
                    ++u;

                }

                Console.WriteLine();
                ++k;
            }

            Console.WriteLine();

            //Su dung do while
            int a = 0;
            do 
            {
                int b = 0;
                do
                {
                    if (a % (m - 1) == 0 || ((a % (m - 1) == 0) && (b % (n - 1) != 0)) || b % (n - 1) == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(star);

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(no);
                    }
                    ++b;
                } 
                while (b < n);
                Console.WriteLine();
                a++; 
            } 
            while(a < m);

            Console.ReadKey();
        }
    }
}
