using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }

        public bool ShedsSkin { get; set; }

        public string Habitat { get; set; }

        public bool LaysEggs { get; set; }

        public Reptile()
        {


        }

        public Reptile(string species, bool hasVertebrate, bool isCarnivore, int Legs, bool isColdBlooded, bool shedsSkin, string habitat, bool laysEggs)
        {
            Species = species;
            HasVertebrate = hasVertebrate;
            IsCarnivore = isCarnivore;
            IsColdBlooded = isColdBlooded;
            ShedsSkin = shedsSkin;
            Habitat = habitat;
            LaysEggs = laysEggs;

        }
          


    }

}
