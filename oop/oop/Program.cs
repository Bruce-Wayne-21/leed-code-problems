namespace Oop;


public class Program
{
    public static void Main()
    {
        var dog = new Dog("Buddy", 3);
        var cat = new Cat("Whiskers", 5);

        Animal[] animals = [dog, cat];

        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
            animal.Speak();
            Console.WriteLine();
        }
    }
}


// Abstraction & Encapsulation
public abstract class Animal(string name, int age)
{
    public string Name { get; } = name;
    public int Age { get; } = age;

    public abstract void Speak();

    public override string ToString() => $"{GetType().Name}: {Name}, Age: {Age}";
}

// Inheritance & Polymorphism
public class Dog(string name, int age) : Animal(name, age)
{
    public override void Speak() => Console.WriteLine($"{Name} says: Woof!");
}

public class Cat(string name, int age) : Animal(name, age)
{
    public override void Speak() => Console.WriteLine($"{Name} says: Meow!");
}

