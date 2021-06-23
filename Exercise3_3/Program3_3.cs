using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3_3
{
    class Program3_3
    {
        /*F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut,
     *      i vilken klass bör vi lägga det?
     *          S: I subklasses "Bird"
        F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
                S: I subklassen "Animal"
        F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
                S: För det finns inget i koden som kan konvertera mellan dem.
        F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
                S: Det mest basiska klassen, då man bara kan ta med bas klassen och alla dens subklasser.
        F: Förklara vad det är som händer.
                S: I varje foreach loop checkar vi den mest specialicerade varianten av stats.
        Kommer du åt den metoden från Animals listan?
        F: Varför inte?
                S: Subklasser ärver från sina basklasser, basklasser kan inte ärva från sina subklasser
    */
        static void Main()
        {
            List<Animal> animals = new();
            animals.Add(new Horse("Hela", 10, 500, "yes"));
            animals.Add(new Dog("Trollet", 15, 30, "Brown"));
            animals.Add(new Hedgehog("Kotten", 7, 5, 5000));
            animals.Add(new Bird("Jago", 5, 0.5, 0.5));
            animals.Add(new Pelican("Rosa", 5, 10, 2, 2));
            animals.Add(new Wolfman("Carn", 35, 90, "No", "Leave before I get hungry"));

            Console.WriteLine("**");
            int i = 0;
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"The list contains in spot nr. {i}: {animal.GetType().Name}");
                if (animal is IPerson person)
                {
                    person.Talk();
                }
                else
                {
                    animal.Dosound();
                }
                i++;
            }
            List<Dog> dogs = new();
            dogs.Add(new Dog("Mysak", 20, 30, "Black"));
            dogs.Add(new Dog("Winnie", 12, 30, "Blond"));
            dogs.Add(new Dog("Buzan", 13, 30, "Blond"));

            //dogs.Add(new Horse("Hela", 10, 500, "yes"));

            Console.WriteLine("**");
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }


            foreach (Dog dog in dogs)
            {
                animals.Add(dog);
            }
            Console.WriteLine("**");
            foreach (Dog dogs1 in animals.OfType<Dog>())
            {
                Console.WriteLine(dogs1.Stats());
            }


            Console.WriteLine("**");
            foreach (Dog dogs1 in animals.OfType<Dog>())
            {
                dogs1.GoodDog();
            }

        }
    }
}
