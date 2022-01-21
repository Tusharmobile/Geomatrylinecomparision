using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the linecomparision problem");
            Line_comparision Linecom = new Line_comparision();
            Linecom.length_line();

            Console.ReadLine();

        }
    }
}
