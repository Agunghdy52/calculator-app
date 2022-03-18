﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("Pilih menu calculator : ");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.WriteLine("Inputkan nomor menu [1..4] : ");
            int menu = int.Parse(Console.ReadLine());
            

            if ( menu == 1)
            {
                Console.WriteLine("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                
            } 
            if ( menu == 2)
            {
                Console.WriteLine("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
                
            } 
            if ( menu == 3)
            {
                Console.WriteLine("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            
            } 
            if (menu == 4)
            {
                Console.WriteLine("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Inputkan nilai b = ");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            if ( menu > 4)
            {
                Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia");
            }
            if ( menu < 1)
            {
                Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia");
            }
            
            
            
            
            Console.WriteLine("Tekan smbarang key untuk keluar");
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}