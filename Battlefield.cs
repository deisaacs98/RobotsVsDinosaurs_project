using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        public Fleet fleet;
        public Herd herd;
        public Weapon weapon;
        public DinosaurAttackType attack;
        public bool run = true;
        
        
        public Battlefield()
        {
        
        }

        public void AttackDinosaur(Robot robot,Dinosaur dinosaur)
        {


            
            bool validInput = true;
            while (validInput)
            {
                Console.WriteLine(dinosaur + ":     Choose your weapon:");
                Console.WriteLine("a. " + dinosaur.attacks[0] + "           b. " + dinosaur.attacks[1]);
                Console.WriteLine("c. " + dinosaur.attacks[2] + "           d. " + dinosaur.attacks[4]);

                string selection = Console.ReadLine();
                switch (selection)
                {

                    case "a":
                        weapon = robot.cache[0];

                        break;
                    case "b":
                        weapon = robot.cache[1];
                        break;
                    case "c":
                        weapon = robot.cache[2];
                        break;
                    case "d":
                        weapon = robot.cache[3];

                        break;
                    default:
                        validInput = false;
                        Console.WriteLine("Please enter the letter corresponding to the weapon.");
                        break;
                }
                

            }
            robot.powerLevel -= 10;
            int accuracy = weapon.accuracy;
            int power = weapon.power;
            Random random = new Random();
            int random1 = random.Next(1,101);
            if(random1<=accuracy)
            {
                dinosaur.health -= power;
            }

        }

         public void AttackRobot(Dinosaur dinosaur, Robot robot)
        {
            bool validInput = true;
            while (validInput)
            {
                Console.WriteLine(dinosaur + ":     Choose your move.");
                Console.WriteLine("a. " + dinosaur.attacks[0] + "           b. " + dinosaur.attacks[1]);
                Console.WriteLine("c. " + dinosaur.attacks[2] + "           d. " + dinosaur.attacks[3]);
                dinosaur.energy -= 10;
                DinosaurAttackType attack;
                string selection = Console.ReadLine();
                switch (selection)
                {

                    case "a":
                        attack = dinosaur.attacks[0];
                        break;
                    case "b":
                        attack = dinosaur.attacks[1];
                        break;
                    case "c":
                        attack = dinosaur.attacks[2];
                        break;
                    case "d":
                        attack = dinosaur.attacks[3];

                        break;
                    default:
                        validInput = false;
                        Console.WriteLine("Please enter the letter corresponding to the weapon.");
                        break;

                }
            }
            dinosaur.energy -= 10;
            int accuracy = attack.accuracy;
            int power = attack.power;
            Random random = new Random();
            int random1 = random.Next(1, 101);
            if (random1 <= accuracy)
            {
                robot.health -= power;
                Console.WriteLine(dinosaur+" has attacked "+robot+"!");
                Console.WriteLine(dinosaur+"'s energy is now "+dinosaur.energy);
                Console.WriteLine(robot+"'s health is now "+robot.health);
            }

        }

        public void Battle()
        {
            while (run)
            {
                fleet.AddRobotsToFleet();
                herd.AddDinosaursToHerd();
                fleet.AddWeaponsToCache();
                herd.AddAttacks();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Robot robot = fleet.fleet[i];
                        Dinosaur dinosaur = herd.dinosaurs[j];
                        if (robot.powerLevel > 0 && dinosaur.health > 0)
                        {
                            AttackDinosaur(robot, dinosaur);
                            AttackRobot(dinosaur, robot);
                        }
                    }
                }
            }
            
        }

        
    }
}
