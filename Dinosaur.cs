using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        public string type;
        public int health = 100;
        public int energy;
        
        public DinosaurAttackType[] attacks = new DinosaurAttackType[4];


        public Dinosaur(string type, int energy)
        {
            this.type = type;
            this.energy = energy;
            
        }

        

    }
}
