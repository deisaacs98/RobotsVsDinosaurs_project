using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        public string type;
        public int health = 100;
        public int energy;
        public DinosaurAttackType attack;
        


        public Dinosaur(string type, int energy)
        {
            this.type = type;
            this.energy = energy;

            
        }

        public DinosaurAttackType ChooseDinoAttack()
        {
            Console.WriteLine("Choose an attack:");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "a":
                    attack = new DinosaurAttackType("Plasma Pistol", 0, 0);
                    return attack;
                case "b":
                    attack = new DinosaurAttackType("LASER TASER", 0, 0);
                    return attack;
                case "c":
                    attack = new DinosaurAttackType("Atomic RPG", 0, 0);
                    return attack;
                case "d":
                    attack = new DinosaurAttackType("Phaser", 0, 0);
                    return attack;
                case "e":
                    attack = new DinosaurAttackType("Death Ray", 0, 0);
                    return attack;
                case "f":
                    attack = new DinosaurAttackType("Rock", 0, 0);
                    return attack;
                case "g":
                    attack = new DinosaurAttackType("Flamethrower", 0, 0);
                    return attack;
                case "h":
                    attack = new DinosaurAttackType("Switchblade", 0, 0);
                    return attack;
                case "i":
                    attack = new DinosaurAttackType("Broken Beer Bottle", 0, 0);
                    return attack;
                case "j":
                    attack = new DinosaurAttackType("Spiked Bat", 0, 0);
                    return attack;
                case "k":
                    attack = new DinosaurAttackType("Folding Chair", 0, 0);
                    return attack;
                case "l":
                    attack = new DinosaurAttackType("Pool Cue", 0, 0);
                    return attack;


            }
            weapon = new Weapon(type, 100, 100);
            i
            return weapon;
        }

    }
}
