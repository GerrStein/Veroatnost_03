using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Автомат по продаже напитков не срабатывает в 1-м случае из 100");
            Console.WriteLine(" Найти Вероятность что он не сработает в k случаях из n.");

            Double P, C, p, q, X, n, k;

            Console.WriteLine("Введите n  число Попыток");
            n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите k число неудач");
            k = Convert.ToDouble(Console.ReadLine());

            p = k / n;

            q = 1 - p;

            C = Prov(n) / Prov(k) * Prov(n - k);

            P = C * Math.Pow(p, k) * Math.Pow((1 - p), (n - k));

            X = p * 100;

            if (X < 0)
            {
                Console.WriteLine("Количество Попыток не может быть меньше количества Неудач");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(Math.Round(X, 2) + "%");
                Console.ReadLine();
            }
        }
        private static double Prov(double n)
        {
            if (n == 0)
            {
                return 1;
            }

            double fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;


        }
    }
}
