using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double MATH_PI = 3.14;
            double x, y; //x = радиус окружности
            double DlinaOkr, PloshadKruga, ChisloMetr, PolnNedel;
            double ChisloDesyatkov, ChisloEdinic, SumCifr, ProizvedCifr;
            int Day = 234;
            int z = 1234, SumNumber, UmnoChenie;
            x = 15; //Радиус окружности. // Расстояние в сантиметрах //Двузначное число
            y = 7 * Math.Pow(x, 2) - (3 * 5) + 4;
            Console.WriteLine("Значение функции: " + y);


            DlinaOkr = 2 * MATH_PI * x;
            PloshadKruga = MATH_PI * Math.Sqrt(x);
            Console.WriteLine("Длина окружности: " + DlinaOkr);
            Console.WriteLine("Площадькруга: " + PloshadKruga);

            ChisloMetr = x / 100;
            Console.WriteLine("Число в метрах: " + ChisloMetr);

            PolnNedel = Day / 7;
            Console.WriteLine("Полных недель: " + PolnNedel);

            ChisloDesyatkov = x / 10;
            ChisloEdinic = x / 1;
            SumCifr = (x % 10) + (x / 10);
            ProizvedCifr = (x % 10) * (x / 10);
            Console.WriteLine("Число десятков: "); Console.WriteLine(ChisloDesyatkov);
            Console.WriteLine("Число единиц: "); Console.WriteLine(ChisloEdinic);
            Console.WriteLine("Сумма цифр: " + SumCifr);
            Console.WriteLine("Произведение цифр: " + ProizvedCifr);

            SumNumber = (z % 10) + (z % 100 / 10) + (z % 1000 / 100) + (z / 1000);
            UmnoChenie = (z % 10) * (z % 100 / 10) * (z % 1000 / 100) * (z / 1000);
            Console.WriteLine("Сумма цифр " + SumNumber);
            Console.WriteLine("Произведение: " + UmnoChenie);

            int Num = 456;
            int Delete = Num % 10;
            int Answer = Num / 10;
            int Answer2_1 = Answer / 10;
            int Answer2_2 = Answer % 10;
            Console.WriteLine("Искомое число = " + Answer2_1 + Delete + Answer2_2);

            bool X = true, Y = false;
            Console.WriteLine(!X && !Y);
            Console.WriteLine(X || !X && Y);
            Console.WriteLine((!X && Y) || Y);



            Console.ReadLine();
        }
    }
}
