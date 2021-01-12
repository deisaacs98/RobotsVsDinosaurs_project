using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Dinosaur
    {
        public string type;
        public int health = 100;
        public int energy=100;
        
        public DinosaurAttackType[] attacks= new DinosaurAttackType[4];
        


        public Dinosaur(string type)
        {
            this.type = type;
            

            
        }

        public DinosaurAttackType ChooseDinoAttack()
        {
            DinosaurAttackType attack=new DinosaurAttackType("",0,0);
            bool run = true;
            do
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
                        attack.type = "Bite";
                        attack.power = 30;
                        attack.accuracy = 90;
                        run = false;
                        break;
                    case "b":
                        attack.type = "Stomp";
                        attack.power = 80;
                        attack.accuracy = 30;
                        run = false;
                        break;
                    case "c":
                        attack.type = "Scratch";
                        attack.power = 10;
                        attack.accuracy = 80;
                        run = false;
                        break;
                    case "d":
                        attack.type = "Tail Whip";
                        attack.power = 40;
                        attack.accuracy = 90;
                        run = false;

                        break;
                    case "e":
                        attack.type = "Growl";
                        attack.power = 3;
                        attack.accuracy = 95;
                        run = false;

                        break;
                    case "f":
                        attack.type = "Roar";
                        attack.power = 4;
                        attack.accuracy = 94;
                        run = false;

                        break;
                    case "g":
                        attack.type = "Body Slam";
                        attack.power = 26;
                        attack.accuracy = 98;
                        run = false;

                        break;
                    case "h":
                        attack.type = "Piledriver";
                        attack.power = 60;
                        attack.accuracy = 60;
                        run = false;

                        break;
                    case "i":
                        attack.type = "Slap";
                        attack.power = 10;
                        attack.accuracy = 98;
                        run = false;

                        break;
                    case "j":
                        attack.type = "Spit";
                        attack.power = 15;
                        attack.accuracy = 90;
                        run = false;

                        break;
                    case "k":
                        attack.type = "Punch";
                        attack.power = 10;
                        attack.accuracy = 93;
                        run = false;

                        break;
                    case "l":
                        attack.type = "Kick";
                        attack.power = 20;
                        attack.accuracy = 80;
                        run = false;
                        break;
                    default:
                        
                        Console.WriteLine("Please enter the letter corresponding to the attack.");
                        break;

                }

            }while (run) ;
            return attack;

        }

    }
}
