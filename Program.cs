using System;
namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Marium Sana Mim");
            
            int x= 9;
            int y = 81;
            int sum = x + y;
            int div = y / x;
            Console.WriteLine("Sum:" + sum);
            Console.WriteLine("Division:" + div);
            
            int s1 = -5 + 8 * 6;
            int s2 = (55 + 9) % 9;
            int s3 = 20 + -3 * 5 / 8;
            int s4 = 5 + 15 / 3 * 2 - 8 % 3;
            Console.WriteLine("Solutions are:" + s1 + "," + s2 + "," + s3 + "," + s4);
            
            int a = 64; int b = 8;
            int sum1 = a + b;
            int mul = a * b;
            int sub = a - b;
            float div1 = a / b;
            float rem = a % b;
            Console.WriteLine("Sum:" + sum1 + " Multiplication:" + mul + " Subtraction:" + sub + " Division:" + div1 + " Remainder:" + rem);

            double res = (25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5);
            Console.WriteLine("Result:" + res);

            double width = 5.5;
            double height = 8.5;
            double area = width * height;
            double parameter = 2 * (width + height);
            Console.WriteLine("Area is " + width + " * " + height + " = " + area);
            Console.WriteLine("Parameter is 2 * ( " + width + " + " + height + ") = " + parameter);

            int f = 25;
            int s = 39;
            if (f != s)
                Console.WriteLine(+f + " != " + s);
            if (f < s)
                Console.WriteLine(+f + " < " + s);
            if (f <= s)
                Console.WriteLine(+f + " <= " + s);
        }
    }
}
