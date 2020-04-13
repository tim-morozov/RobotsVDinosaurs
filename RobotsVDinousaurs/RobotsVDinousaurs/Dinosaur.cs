using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinousaurs
{
    class Dinosaur
    {
        // Member Variables
        public string type;
        public int health;
        public int energy;
        public int attackPower;
        // Constructor
        public Dinosaur(string type, int attackPower)
        {
            this.type = type;
            this.attackPower = attackPower;
            energy = 100;
            health = 100;

        }
        //Member Methods
        public int DinoAttack(int enemyHealth)
        {
             
            int result = enemyHealth - attackPower;
            return result;
        }
    }
}
