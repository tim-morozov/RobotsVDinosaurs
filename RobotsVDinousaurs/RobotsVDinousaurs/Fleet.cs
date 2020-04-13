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
       public List<Robot> rFleet = new List<Robot>();
        
       

        // Member Variables
        public int fleetHealth;
         
        // Constructor
        public Fleet()
        {
            this.fleetHealth = bumblebee.health + robocop.health + robotron.health;
            rFleet.Add(robotron);
            rFleet.Add(robocop);
            rFleet.Add(bumblebee);
            
        }
        //Member Methods
        
    }
}
