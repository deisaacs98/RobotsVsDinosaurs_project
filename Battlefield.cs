using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Battlefield
    {
        
        public Fleet fleet = new Fleet();
        
        public Herd herd = new Herd();
        public Weapon weapon;
        public DinosaurAttackType attack;
        public Dinosaur dinosaur;
        public Robot robot;
        public Weapon[] cache;
        public DinosaurAttackType[] attacks;
        
        
        
        int brokenBots = 0;
        int deadDinos = 0;


        public Battlefield()
        {
        
        }

        public void AttackDinosaur(Robot robot,Dinosaur dinosaur)
        {


            
            Weapon weapon= new Weapon("", 0, 0);
            bool validInput = true;
            do
            {
                Console.Clear();
                Console.WriteLine(robot.name + ":     Choose your attack:");
                Console.WriteLine("a. " + robot.cache[0].type + "           b. " + robot.cache[1].type);
                Console.WriteLine("c. " + robot.cache[2].type + "           d. " + robot.cache[3].type);

                string selection = Console.ReadLine();
                switch (selection)
                {

                    case "a":
                        weapon = robot.cache[0];
                        validInput = false;
                        break;
                        
                    case "b":
                        weapon = robot.cache[1];
                        validInput = false;
                        break;
                    case "c":
                        weapon = robot.cache[2];
                        validInput = false;
                        break;
                    case "d":
                        weapon = robot.cache[3];
                        validInput = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter the letter corresponding to the weapon.");
                        break;
                }

               
            } while (validInput);

            robot.powerLevel -= 10;
            int accuracy = weapon.accuracy;
            int power = weapon.power;
            Random random = new Random();
            int random1 = random.Next(1,101);
            if(random1<=accuracy)
            {
                dinosaur.health -= power;
                if(dinosaur.health<0)
                {
                    dinosaur.health = 0;
                }
                Console.Clear();
                Console.WriteLine(robot.name + " has attacked " + dinosaur.type + "!");
                Console.WriteLine(robot.name + "'s power level is now " + robot.powerLevel);
                Console.WriteLine(dinosaur.type + "'s health is now " + dinosaur.health);
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine(robot.name + " missed!");
                Console.WriteLine(robot.name + "'s power level is now " + robot.powerLevel);
                Console.WriteLine(dinosaur.type + "'s health is still " + dinosaur.health);
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
            }

        }

        public void AttackRobot(Dinosaur dinosaur, Robot robot)
        {
            
            
            DinosaurAttackType attack = new DinosaurAttackType("", 0, 0);
            
            bool validInput = true;
            do
            {
                Console.Clear();
                Console.WriteLine(dinosaur.type + ":     Choose your move.");
                Console.WriteLine("a. " + dinosaur.attacks[0].type + "           b. " + dinosaur.attacks[1].type);
                Console.WriteLine("c. " + dinosaur.attacks[2].type + "           d. " + dinosaur.attacks[3].type);

                string selection = Console.ReadLine();
                switch (selection)
                {

                    case "a":
                        attack = dinosaur.attacks[0];
                        validInput = false;
                        break;
                    case "b":
                        attack = dinosaur.attacks[1];
                        validInput = false;
                        break;
                    case "c":
                        attack = dinosaur.attacks[2];
                        validInput = false;
                        break;
                    case "d":
                        attack = dinosaur.attacks[3];
                        validInput = false;

                        break;
                    default:

                        Console.Clear();
                        Console.WriteLine("Please enter the letter corresponding to the weapon.");
                        break;

                }

            } while (validInput);
            dinosaur.energy -= 10;
            int accuracy = attack.accuracy;
            int power = attack.power;
            Random random = new Random();
            int random1 = random.Next(1, 101);
            if (random1 <= accuracy)
            {
                robot.health -= power;
                if(robot.health<0)
                {
                    robot.health = 0;
                }
                Console.Clear();
                Console.WriteLine(dinosaur.type+" has attacked "+robot.name+"!");
                Console.WriteLine(dinosaur.type+"'s energy is now "+dinosaur.energy);
                Console.WriteLine(robot.name+"'s health is now "+robot.health);
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine(dinosaur.type + " missed!");
                Console.WriteLine(dinosaur.type + "'s energy is now " + dinosaur.energy);
                Console.WriteLine(robot.name + "'s health is still " + robot.health);
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
            }

        }
        public void RobotTurn()
        {
            Robot robot;
            Dinosaur dinosaur;

            for (int i = 0; i < 3; i++)
            {
                
                robot = fleet.fleet[i];

                if (robot.powerLevel > 0 && robot.health > 0 && brokenBots < 3)
                {

                    for (int j = 0; j < 3; j++)
                    {
                        dinosaur = herd.dinosaurs[j];
                        if (dinosaur.health > 0)
                        {
                            AttackDinosaur(robot, dinosaur);
                            if (dinosaur.health <= 0)
                            {
                                deadDinos++;
                            }
                            if (robot.powerLevel <= 0)
                            {
                                brokenBots++;
                            }
                            break;
                        }
                        else
                        {
                            continue;
                        }

                    }

                }
                else
                {
                    continue;
                }
            
            }
            
        }
        public void DinoTurn()
        {
            Robot robot;
            Dinosaur dinosaur;
            for (int i = 0; i < 3; i++)
            {
                dinosaur = herd.dinosaurs[i];

                if (dinosaur.energy > 0 && dinosaur.health > 0 && deadDinos < 3)
                {

                    for (int j = 0; j < 3; j++)
                    {
                        robot = fleet.fleet[j];
                        if (robot.health > 0)
                        {
                            AttackRobot(dinosaur, robot);
                            if (robot.health <= 0)
                            {
                                brokenBots++;
                            }
                            if (dinosaur.energy <= 0)
                            {
                                deadDinos++;
                            }
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                }
                else
                {
                    continue;
                }
                break;
            }

        }
        public void Battle()
        {
            bool runGame = true;
            while (runGame)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("           ROBOTS VS DINOSAURS");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("         Press Enter to Continue");
                Console.ReadLine();
                Console.Clear();
                fleet.AddRobotsToFleet();
                herd.AddDinosaursToHerd();
                Console.WriteLine("Robots go first.");
                fleet.AddWeaponsToCache();
                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Now it is the Dinosaurs turn.");
                herd.AddAttacks();
                Console.WriteLine("Press Enter to Continue");
                Console.ReadLine();

                while (deadDinos < 3 && brokenBots < 3)
                {
                    RobotTurn();
                    DinoTurn();



                }
                if (brokenBots == 3)
                {
                    Console.Clear();
                    Console.WriteLine("The dinosaurs have won the battle.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("The robots have won the battle.");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Would you like to play again? (Y/N)");
                string playerResponse = Console.ReadLine();
                if (playerResponse == "y" || playerResponse == "Y")
                {
                    runGame = true;
                    Console.Clear();
                }
                else
                {
                    runGame = false;
                }
            }
        }
    }
}