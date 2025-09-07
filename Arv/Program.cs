using System.Drawing;
using Arv;

Bulldog bulldog = new Bulldog(age: 2, weight: 10, species: "Canis lupus familiaris", diet: "Dog Food", speed: 20);
Retriever retriever = new Retriever(age: 6, weight: 10, species: "Canis lupus familiaris", diet: "Dog Food", speed: 56);
Cat cat = new Cat(age: 2, weight: 10, species: "Felidae", diet: "Canned Tuna", speed: 40, isLitterBoxTrained: true);
Chameleon chameleon = new Chameleon(age: 1, weight: 2, species: "Chamaeleonidae ", diet: "Bugs", speed: 5);

bulldog.MakeSound();
retriever.MakeSound();
cat.MakeSound();
chameleon.MakeSound();
chameleon.ChangeColor(color: Color.White);

System.Console.WriteLine(bulldog.Hunger);
bulldog.Eat(new DogFood());
System.Console.WriteLine(bulldog.Hunger);