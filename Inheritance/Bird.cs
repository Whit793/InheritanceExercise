using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        public bool HasFlight { get; set; }

        public bool HasBeak { get; set; }

        public int Talons { get; set; }

        public void Call()
        {
            Console.WriteLine("CawCaw");
        }

        public Bird()
        {

        }

        public Bird(string species, bool hasVertebrate, bool isCarnivore, int legs, bool hasFlight, bool hasBeak, int talons )
        {
            Species = species;
            HasVertebrate = hasVertebrate;
            IsCarnivore = isCarnivore;
            Legs = legs;
            HasFlight = hasFlight;
            HasBeak = hasBeak;
            Talons = talons;
            





        }

    }
}
