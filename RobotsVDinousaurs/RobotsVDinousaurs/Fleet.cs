using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinousaurs
{
    class Fleet
    {
        Robot robotron = new Robot("Robotron");
        Robot robocop = new Robot("Robocop");
        Robot bumblebee = new Robot("Bumblebee");

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
