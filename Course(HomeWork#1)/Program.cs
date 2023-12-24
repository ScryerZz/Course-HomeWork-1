using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course_HomeWork_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            // Task #1

            //Console.WriteLine("Введите два числа, чтобы узнать их среднее арифметическое xD");

            //Console.WriteLine();

            //Console.WriteLine("Первое число:");

            //double a = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);

            //Console.WriteLine("Второе число:");

            //double b = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);

            //double result = (a + b) / 2;

            //Console.WriteLine("Среднее арифметическое: " + result, numberFormatInfo);

            // Task #2

            //Console.WriteLine("Введите три числа, чтобы узнать сумму и произведение этих чисел ;)");

            //Console.WriteLine();

            //Console.WriteLine("Первое число:");

            //double a = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);

            //Console.WriteLine("Второе число:");

            //double b = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);

            //Console.WriteLine("Третье число:");

            //double c = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);

            //double sum = a + b + c;

            //double mult = a * b * c;

            //Console.WriteLine("Сумма трёх чисел: " + sum, numberFormatInfo);

            //Console.WriteLine("Произведение трёх чисел: " + mult, numberFormatInfo);

            // Task #3

            double ruble = 0;

            double dollar = 0;

            double euro = 0;

            double yuan = 0;

            Console.WriteLine("Конвертер валют :/");

            Console.WriteLine();

            dollar = 0.0107;

            euro = 0.0101;

            yuan = 0.0788;

            Console.WriteLine("Введите сколко рублей вы хотите сконвертировать в другую валюту:");

            double rub = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);

            Console.WriteLine($"{rub} рублей в долларах: " + rub * dollar, numberFormatInfo);

            Console.WriteLine($"{rub} рублей в евро: " + rub * euro, numberFormatInfo);

            Console.WriteLine($"{rub} рублей в юанях: " + rub * yuan, numberFormatInfo);

            Console.WriteLine();

            euro = 0.9396;

            yuan = 7.3307;

            ruble = 93.0351;

            Console.WriteLine("Введите сколко долларов вы хотите сконвертировать в другую валюту:");

            double usd = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);

            Console.WriteLine($"{usd} долларов в рублях: " + usd * ruble, numberFormatInfo);

            Console.WriteLine($"{usd} долларов в евро: " + usd * euro, numberFormatInfo);

            Console.WriteLine($"{usd} долларов в юанях: " + usd * yuan, numberFormatInfo);

            Console.WriteLine();

            dollar = 1.0642;

            yuan = 7.8016;

            ruble = 99.0111;

            Console.WriteLine("Введите сколко евро вы хотите сконвертировать в другую валюту:");

            double eur = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);

            Console.WriteLine($"{eur} евро в рублях: " + eur * ruble, numberFormatInfo);

            Console.WriteLine($"{eur} евро в долларах: " + eur * dollar, numberFormatInfo);

            Console.WriteLine($"{eur} евро в юанях: " + eur * yuan, numberFormatInfo);

            Console.WriteLine();

            dollar = 0.1364;

            euro = 0.1282;

            ruble = 12.6911;

            Console.WriteLine("Введите сколко юаней вы хотите сконвертировать в другую валюту:");

            double cny = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);

            Console.WriteLine($"{cny} юань в рублях: " + cny * ruble, numberFormatInfo);

            Console.WriteLine($"{cny} юань в долларах: " + cny * dollar, numberFormatInfo);

            Console.WriteLine($"{cny} юань в евро: " + cny * euro, numberFormatInfo);
        }
    }
}
