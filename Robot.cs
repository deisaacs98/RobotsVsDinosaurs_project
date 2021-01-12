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
        public int powerLevel;
        public Weapon weapon;
        public Weapon[] cache;


        public Robot(string name)
        {
            this.name = name;
            
        }
        public Weapon ChooseWeapon()
        {
            Console.WriteLine("Choose a weapon:");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "a":
                    weapon = new Weapon("Plasma Pistol",0,0);
                    return weapon;
                case "b":
                    weapon = new Weapon("LASER TASER", 0, 0);
                    return weapon;
                case "c":
                    weapon = new Weapon("Atomic RPG", 0, 0);
                    return weapon;
                case "d":
                    weapon = new Weapon("Phaser", 0, 0);
                    return weapon;
                case "e":
                    weapon = new Weapon("Death Ray", 0, 0);
                    return weapon;
                case "f":
                    weapon = new Weapon("Rock", 0, 0);
                    return weapon;
                case "g":
                    weapon = new Weapon("Flamethrower", 0, 0);
                    return weapon;
                case "h":
                    weapon = new Weapon("Switchblade", 0, 0);
                    return weapon;
                case "i":
                    weapon = new Weapon("Broken Beer Bottle", 0, 0);
                    return weapon;
                case "j":
                    weapon = new Weapon("Spiked Bat", 0, 0);
                    return weapon;
                case "k":
                    weapon = new Weapon("Folding Chair", 0, 0);
                    return weapon;
                case "l":
                    weapon = new Weapon("Pool Cue", 0, 0);
                    return weapon;


            }
            weapon=new Weapon(type, 100, 100);
            i
            return weapon;
        }


}
