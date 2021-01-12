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
                        weapon = new Weapon("LASER TASER", 40, 90);
                        weapon.type = "LASERTASER";
                        weapon.power = 40;
                        weapon.accuracy = 90;
                        run = false;
                        break;
                    case "e":
                        weapon = new Weapon("Rock", 3, 10);
                        weapon.type = "Rock";
                        weapon.power = 3;
                        weapon.accuracy = 10;
                        run = false;
                        break;
                    case "f":
                        weapon = new Weapon("Spiked Bat", 20, 54);
                        weapon.type = "Spiked Bat";
                        weapon.power = 20;
                        weapon.accuracy = 54;
                        break;
                    case "g":
                        weapon = new Weapon("Atomic RPG", 100, 5);
                        weapon.type = "Atomic RPG";
                        weapon.power = 100;
                        weapon.accuracy = 5;
                        run = false;
                        break;
                    case "h":
                        weapon = new Weapon("Flamethrower", 50, 30);
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
                    default:
                         
                        Console.WriteLine("Please enter the letter corresponding to the weapon.");
                        break;

                }
                    
                    

                
                
                
                
                

            } while (run);
            return weapon;
        }

    }

}
