using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    internal class DSA
    {
        public class Datastructure
        {
            public static void PrintNumber()
            {
                int number = 0;
                int i = 0;
                string j = Console.ReadLine();
                int.TryParse(j, out i);

                while (number > i)
                {
                    Console.WriteLine(number);
                     number ++;
                }

            }


            public static void printnum()
            {
                int num = 0;
                while(num < 5)
                {
                    Console.WriteLine(num);
                    num++;

                }
            }


            public static void dowhile()
            {
                int count = 10;
                do
                {
                    Console.WriteLine($"This is a do-while loop.{count}");
                    count++;

                }
                while (count < 3);
            }
        }
    }
}
