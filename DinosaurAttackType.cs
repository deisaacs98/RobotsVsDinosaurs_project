using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class DinosaurAttackType
    {
        public string type;
        public int power;
        public int accuracy;


        public DinosaurAttackType(string type, int power, int accuracy)
        {
            this.type = type;
            this.power = power;
            this.accuracy = accuracy;
            
        }
    }
}
