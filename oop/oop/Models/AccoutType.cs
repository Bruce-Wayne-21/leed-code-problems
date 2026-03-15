using System;
using System.Collections.Generic;
using System.Text;

namespace oop.Models
 {
     public class AccoutType
     {
         public AccoutType(string name)
         {

         }
         public AccoutType AccoutTypes { get; set; }
         public string name { get; set; }
         
     }

    public abstract class Animal(string name, int age)
    {
        public string Name { get; } = name;
        public int Age { get; } = age;

        public abstract void Speak();


        public override string ToString() => $"{GetType().Name}: {Name}, Age: {Age}";
    }

    public class Dog(string name, int age) : Animal(name, age)
    {
        public override void Speak() => Console.WriteLine($"{Name} says: Woof!");
    }

    public class Cat(string name, int age) : Animal(name, age)
    {
        public override void Speak() => Console.WriteLine($"{Name} says: Meow!");
    }


}
