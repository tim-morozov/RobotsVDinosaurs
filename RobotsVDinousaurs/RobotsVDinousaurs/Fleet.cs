using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinousaurs
{
    class Fleet
    {
       public Robot robotron = new Robot("Robotron");
       public Robot robocop = new Robot("Robocop");
       public Robot bumblebee = new Robot("Bumblebee");
        
        

        // Member Variables
        public int fleetHealth;
         
        // Constructor
        public Fleet()
        {
            this.fleetHealth = bumblebee.health + robocop.health + robotron.health;

        }
        //Member Methods
    }
}
