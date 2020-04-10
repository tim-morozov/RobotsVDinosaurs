using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinousaurs
{
    class Robots
    {
        // Member Variables
        public string name;
        public int health;
        public int powerLevel;
        // Constructor
        public Robots(string name)
        {
            this.name = name;
            health = 100;
            powerLevel = 100; 
        }
        //Member Methods
        public void RoboAttack()
        {

        }
    }
}
