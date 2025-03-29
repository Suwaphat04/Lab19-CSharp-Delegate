using System;
using System.Linq;  // ต้องใช้สำหรับการใช้งาน Count() กับ Lambda Expression

class Program
{
    static void Main()
    {
        int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        // ใช้ Lambda Expression เพื่อคำนวณจำนวนเลขคี่
        int oddNumbers = numbers.Count(n => n % 2 == 1);

        Console.WriteLine($"There are {oddNumbers} odd numbers in {string.Join(" ", numbers)}");
    }
}
