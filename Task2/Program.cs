using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ввведите координаты точек A B C на числовой оси через Enter");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int ab = Math.Abs(b - a), ac = Math.Abs(c - a);

            if(ac == ab) {
                Console.WriteLine("B и C равноудалены от A на {0}", ab);
            }
            else if(ac < ab) {
                Console.WriteLine("C={0} расположена ближе к A, AC={1}", c, ac);
            }
            else {
                Console.WriteLine("B={0} расположена ближе к A, AB={1}", b, ab);
            }
            Console.ReadKey();


        }
    }
}
