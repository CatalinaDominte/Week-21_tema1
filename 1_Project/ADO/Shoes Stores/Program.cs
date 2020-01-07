using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tables;

namespace Shoes_Stores
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new CategoryRepository();
            List<Category> x=test.Reader("select * from[Category]");
            foreach (var item in x)
            {
                Console.WriteLine(item.CategoryName);
            }
            
            Console.ReadLine();
        }
    }
}
