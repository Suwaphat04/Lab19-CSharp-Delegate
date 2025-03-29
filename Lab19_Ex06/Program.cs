using System;

delegate int Square(int num);  // 1. declare delegate

class Program
{
    static void Main()
    {
        // 2. define anonymous method
        Square getSquare = delegate (int x)
        {
            return x * x;
        };
        
        int num = 9;
        int sqr = getSquare(num);
        Console.WriteLine($"Square value of {num} is {sqr}");
    }
}
