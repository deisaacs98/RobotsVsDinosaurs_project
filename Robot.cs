using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Robot
    {
        public string name;
        public int health = 100;
        public int powerLevel=100;
        public Weapon weapon;
        public Weapon[] cache=new Weapon[4];


        public Robot(string name)
        {
            this.name = name;
            

        }
        public Weapon ChooseWeapon()
        {
            Weapon weapon=new Weapon("",0,0);
            bool run = true;
            do
            {
                
                Console.WriteLine("Choose a weapon:");
                Console.WriteLine();
                Console.WriteLine("a. Plasma Pistol      b. Death Ray                c. Broken Beer Bottle");
                Console.WriteLine("d. LASER TASER        e. Rock                     f. Spiked Bat");
                Console.WriteLine("g. Atomic RPG         h. Flamethrower             i. Folding Chair");
                Console.WriteLine("j. Phaser             k. Switchblade              l. Pool Cue");
                Console.WriteLine("m. Axe                n. Mustard Gas              o. Rolled Up Newspaper");
                Console.WriteLine("p. Shovel             q. Ninja Stars              r. Spray Bottle");

                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "a":
                        
                        weapon.type = "Plasma Pistol";
                        weapon.power = 30;
                        weapon.accuracy = 90;
                        run = false;
                        break;
                    case "b":
                        weapon.type = "Death Ray";
                        weapon.power = 80;
                        weapon.accuracy = 10;
                        run = false;
                        break;
                    case "c":
                        weapon.type = "Broken Beer Bottle";
                        weapon.power = 26;
                        weapon.accuracy = 90;
                        run = false;
                        break;
                    case "d":
                        
                        weapon.type = "LASERTASER";
                        weapon.power = 40;
                        weapon.accuracy = 90;
                        run = false;
                        break;
                    case "e":
                        
                        weapon.type = "Rock";
                        weapon.power = 3;
                        weapon.accuracy = 10;
                        run = false;
                        break;
                    case "f":
                        
                        weapon.type = "Spiked Bat";
                        weapon.power = 20;
                        weapon.accuracy = 54;
                        run = false;
                        break;
                    case "g":
                        
                        weapon.type = "Atomic RPG";
                        weapon.power = 100;
                        weapon.accuracy = 5;
                        run = false;
                        break;
                    case "h":
                        
                        weapon.type = "Flamethrower";
                        weapon.power = 50;
                        weapon.accuracy = 30;
                        run = false;
                        break;
                    case "i":
                        weapon.type = "Folding Chair";
                        weapon.power = 9;
                        weapon.accuracy = 60;
                        run = false;
                        break;
                    case "j":
                        weapon.type = "Phaser";
                        weapon.power = 16;
                        weapon.accuracy = 90;
                        run = false;    
                        break;
                    case "k":
                        weapon.type = "Switchblade";
                        weapon.power = 29;
                        weapon.accuracy = 90;
                        run = false;   
                        break;
                    case "l":
                        weapon.type = "Pool Cue";
                        weapon.power = 10;
                        weapon.accuracy = 90;
                        run = false;    
                        break;
                    case "m":
                        weapon.type = "Axe";
                        weapon.power = 28;
                        weapon.accuracy = 90;
                        run = false;
                        break;
                    case "n":
                        weapon.type = "Mustard Gas";
                        weapon.power = 60;
                        weapon.accuracy = 90;
                        run = false;
                        break;
                    case "o":
                        weapon.type = "Rolled Up Newspaper";
                        weapon.power = 10;
                        weapon.accuracy = 100;
                        run = false;
                        break;
                    case "p":
                        weapon.type = "Shovel";
                        weapon.power = 28;
                        weapon.accuracy = 90;
                        run = false;
                        break;
                    case "q":
                        weapon.type = "Ninja Stars";
                        weapon.power = 70;
                        weapon.accuracy = 90;
                        run = false;
                        break;
                    case "r":
                        weapon.type = "Spray Bottle";
                        weapon.power = 80;
                        weapon.accuracy = 100;
                        run = false;
                        break;

                    default:
                         
                        Console.WriteLine("Please enter the letter corresponding to the weapon.");
                        break;

                }
                    
                    

                
                
                
                
                

            } while (run);
            return weapon;
        }

    }

}
