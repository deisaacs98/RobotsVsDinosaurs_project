using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Herd
    {
        //Dinosaurs are stored here.

        public Dinosaur[] dinosaurs;

        public Dinosaur dinosaur1 = new Dinosaur("T-Rex");
        public Dinosaur dinosaur2 = new Dinosaur("Velociraptor");
        public Dinosaur dinosaur3 = new Dinosaur("Ankylosaurus");

       
        public Herd()
        {
            this.dinosaurs = new Dinosaur[3];
        }
        public void AddDinosaursToHerd()
        {
            dinosaurs[0]=dinosaur1;
            dinosaurs[1]=dinosaur2;
            dinosaurs[2]=dinosaur3;
        }

        public void AddAttacks()
        {
            DinosaurAttackType attack;
            Console.WriteLine("Each dinosaur can choose four attacks. Choose wisely.");
            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(dinosaur1.type + ":");
                attack = dinosaur1.ChooseDinoAttack();
                dinosaur1.attacks[i] = attack;
                Console.Clear();
                Console.WriteLine("You have added " + attack.type + " to your cache.");

            }
            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(dinosaur2.type + ":");
                attack = dinosaur2.ChooseDinoAttack();
                dinosaur2.attacks[i] = attack;
                Console.Clear();
                Console.WriteLine("You have added " + attack.type + " to your cache.");

            }
            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(dinosaur3.type + ":");
                attack = dinosaur3.ChooseDinoAttack();
                dinosaur3.attacks[i] = attack;
                Console.Clear();

                Console.WriteLine("You have added " + attack.type + " to your cache.");

            }

        }
    }
}
