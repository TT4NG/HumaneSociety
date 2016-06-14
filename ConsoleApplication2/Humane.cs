using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Humane
    {
        enum animal {dog, bird, cat };
        enum dogbreed {Shiba, Schnauser, Corgi, Irishwolfhound, GermanPinscher };
        enum birdbreed { Cockatiel, Canary, Kingfisher}
        enum catbreed { Tabby, Egyptian, Persian}
        enum age { one, two, three, four, five, six, seven, eight, nine, ten};
        Random random = new Random();

        public void enlist()
        {
            string[] animals = Enum.GetNames(typeof(animal));
            Console.WriteLine("Welcome to the Humane Society" + "\n" + "Select an animal pen: ");
            foreach (string animal in animals)
            {

                Console.WriteLine(animal);
            }
            string choice = Console.ReadLine();
            
            if (choice == animals[0])
            {
                Console.WriteLine("\n" + "To the Dog Kennels!");
                Dog();
            }
            else if (choice == animals[1])
            {
                Console.WriteLine("\n" + "To the Bird Sanctuary!");
                Bird();
            }
            else if (choice == animals[2])
            {
                Console.WriteLine("\n" + "To the Cat Litter!");
                Cat();
            }
            else
            {
                Console.WriteLine("invalid choice");
                enlist();
            }
        }
        public void Dog()
        {
            string[] dogs = Enum.GetNames(typeof(dogbreed));
            string[] age = Enum.GetNames(typeof(age));
            Console.WriteLine("BARK" + "\n");
            for (int i = 0; i <dogs.Length; i++)
            {
                int rand = random.Next(0, age.Length);
                Console.WriteLine(dogs[i] + " - " + age[rand] + " years old");
            }
            Console.WriteLine("\n");
            enlist();
        }
        public void Cat()
        {
            string[] cats = Enum.GetNames(typeof(catbreed));
            string[] age = Enum.GetNames(typeof(age));
            Console.WriteLine("MEOW!!" + "\n");
            for (int i = 0; i < cats.Length; i++)
            {
                int rand = random.Next(0, age.Length);
                Console.WriteLine(cats[i] + " - " + age[rand] + " years old");
            }
            Console.WriteLine("\n");
            enlist();
        }
        public void Bird()
        {
            string[] birds = Enum.GetNames(typeof(birdbreed));
            string[] age = Enum.GetNames(typeof(age));
            Console.WriteLine("Chirp!" + "\n");
            for (int i = 0; i < birds.Length; i++)
            {
                int rand = random.Next(0, age.Length);
                Console.WriteLine(birds[i] + " - " + age[rand] + " years old");
                
            }
            Console.WriteLine("\n");
            enlist();
        }
    }
}
