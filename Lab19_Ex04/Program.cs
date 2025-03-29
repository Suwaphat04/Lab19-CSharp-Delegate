using System;

public delegate void MyDelegate(string message);

class Program
{
    static void Main()
    {
        var im = new InstanceMethod();
        
        // สร้าง delegate แต่ละตัวสำหรับ Instance Method, Static Method และ Anonymous Method
        MyDelegate imdel = im.MethodA;
        MyDelegate smdel = StaticMethod.MethodB;
        MyDelegate amdel = (string message) => Console.WriteLine($"You are calling anonymous method with message {message}");

        Console.WriteLine("------------------");
        Console.WriteLine("imdel + smdel");
        MyDelegate del = imdel + smdel;
        del("Hello world");

        Console.WriteLine("------------------");
        Console.WriteLine("imdel + smdel + amdel");
        del += amdel;
        del("Hello world");

        Console.WriteLine("------------------");
        Console.WriteLine("del -= imdel");
        del -= imdel;
        del("Hello world");
    }
}

class InstanceMethod
{
    public void MethodA(string message)
    {
        Console.WriteLine($"You are calling instance MethodA() with message {message}");
    }
}

static class StaticMethod
{
    public static void MethodB(string message)
    {
        Console.WriteLine($"You are calling static MethodB() with message {message}");
    }
}
