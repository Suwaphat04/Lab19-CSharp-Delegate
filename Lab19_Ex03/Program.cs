using System;

public delegate void MyDelegate(string message);

class Program
{
    static void Main()
    {
        // passing delegate as parameter
        var im = new InstanceMethod();
        
        // Assign instance method to delegate
        MyDelegate del = im.MethodA;
        InvokeDelegate(del);
        
        // Assign static method to delegate
        del = StaticMethod.MethodB;
        InvokeDelegate(del);
        
        // Assign anonymous method to delegate
        del = (string message) => Console.WriteLine($"You are calling anonymous method with message {message}");
        InvokeDelegate(del);
    }

    static void InvokeDelegate(MyDelegate myDel)
    {
        myDel("Hello World");
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
