using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //2
            //Console.WriteLine("Введите радиус окружности");
            //double Radius = double.Parse(Console.ReadLine());
            //double С = (2 * Math.PI) * 3;
            //double P = Math.PI * (Radius * 2);
            //Console.WriteLine("Длина = " + С);
            //Console.WriteLine("Площадь = " + P);
            //Console.ReadLine();

            //3
            //Console.WriteLine("centimeter");
            //int cm = Int32.Parse(Console.ReadLine());
            //int m = (int)(cm * 0.001);
            //Console.WriteLine("m = " + m);
            //Console.ReadLine();

            //4
            //int Week = 7;
            //int Days = 234;
            //int DaysWeek = Days / Week;
            //Console.WriteLine("Weeks = " + DaysWeek);
            //Console.ReadLine();

            //5
            //Random rand = new Random();
            //int Number;
            //Number = rand.Next(100);
            //int Tens = Number / 10;
            //int Units = Number % 10;
            //int Sum = Number + Units;
            //int Composition = Tens * Units;
            //Console.WriteLine(" Number = {0}  Tens = {1}  Units = {2}  Sum = {3}  Composition = {4}", Number, Tens, Units, Sum, Composition);
            //Console.ReadLine();

            Console.WriteLine("Введите 4-хзначное число: ");
            int Number = Int32.Parse(Console.ReadLine());

            int Tens = Number / 10;
            int Units = Number % 10;
            int Sum = Number + Units;
            int Composition = Tens * Units;
            Console.WriteLine(" Number = {0}  Tens = {1}  Units = {2}  Sum = {3}  Composition = {4}", Number, Tens, Units, Sum, Composition);
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
