﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinousaurs
{
    class Battlefield
    {
        Herd dinoHerd = new Herd();
        Fleet roboFleet = new Fleet();

        // Member Variables
        
        // Constructor
        public Battlefield()
        {

        }
        //Member Methods
        public void Battle()
        {
            Console.WriteLine("Ready to battle");
            while(dinoHerd.herdHealth > 0 || roboFleet.fleetHealth > 0)
            {
               roboFleet.fleetHealth = dinoHerd.mastodon.DinoAttack(roboFleet.fleetHealth);
                roboFleet.robotron.RoboAttack();
                if (dinoHerd.herdHealth < roboFleet.fleetHealth)
                {
                    Console.WriteLine("The Dinosaurs are in the lead!");

                }
                else
                {
                    Console.WriteLine("The robots are in the lead!");
                }
            }
            
        }
    }
}
