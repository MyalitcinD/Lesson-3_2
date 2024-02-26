using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите координаты первой точки через Enter");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввведите координаты втроой точки через Enter");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввведите координаты третьей точки через Enter");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());

            int x4, y4;
            if(((x1 == x2) && (y1 == y2)) || ((x1 == x3) && (y1 == y3)) || ((x2 == x3) && (y2 == y3))) {
                Console.WriteLine("по полученным точкам нельзя получить прямоугольник со сторонами, параллельными координатным осям");
            }
            else if(((x2-x1)*(x3-x1)+(y2-y1)*(y3-y1)) == 0) {
                x4 = x1 + (x2 - x1) + (x3 - x1);
                y4 = y1 + (y2 - y1) + (y3 - y1);
                Console.WriteLine("четвертая вершина x={0} y={1}",x4,y4);
            }
            else if(((x1 - x2) * (x3 - x2) + (y1 - y2) * (y3 - y2)) == 0 ) {
                x4 = x2 + (x1 - x2) + (x3 - x2);
                y4 = y2 + (y1 - y2) + (y3 - y2);
                Console.WriteLine("четвертая вершина x={0} y={1}", x4, y4);
            }
            else if(((x1 - x3) * (x2 - x3) + (y1 - y3) * (y2 - y3)) == 0) {
                x4 = x3 + (x1 - x3) + (x2 - x3);
                y4 = y3 + (y1 - y3) + (y2 - y3);
                Console.WriteLine("четвертая вершина x={0} y={1}", x4, y4);
            }
            
            else {
                Console.WriteLine("по полученным точкам нельзя получить прямоугольник со сторонами, параллельными координатным осям");
            }
            Console.ReadKey();
        }
    }
}
