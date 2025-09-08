using System.Drawing;
using Arv;

internal class Program
{
    private static void Main(string[] args)
    {
        Bulldog bulldog = new(age: 2, weight: 10, speed: 20);
        Retriever retriever = new(age: 6, weight: 10, speed: 56);
        Cat cat = new(age: 2, weight: 10, speed: 40, isLitterBoxTrained: true);
        Chameleon chameleon = new(age: 1, weight: 2, speed: 5);

        bulldog.MakeSound();
        retriever.MakeSound();
        cat.MakeSound();
        chameleon.MakeSound();
        chameleon.ChangeColor(color: Color.White);

        Console.WriteLine(bulldog.Hunger);
        bulldog.Eat(new DogFood());
        Console.WriteLine(bulldog.Hunger);
    }
}