using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("... Welcome to Line Comparison Computation ... ");
            Line_comparision Linecom = new Line_comparision();
            Linecom.length_line();
            Linecom.Comparelines();
            Console.ReadKey();
        }
    }
}


