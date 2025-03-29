using System;

public delegate void MyDelegate(string message);

class Program
{
    static void Main()
    {
        var im = new InstanceMethod();
        
        // Assign instance method to delegate
        MyDelegate del = im.MethodA;
        del("Hello World");
        
        // Assign static method to delegate
        del = StaticMethod.MethodB;
        del("Hello Moon");
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
