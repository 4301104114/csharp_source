using System;
using System.Collections.Generic;

namespace ConsoleApp1
{ 
    internal class Program
    {
      
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("************************************************************");
            Console.WriteLine("*        Chuong trinh thao tac tren ma tran vuoi           *");
            Console.WriteLine("************************************************************");


            string inputRow, inputColumn;
            int row, column;

            //Kiem tra gia tri cua row va collumn co dung dinh dang khong
            do
            {
                Console.WriteLine("Nhap so dong");
                inputRow = Console.ReadLine();

                Console.WriteLine("Nhap so cot");
                inputColumn = Console.ReadLine();

                if ((int.TryParse(inputRow, out row) == false) || (int.TryParse(inputColumn, out column) == false))
                {
                    Console.WriteLine("So row hoac so column khong dung dinh dang. Xin vui long nhap lai !");
                }
            } 
            while ((int.TryParse(inputRow, out row) == false) || (int.TryParse(inputColumn, out column) == false));

            if(row != column)
            {
                Console.WriteLine("row và column phai bang nhau vi day la ma tran vuong");
                Console.ReadKey();
                return;
            }

            int[,] matrix = new int[row, column];
            string inputItem;
            int item;

            // Nhap mang
            Console.WriteLine("Nhap cac phan tu trong mang");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
               for (int j = 0; j < matrix.GetLength(1); j++)
               {
                   do
                   {
                        Console.WriteLine("Nhap phan tu dong {0} cot {1}",i, j);
                        inputItem = Console.ReadLine();
                        if (int.TryParse(inputItem, out item) == false)
                        {
                            Console.WriteLine("Phan tu khong dung dinh dang. Xin vui long nhap lai !");
                           
                        }
                   }
                   while (int.TryParse(inputItem, out item) == false);
                   matrix[i, j] = item;   
               }
            }
            
            //In ma tran vuong chua hinh tam giac tren
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                   if(j >= i)
                   {
                       Console.ForegroundColor = ConsoleColor.Red;
                       Console.Write("{0,5}", matrix[i, j]);
                   }
                   else
                   {
                       Console.ForegroundColor = ConsoleColor.Yellow;
                       Console.Write("{0,5}", matrix[i, j]);
                   }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //In ma tran vuong chua hinh tam giac duoi
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j <= i)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0,5}", matrix[i, j]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("{0,5}", matrix[i, j]);
                    }
                }
                Console.WriteLine();
            }

            //Xuat cac phan tu trong hinh tam giac tren 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("Cac phan tu trong tam giac tren");
            for(int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = i; (j >= i && j < matrix.GetLength(1)); ++j)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0,5}", matrix[i, j]);
                }
            }

            //Xuat cac phan tu trong hinh tam giac duoi
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("Cac phan tu trong tam giac duoi");
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = 0; (j <= i && j < matrix.GetLength(1)); ++j)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0,5}", matrix[i, j]);
                }
            }

            Console.WriteLine();
            //Xuat cac phan tu tren duong cheo chinh
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cac phan tu tren duong cheo chinh");
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0,5}", matrix[i, i]);
            }

            Console.WriteLine();
            //Xuat cac phan tu tren duong cheo phu

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cac phan tu tren duong cheo phu");

            int sizeMatrix = matrix.GetLength(0);
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0,5}", matrix[i, (sizeMatrix - 1 - i)]);
            }
            Console.ReadKey();
                     
        }
    }   
}
