using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        //Dinosaurs are stored here.

        public List<Dinosaur> dinosaurs;

        Dinosaur dinosaur1 = new Dinosaur();
        Dinosaur dinosaur2 = new Dinosaur();
        Dinosaur dinosaur3 = new Dinosaur();

        public void AddDinosaursToHerd()
        {
            dinosaurs.Add(dinosaur1);
            dinosaurs.Add(dinosaur2);
            dinosaurs.Add(dinosaur3);
        }
    }
}
