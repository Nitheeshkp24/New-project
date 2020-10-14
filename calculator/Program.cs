using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter two numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            calc obj = new calc();
            obj.getadd(a, b);
            obj.sub(a, b);
        }
    }
}
