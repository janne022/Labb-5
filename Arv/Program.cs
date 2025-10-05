using System.Drawing;
using Arv;

internal class Program
{
    private static void Main(string[] args)
    {
        // Initiate animals
        Bulldog bulldog = new("Pär", 2, 10, 20);
        Retriever retriever = new("Buddy", 6, 10, 56);
        Cat cat = new("Jiji", 2, 10, 40, true);
        Chameleon chameleon = new("Stefan", 1, 2, 5);
        Human human = new("Olle", 25, 70, 24);

        // Intitiate list with animal objects
        List<Animal> animals = [bulldog, retriever, cat, chameleon, human];

        // Loop through all animals and use abstract method MakeSound()
        foreach (var animal in animals)
        {
            Console.Write($"{animal.Name} opens their mouth and makes a sound: ");
            animal.MakeSound();
        }

        // Try out chameleon changing color method
        chameleon.ChangeColor(color: ConsoleColor.Blue);

        // Try feeding one of the dogs some dogfood
        Console.WriteLine($"Giving {bulldog.Name} some dogfood. He is currently at {bulldog.Hunger} hunger.");
        bulldog.Eat(new DogFood());
        Console.WriteLine($"{bulldog.Name} hunger is now at: {bulldog.Hunger}.");
    }
}