using System;

namespace OperaTORs
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            RationalNums num1 = new RationalNums(a, b);
            num1.Print();
            Console.WriteLine();
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            RationalNums num2 = new RationalNums(c, d);
            num2.Print();
            Console.WriteLine();
            RationalNums res1 = num1 + num2;
            Console.Write("Результат сложения: ");
            res1.Print();
            Console.WriteLine();
            RationalNums res2 = num1 - num2;
            Console.Write("Результат вычитания: ");
            res2.Print();
            Console.WriteLine();
            RationalNums res3 = num1 * num2;
            Console.Write("Результат умножения: ");
            res3.Print();
            Console.WriteLine();
            RationalNums res4 = num1 / num2;
            Console.Write("Результат деления: ");
            res4.Print();
            Console.WriteLine();
        }
    }
}
