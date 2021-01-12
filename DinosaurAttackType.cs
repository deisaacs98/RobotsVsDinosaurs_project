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
        public int power = 100;
        public int accuracy;


        public DinosaurAttackType(string type)
        {
            this.type = type;
            
        }
    }
}
