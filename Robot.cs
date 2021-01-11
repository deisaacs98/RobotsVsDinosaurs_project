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


        public Robot(string name)
        {
            this.name = name;
            
        }
        public Weapon ChooseWeapon()
        {
            Console.WriteLine("Choose a weapon:");
            string type = Console.ReadLine();
            weapon= new Weapon(type);
            return weapon;
        }


}
