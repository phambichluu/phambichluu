using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPTB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap a vao: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b vao: ");
            double b = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Phương trinh vo so nghiem:");
                else
                    Console.WriteLine("Phuong trinh vo nghiem:");
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("Phuong trinh có nghiem la: " + x);
            }
        }
    }

}