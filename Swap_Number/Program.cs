using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, s;// x and y are to swap   
            
            Console.WriteLine("Enter the value of X ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of Y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"before swapping numbers: X={x} Y={ y}");
           //Swapping
            s = x;
            x = y;
            y = s;
            Console.WriteLine($"After swapping:X={x} Y={y}");
            Console.ReadLine();
        }
    }
}
