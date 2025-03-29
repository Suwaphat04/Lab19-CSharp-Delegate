using System;

class Program
{
    static void Main()
    {
        // Func ที่รับค่า int, int และคืนค่า int
        Func<int, int, int> add = Add;
        int a = 5, b = 9;
        int c = add(a, b);
        Console.WriteLine($"Add({a}, {b}) return {c}");

        // Func ที่รับค่า string และคืนค่า string โดยใช้ Lambda Expression
        Func<string, string> convertToUpper = s => s.ToUpper();
        string before = "all Lowercase characters";
        Console.WriteLine($"Before = \"{before}\", after = \"{convertToUpper(before)}\"");
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}
