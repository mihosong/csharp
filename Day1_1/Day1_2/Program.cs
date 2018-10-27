using System;

namespace Day1_2
{
    class MyConstants
    {
        public const double P1 = 3.14;
        public const int MYAGE = 22;
    }

    class Program
    {
        static void Main(String[] args)
        {
            double radius = 2;
            double area = MyConstants.P1 * (radius * radius);
            Console.WriteLine("Area = {0}, Age = {1} ", area, MyConstants.MYAGE);

            const string name = "홍길동";
            Console.WriteLine("name :" + name);
        }

    }
}