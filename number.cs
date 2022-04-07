using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            number no = new number();

            Console.WriteLine("Nilai Minimum ke-1 = {0}", no.FindMinimum(3, 1));
            Console.WriteLine("Nilai Minimum ke-2 = {0}", no.FindMinimum(3, 2, 4));
            Console.WriteLine();
            Console.WriteLine("Nilai Maximum ke-1 = {0}", no.FindMaximum(3, 1));
            Console.WriteLine("Nilai Maximum ke-2 = {0}", no.FindMaximum(3, 2, 4));

            Console.ReadKey();
        }
    }
}
