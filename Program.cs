﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pemro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dosen dosen = new Dosen();

            Console.WriteLine("Default Dosen Pengampu:");
            dosen.display();

            Console.WriteLine("\nMasukkan Nama dan NIK Dosen Baru:");
            dosen.attDosen(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            dosen.display();

            Console.WriteLine("\nMasukkan Mata Kuliah Baru:");
            dosen.addCourse(Console.ReadLine());
            dosen.display();

            Console.ReadLine();
        }
    }
}
