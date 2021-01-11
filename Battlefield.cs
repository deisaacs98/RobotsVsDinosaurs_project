using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        public Fleet fleet = new Fleet();
        public Herd herd = new Herd();

        
        public Battlefield()
        {
        
        }

        public void AttackDinosaur()
        {
            Console.WriteLine(fleet);
            Console.WriteLine("Choose your attacker:");
            string attacker = Console.ReadLine();
            Robot robot1 = fleet.robot1;
            robot1.ChooseWeapon();
        }

        public void AttackRobot()
        {

        }

        public void Battle()
        {
            fleet.AddRobotsToFleet();
            herd.AddDinosaursToHerd();
        }
    }
}
