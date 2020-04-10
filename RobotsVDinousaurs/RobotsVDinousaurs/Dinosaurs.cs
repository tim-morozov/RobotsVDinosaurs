using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinousaurs
{
    class Dinosaurs
    {
        // Member Variables
        public string type;
        public int health;
        public int energy;
        public int attackPower;
        // Constructor
        public Dinosaurs(string type, int attackPower)
        {
            this.type = type;
            this.attackPower = attackPower;
            energy = 100;
            health = 100;

        }
        //Member Methods
        public void DinoAttack()
        {

        }
    }
}
