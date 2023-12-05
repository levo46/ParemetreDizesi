﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametreDizileri
{
    class SayiIslemleri
    {
        public int Toplam(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var s in sayilar)
            {
                toplam += s;
            }
            return toplam;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SayiIslemleri sayiIslemleri = new SayiIslemleri();
            Console.WriteLine("Toplam: {0}", sayiIslemleri.Toplam(3));
            Console.WriteLine("Toplam: {0}", sayiIslemleri.Toplam(3, 4, 5));
            Console.WriteLine("Toplam: {0}", sayiIslemleri.Toplam(5, 1, 7, 3, 4, 5));
        }
    }
}

