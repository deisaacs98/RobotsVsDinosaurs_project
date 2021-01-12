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
        public int energy=100;
        public DinosaurAttackType attack;
        public DinosaurAttackType[] attacks;
        


        public Dinosaur(string type)
        {
            this.type = type;
            

            
        }

        public DinosaurAttackType ChooseDinoAttack()
        {

            bool validInput = true;
            while (validInput)
            {
                Console.WriteLine("Choose an attack:");
                Console.WriteLine();
                Console.WriteLine("a. Bite               b. Stomp                    c. Scratch");
                Console.WriteLine("d. Tail Whip          e. Growl                    f. Roar");
                Console.WriteLine("g. Body Slam          h. Piledriver               i. Slap");
                Console.WriteLine("j. Spit               k. Punch                    l. Kick");

                        
        string selection = Console.ReadLine();
                switch (selection)
                {
                    case "a":
                        attack = new DinosaurAttackType("Bite", 30, 90);
                        break;
                    case "b":
                        attack = new DinosaurAttackType("Stomp", 80, 10);
                        break;
                    case "c":
                        attack = new DinosaurAttackType("Scratch", 0, 0);
                        break;
                    case "d":
                        attack = new DinosaurAttackType("Tail Whip", 40, 90);

                        break;
                    case "e":
                        attack = new DinosaurAttackType("Growl", 3, 10);

                        break;
                    case "f":
                        attack = new DinosaurAttackType("Roar", 0, 0);

                        break;
                    case "g":
                        attack = new DinosaurAttackType("Body Slam", 100, 5);

                        break;
                    case "h":
                        attack = new DinosaurAttackType("Piledriver", 0, 0);

                        break;
                    case "i":
                        attack = new DinosaurAttackType("Slap", 0, 0);

                        break;
                    case "j":
                        attack = new DinosaurAttackType("Spit", 15, 90);

                        break;
                    case "k":
                        attack = new DinosaurAttackType("Punch", 0, 0);

                        break;
                    case "l":
                        attack = new DinosaurAttackType("Kick", 0, 0);
                        break;
                    default:
                        validInput = false;
                        Console.WriteLine("Please enter the letter corresponding to the weapon.");
                        break;

                }

            }
            return attack;

        }

    }
}
