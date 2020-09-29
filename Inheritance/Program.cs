using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             * 
             * 
         
         
             */

            Bird BaldEagle = new Bird("Eagle", false, true, 2, true, true, 6);

            Console.WriteLine($"The {BaldEagle.Species} is an impressive bird of prey.  Usling its {BaldEagle.Talons} sharp talons, attached to {BaldEagle.Legs}");
            Console.WriteLine($" powerful legs, it devours its prey.");
            Console.WriteLine("");
            Console.WriteLine($"Does the Bald Eagle only eat meat?  {BaldEagle.IsCarnivore}, it is a carnivore");
            Console.WriteLine($" You may ask yourself, does it also use it's beak?  Why yes, that is {BaldEagle.HasBeak}.");
            Console.WriteLine("On top of all that, it can also fly!");
            Console.WriteLine("");
            Console.WriteLine("");

            Reptile Saltwater = new Reptile("Crocodile", true, true, 4, true, true, "brackish water, or oceans", true);

            Console.WriteLine($" Next we meet the massive Saltwater {Saltwater.Species}.  These powerful reptiles most live in");
            Console.WriteLine($" {Saltwater.Habitat}, where they swim with their strong {Saltwater.Legs}, and even run on land.");
            Console.WriteLine($"They can grow up to 27 feet in length, and have been known to hunt humans");
            Console.WriteLine($"Despite the fact that, {Saltwater.LaysEggs}, they do still raise their young for longer than");
            Console.WriteLine($"other species");





        }
    }
}
