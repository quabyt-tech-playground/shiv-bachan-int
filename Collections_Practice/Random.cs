using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Practice
{


    // Base class
    class Animal
    {
        public string Name { get; set; }

        // Constructor in the base class
        public Animal(string name)
        {
            Name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }
    // Derived class inheriting from the base class
    class Dog : Animal
    {
        public string Breed { get; set; }

        // Constructor in the derived class using base keyword
        public Dog(string name, string breed) :base(name)
        {
          
            Breed = breed;
        }

        // Override the MakeSound method in the derived class
        public new void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }

        public void Bark()
        {
            // Using base to call the method from the base class
            base.MakeSound();
        }
    }
    class Random
    {
        static void Main()
        {
            // Create an instance of the derived class
            Dog myDog = new Dog("Buddy", "Labrador");

            // Access properties from the base class
            Console.WriteLine($"Name: {myDog.Name}, Breed: {myDog.Breed}");

            // Call the overridden method from the derived class
            myDog.MakeSound();

            // Call the method from the base class using base keyword
            myDog.Bark();
        }


    }
    }