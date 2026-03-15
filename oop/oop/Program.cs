using oop.Models;
using System.Runtime.CompilerServices;

namespace Oop;


public class Program
{

    public static async Task Main()
    {


        Task.WhenAll(PrintOne(), PrintOneAsync());


    }


    public static async Task PrintOne()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Current number:one {i}");

            }
        });
    }

    public static async Task PrintOneAsync()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Current number:two {i}");
            }
        });
    }
}
// Abstraction & Encapsulation


// Inheritance & Polymorphism


