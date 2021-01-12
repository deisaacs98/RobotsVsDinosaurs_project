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
        public Weapon[] cache;


        public Robot(string name)
        {
            this.name = name;

        }
        public Weapon ChooseWeapon()
        {
            bool run = true;
            while (run)
            {
                
                Console.WriteLine("Choose a weapon:");
                Console.WriteLine();
                Console.WriteLine("a. Plasma Pistol      b. Death Ray                c. Broken Beer Bottle");
                Console.WriteLine("d. LASER TASER        e. Rock                     f. Spiked Bat");
                Console.WriteLine("g. Atomic RPG         h. Flamethrower             i. Folding Chair");
                Console.WriteLine("j. Phaser             k. Switchblade              l. Pool Cue");

                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "a":
                        weapon = new Weapon("Plasma Pistol", 30, 90);
                            
                        break;
                    case "b":
                        weapon = new Weapon("Death Ray", 80, 10);
                           
                        break;
                    case "c":
                        weapon = new Weapon("Broken Beer Bottle", 0, 0);
                            
                        break;
                    case "d":
                            weapon = new Weapon("LASER TASER", 40, 90);
                            
                        break;
                    case "e":
                        weapon = new Weapon("Rock", 3, 10);
                            
                        break;
                    case "f":
                        weapon = new Weapon("Spiked Bat", 0, 0);
                        break;
                    case "g":
                        weapon = new Weapon("Atomic RPG", 100, 5);
                            
                        break;
                    case "h":
                        weapon = new Weapon("Flamethrower", 0, 0);
                            
                        break;
                    case "i":
                        weapon = new Weapon("Folding Chair", 0, 0);
                            
                        break;
                    case "j":
                        weapon = new Weapon("Phaser", 15, 90);
                            
                        break;
                    case "k":
                        weapon = new Weapon("Switchblade", 0, 0);
                            
                        break;
                    case "l":
                        weapon = new Weapon("Pool Cue", 0, 0);
                            
                        break;
                    default:
                         
                        Console.WriteLine("Please enter the letter corresponding to the weapon.");
                        continue;

                }
                    
                    

                
                
                
                
                

            }
            return weapon;
        }

    }

}
