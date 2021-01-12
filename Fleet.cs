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

        
        public Robot[] fleet=new Robot[3];

        
        public Robot robot1 = new Robot("Asimov");
        public Robot robot2 = new Robot("Bender");
        public Robot robot3 = new Robot("Data");

        
        public Fleet(Robot[] fleet)
        {
            this.fleet = fleet;
            
            
        }
        public void AddRobotsToFleet()
        {
            fleet[0]=robot1;
            fleet[1]=robot2;
            fleet[2]=robot3;
        }

        public void AddWeaponsToCache()
        {
            for(int i=0;i<3;i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    fleet[i].cache[j] = fleet[i].ChooseWeapon();
                }
            }
        
        }
        





    }
}
