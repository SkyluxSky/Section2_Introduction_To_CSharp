//Using statements are equivalent to import statements 
using System;


//namespaces are spaces where we create classes to build our program
namespace HelloWorld
{
    //All C# Programs have a main class called Program
    class Program
    {
        //All Program Classes have a Main Method 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.Beep(400, 8000);
            Console.WriteLine("This is a Beep");
        }
    }
}
