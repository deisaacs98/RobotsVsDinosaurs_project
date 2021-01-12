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

        public Dinosaur[] dinosaurs=new Dinosaur[3];

        Dinosaur dinosaur1 = new Dinosaur("T-Rex");
        Dinosaur dinosaur2 = new Dinosaur("Velociraptor");
        Dinosaur dinosaur3 = new Dinosaur("Ankylosaurus");

       
        public Herd(Dinosaur[] dinosaurs)
        {
            this.dinosaurs = dinosaurs;
        }
        public void AddDinosaursToHerd()
        {
            dinosaurs[0]=dinosaur1;
            dinosaurs[1]=dinosaur2;
            dinosaurs[2]=dinosaur3;
        }

        public void AddAttacks()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    dinosaurs[i].attacks[j] = dinosaurs[i].ChooseDinoAttack();
                }
            }

        }
    }
}
