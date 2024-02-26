using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввведите  целое число в диапазоне 20–69, определяющее возраст (в годах)");
            int age = Convert.ToInt32(Console.ReadLine());

            string part1 = "" , part2="" , part3;
            if((age < 20) || (age > 69)) {
                Console.WriteLine("Ошибка, введено неверное значение");

            }
            else {
                int d = age / 10;
                switch(d) {
                    case 2:
                        part1 = "двадцать ";
                        break;
                    case 3:
                        part1 = "тридцать ";
                        break;
                    case 4:
                        part1 = "сорок ";
                        break;
                    case 5:
                        part1 = "пятьдесят ";
                        break;
                    case 6:
                        part1 = "шестьдесят ";
                        break;
                    default:
                        break;
                }
                int s = age % 10;
                switch(s) {
                    case 0:
                        part2 = "лет";
                        break;
                    case 1:
                        part2 = "один год";
                        break;
                    case 2:
                        part2 = "два года";
                        break;
                    case 3:
                        part2 = "три года";
                        break;
                    case 4:
                        part2 = "четыре года";
                        break;
                    case 5:
                        part2 = "пять лет";
                        break;
                    case 6:
                        part2 = "шесть лет";
                        break;
                    case 7:
                        part2 = "семь лет";
                        break;
                    case 8:
                        part2 = "восемь лет";
                        break;
                    case 9:
                        part2 = "девять лет";
                        break;
                    default:
                        break;
                }
                part3 = part1 + part2;
                Console.WriteLine(part3); 
            }
            Console.ReadKey();
        }
    }
}
