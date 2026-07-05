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

        //leedcode leedcode = new leedcode();
        //leedcode.Booking booking = new leedcode.Booking();

        //booking.Id = 1;
        //booking.CustomerName = "John Doe";
        //booking.PrintDetails();

        //leedcode.problms problms = new leedcode.problms();
        //await problms.PrintOneAsync();

        //leedcode.problms.solution_2 solution_2 = new leedcode.problms.solution_2();
        //var value = solution_2.ConvertToTitle(82595524
        //

        leedcode.problms.Solution_3 solution_3 = new leedcode.problms.Solution_3();
        string value = solution_3.ConvertToTitle(82595524);
        Console.WriteLine(value);

        //DSA.Datastructure.printnum();
        //DSA.Datastructure.PrintNumber();

        DSA.Datastructure.dowhile();




        //Console.WriteLine(value);

        //Console.WriteLine(value);

        Console.ReadLine();

    }
}






