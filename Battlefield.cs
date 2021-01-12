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
         
        
        
        
        int brokenBots = 0;
        int deadDinos = 0;


        public Battlefield()
        {
        
        }

        public void AttackDinosaur(Robot robot,Dinosaur dinosaur)
        {


            
            bool validInput = true;
            while (validInput)
            {
                Console.WriteLine(dinosaur + ":     Choose your attack:");
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
                Console.WriteLine(robot + " has attacked " + dinosaur + "!");
                Console.WriteLine(robot + "'s power level is now " + robot.powerLevel);
                Console.WriteLine(dinosaur + "'s health is now " + dinosaur.health);
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
        public void RobotTurn()
        {

            for (int i = 0; i < 3; i++)
            {
                Robot robot = fleet.fleet[i];

                if (robot.powerLevel > 0 && robot.health > 0 && brokenBots < 3)
                {

                    for (int j = 0; j < 3; j++)
                    {
                        Dinosaur dinosaur = herd.dinosaurs[j];
                        if (dinosaur.energy > 0 && dinosaur.health > 0)
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
            for (int i = 0; i < 3; i++)
            {
                Dinosaur dinosaur = herd.dinosaurs[i];

                if (dinosaur.energy > 0 && dinosaur.health > 0 && deadDinos < 3)
                {

                    for (int j = 0; j < 3; j++)
                    {
                        Robot robot = fleet.fleet[j];
                        if (robot.powerLevel > 0 && robot.health > 0)
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
            }

        }
        public void Battle()
        {
            fleet.AddRobotsToFleet();
            herd.AddDinosaursToHerd();
            fleet.AddWeaponsToCache();
            herd.AddAttacks();

            while (deadDinos<3&&brokenBots<3)
            {
                RobotTurn();
                DinoTurn();

                
                    
            }
            if(brokenBots==3)
            {
                Console.WriteLine("The dinosaurs have won the battle.");
            }
            else
            {
                Console.WriteLine("The robots have won the battle.");
            }
            Console.ReadLine();

        }
    }
}