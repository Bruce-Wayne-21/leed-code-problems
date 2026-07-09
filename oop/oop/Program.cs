using oop;
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

        //leedcode.problms.Solution_3 solution_3 = new leedcode.problms.Solution_3();
        //string value = solution_3.ConvertToTitle(82595524);
        //Console.WriteLine(value);

        ////DSA.Datastructure.printnum();
        ////DSA.Datastructure.PrintNumber();

        //DSA.Datastructure.dowhile();


        leedcode.problms.solution_4.solition solution_4 = new leedcode.problms.solution_4.solition();
        //int[] array = new int[] { 2, 2, 1, 1, 1, 2, 2 };
        //int val = solution_4.MajorityElement(array);

        bool result = solution_4.IsIsomorphic("add","egg");




        Console.WriteLine(result);

        //Console.WriteLine(value);

        Console.ReadLine();

    }
}






