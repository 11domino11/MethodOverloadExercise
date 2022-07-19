using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 3));
            Console.WriteLine(Add(2.2m, 3.3m));
            Console.WriteLine(Add(0, 1, false));
            Console.ReadLine();
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return (decimal)x + y;
        }
        public static string Add(int x, int y, bool isTrue)
        {
            if(x == y)
            {
                return $"{x + y}";
            }
            if(x + y == 1)
            {
                return "1 dollar";
            }
            else { return $"{x + y} dollars"; }
        }
    }
}
