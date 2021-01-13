using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Fleet
    {
        //Robots are stored here.

        
        public Robot[] fleet;

        public Robot robot1 = new Robot("Asimov");
        public Robot robot2 = new Robot("Bender");
        public Robot robot3 = new Robot("Data");





        public Fleet()
        {
            this.fleet = new Robot[3];
            
            
        }
        public void AddRobotsToFleet()
        {
            fleet[0]=robot1;
            fleet[1]=robot2;
            fleet[2]=robot3;
        }

        public void AddWeaponsToCache()
        {
            Weapon weapon;
            Console.WriteLine("Each robot can carry four weapons. Choose wisely.");

            for (int i = 0; i < 4; i++)
            {
                
                Console.WriteLine(robot1.name + ":");
                weapon = robot1.ChooseWeapon();
                robot1.cache[i] = weapon;
                Console.Clear();
                Console.WriteLine("You have added " + weapon.type + " to your cache.");
                
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(robot2.name + ":");
                weapon = robot2.ChooseWeapon();
                robot2.cache[i] = weapon;
                Console.Clear();
                Console.WriteLine("You have added " + weapon.type + " to your cache.");

            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(robot3.name + ":");
                weapon = robot3.ChooseWeapon();
                robot3.cache[i] = weapon;
                Console.Clear();
                Console.WriteLine("You have added " + weapon.type + " to your cache.");

            }
            






        }





        
    }
}
