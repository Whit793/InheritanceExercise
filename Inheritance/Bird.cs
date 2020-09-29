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

        public string Call { get; set; }

        public Bird()
        {

        }

        public Bird(string species, bool hasvertebrate, bool iscarnivore, int legs, bool hasflight, bool hasbeak, int talons, string call)
        {
            Species = species;
            HasVertebrate = hasvertebrate;
            IsCarnivore = iscarnivore;
            Legs = legs;
            HasFlight = hasflight;
            HasBeak = hasbeak;
            Talons = talons;
            Call = call;





        }

    }
}
