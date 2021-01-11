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

        
        public List<Robot> robots;

        
        public Robot robot1 = new Robot("Asimov");
        public Robot robot2 = new Robot("Bender");
        public Robot robot3 = new Robot("Data");
        
        public void AddRobotsToFleet()
        {
            robots.Add(robot1);
            robots.Add(robot2);
            robots.Add(robot3);
        }
        

        




    }
}
