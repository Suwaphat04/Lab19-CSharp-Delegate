using System;

// กำหนด Generic Delegate
public delegate T Add<T>(T param1, T param2);

class Program
{
    static void Main()
    {
        // ใช้งาน delegate สำหรับการบวกเลขแบบ Integer
        Add<int> sum = NumericSum;
        int a = 30, b = 50;
        Console.WriteLine($"Numeric sum of {a} and {b} is {sum(a, b)}");

        // ใช้งาน delegate สำหรับการเชื่อมข้อความแบบ String
        Add<string> con = StringConcat;
        string h = "hello", w = "World";
        Console.WriteLine($"String concatenate of '{h}' and '{w}' is \"{con(h, w)}\"");
    }

    static int NumericSum(int val1, int val2)
    {
        return val1 + val2;
    }

    static string StringConcat(string str1, string str2)
    {
        return str1 + " " + str2;
    }
}
