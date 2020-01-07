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
            try
            {
                Console.WriteLine(Goat.Latin("k bcojh"));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            char n = 'A';
            char[] s = new char[] { 'a', 'b' };
            Console.ReadLine();
        }
    }
}
