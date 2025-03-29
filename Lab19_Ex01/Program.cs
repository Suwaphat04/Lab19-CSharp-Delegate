using System;

// 1. declare delegate
public delegate void MyDelegate(string message);

class Program
{
    static void Main()
    {
        // 2. add target method to delegate
        MyDelegate myDel1 = new MyDelegate(MyMethod);
        MyDelegate myDel2 = MyMethod;

        // 3. Invoke delegate
        myDel1("Hello World");
        myDel1.Invoke("Hello Mars");
        myDel2("Hello Saturn");
    }

    static void MyMethod(string message)
    {
        Console.WriteLine(message);
    }
}
