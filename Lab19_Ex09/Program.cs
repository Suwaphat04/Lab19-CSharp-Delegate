using System;

class Program
{
    static void Main()
    {
        // Action ที่ไม่มีพารามิเตอร์
        Action a = Print;
        a();

        // Action ที่มีพารามิเตอร์สามตัว (int, int, int)
        Action<int, int, int> s = PrintSum;
        s(4, 5, 6);

        // Action ที่มีพารามิเตอร์สองตัว (int, int) ใช้ Lambda Expression
        Action<int, int> sum = (a, b) =>
        {
            var x = a + b;
            Console.WriteLine("result = " + x);
        };
        sum(8, 2);
    }

    static void Print()
    {
        Console.WriteLine("Hello World");
    }

    static void PrintSum(int a, int b, int c)
    {
        Console.WriteLine($"sum = {a + b + c}");
    }
}
