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

        Dinosaur dinosaur1 = new Dinosaur("T-Rex");
        Dinosaur dinosaur2 = new Dinosaur("Velociraptor");
        Dinosaur dinosaur3 = new Dinosaur("Ankylosaurus");

        public DinosaurAttackType[] attacks = new DinosaurAttackType[4];

        public void AddDinosaursToHerd()
        {
            dinosaurs.Add(dinosaur1);
            dinosaurs.Add(dinosaur2);
            dinosaurs.Add(dinosaur3);
        }

        public DinosaurAttackType attack1 = new DinosaurAttackType("Bite");
        public DinosaurAttackType attack2 = new DinosaurAttackType("Stomp");
        public DinosaurAttackType attack3 = new DinosaurAttackType("Scratch");
        public DinosaurAttackType attack4 = new DinosaurAttackType("Tail Whip");
        public DinosaurAttackType attack5 = new DinosaurAttackType("Growl");
        public DinosaurAttackType attack6 = new DinosaurAttackType("Roar");
        public DinosaurAttackType attack7 = new DinosaurAttackType("Body Slam");
        public DinosaurAttackType attack8 = new DinosaurAttackType("Piledriver");
        public DinosaurAttackType attack9 = new DinosaurAttackType("Slap");
        public DinosaurAttackType attack10 = new DinosaurAttackType("Spit");
        public DinosaurAttackType attack11 = new DinosaurAttackType("Punch");
        public DinosaurAttackType attack12 = new DinosaurAttackType("Kick");
    }
}
