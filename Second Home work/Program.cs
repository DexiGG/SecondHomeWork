using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Home
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
            const int number = 3;
            int[] arr = new int[number];
            Random rand = new Random();
            for (int i = 0; i < number; i++)
            {
                arr[i] = rand.Next(-10, 10);
                Console.Write(arr[i] + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            //2.Вывести на экран числа 5, 10 и 21 одно под другим.
            int number1 = 5, number2 = 10, number3 = 21;
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine("----------------------------");
            //3.Дано расстояние в сантиметрах. Найти число полных метров в нем.
            double x = 100, СMtoM; // 100 сантиметров
            СMtoM = x / 1000;
            Console.WriteLine("Число в метрах: " + СMtoM);
            Console.WriteLine("----------------------------");
            //4.С некоторого момента прошло 234 дня. Сколько полных недель 
            int Day = 234;
            int FullWeek = Day / 7;
            Console.WriteLine("Полных недель: " + FullWeek);
            Console.WriteLine("----------------------------");
            //5.	Дано двузначное число. Найти:
            //a.	число десятков в нем;
            //b.	число единиц в нем;
            //c.	сумму его цифр;
            //d.	произведение его цифр
            int z = 37; //Двузначное число.
            double NumberOfTens, NumberOfUnits, Sum, Multiplication;
            NumberOfTens = z / 10;
            NumberOfUnits = z / 1;
            Sum = (z % 10) + (z / 10);
            Multiplication = (z % 10) * (z / 10);
            Console.WriteLine("Число десятков: " + NumberOfTens);
            Console.WriteLine("Число единиц: " + NumberOfUnits);
            Console.WriteLine("Сумма цифр: " + Sum);
            Console.WriteLine("Произведение цифр: " + Multiplication);
            Console.WriteLine("----------------------------");
            //6.Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
            //a.	А или В; 
            //b.	А и В; 
            // c.	В или С.
            bool A = true, B = false, C = false;
            Console.WriteLine(A || B);
            Console.WriteLine(A && B);
            Console.WriteLine(B || C);
            Console.WriteLine("----------------------------");
            //7.	Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?
            const double MATH_PI = 3.14;
            double a = 13, r = 13, Square, Circle;
            Square = Math.Pow(a, 2);
            Circle = MATH_PI * Math.Pow(r, 2);
            Console.WriteLine("Квадрат = " + Square);
            Console.WriteLine("Круг = " + Circle);
            if (Square > Circle)
            {
                Console.WriteLine("Больше квадрат " + Square);
            }
            else
            {
                Console.WriteLine("Больше круг " + Circle);
            }
            Console.WriteLine("----------------------------");
            //8. Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?
            double v1 = 3, m1 = 9, v2 = 2, m2 = 4;
            if (m1 / v1 > m2 / v2)
            {
                Console.WriteLine("Плотность первого больше");
            }
            else
            {
                Console.WriteLine("Плотность второго больше");
            }
            Console.WriteLine("----------------------------");
            //9. Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них. По какому участку протекает меньший ток?
            double u1 = 10, r1 = 5, u2 = 20, r2 = 5;
            if (u1 / r1 > u2 / r2)
            {
                Console.WriteLine("Сила тока первого больше");
            }
            else
            {
                Console.WriteLine("Сила тока второго больше");
            }
            Console.WriteLine("----------------------------");
            //Напечатать "столбиком": 
            //a.	все целые числа от 20 до 35;
            //b.	квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);
            //c.	третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);
            //d.	все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).
            //a.
            Console.WriteLine("20\n21\n22\n23\n24\n25\n25\n26\n27\n28\n29\n30\n31\n32\n33\n34\n35");
            Console.WriteLine("----------------------------");
            //b.
            double b;
            Console.WriteLine("Введите число чтобы возвести в квадрат числа от 10 до n");
            b = double.Parse(Console.ReadLine());
            for (double k = 10; k <= b; k++)
            {
                Console.WriteLine("Квадраты чисел " + Math.Pow(k, 2));
            }
            Console.WriteLine("----------------------------");
            //c.
            Console.WriteLine("Введите число чтобы возвести в третью степень все числа от n до 50");
            double h;
            h = double.Parse(Console.ReadLine());
            for (double l = h; l < 50; l++)
            {
                Console.WriteLine("Третья степень числа " + Math.Pow(l, 3));
            }
            Console.WriteLine("----------------------------");
            //d.
            int INTEGER1, INTEGER2;
            Console.WriteLine("Введите два числа чтобы посмотреть все числа в диапазоне");
            INTEGER1 = int.Parse(Console.ReadLine());
            INTEGER2 = int.Parse(Console.ReadLine());
            if (INTEGER2 > INTEGER1)
            {
                for (int n = INTEGER1; n < INTEGER2 + 1; n++)
                {

                    Console.WriteLine(n);
                }
            }
            else
            {
                for (int n = INTEGER2; n < INTEGER1 + 1; n++)
                {

                    Console.WriteLine(n);
                }
            }
            Console.ReadLine();
        }
    }
}


