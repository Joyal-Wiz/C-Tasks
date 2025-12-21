using System;

class Animal
{
    public string Name;
    public int Age;

    public void Speak()
    {
        Console.WriteLine("Name: " + Name + ", Age: " + Age);
    }
}


class Dog : Animal
{
    public string Breed;
}


class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Meow!");
    }
}

class Program
{
    static void Main(string[] args)
    {
     
        Dog dog = new Dog();
        dog.Name = "Buddy";
        dog.Age = 3;
        dog.Breed = "Golden Retriever";
        dog.Speak();

        Cat cat = new Cat();
        cat.Name = "Whiskers";
        cat.Age = 2;
        cat.Speak();
        cat.Meow();
    }
}
