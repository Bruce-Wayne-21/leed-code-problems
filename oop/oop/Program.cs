using oop;
using oop.Models;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;


namespace Oop;


public class Program
{

    public static async Task Main(string[] args)
    {

        leedcode leedcode = new leedcode();
        leedcode.Booking booking = new leedcode.Booking();

        booking.Id = 1;
        booking.CustomerName = "John Doe";
        booking.PrintDetails();

        //Console.WriteLine(value);

        Console.ReadLine();

    }
}






