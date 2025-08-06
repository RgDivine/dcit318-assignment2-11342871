using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_11342871
{
    using System;

    namespace Assignment2
    {
        class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Some generic sound");
            }
        }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Bark");
            }
        }

        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Animal myAnimal = new Animal();
                Animal myDog = new Dog();
                Animal myCat = new Cat();

                myAnimal.MakeSound();  // Outputs: Some generic sound
                myDog.MakeSound();     // Outputs: Bark
                myCat.MakeSound();     // Outputs: Meow
            }
        }
    }

}
