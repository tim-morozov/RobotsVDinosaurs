using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinousaurs
{
    class Battlefield
    {
        Herd dinoHerd ;
        Fleet roboFleet;
        
        // Member Variables

        // Constructor
        public Battlefield()
        {
            dinoHerd = new Herd();
            roboFleet = new Fleet();
        }
        //Member Methods
        public void Round()
        {
            for (int i = 0; i < roboFleet.rList.Count || i < dinoHerd.dList.Count; i++)
            {
                dinoHerd.dList[i].health -= roboFleet.rList[i].RoboAttack(dinoHerd.dList[i].health);
                roboFleet.rList[i].health -= dinoHerd.dList[i].DinoAttack(roboFleet.rList[i].health);
                if (roboFleet.rList[i].health <= 0)
                {
                    roboFleet.rList.RemoveAt(i);
                }
                else if (dinoHerd.dList[i].health <= 0)
                {
                    dinoHerd.dList.RemoveAt(i);
                }
            }

        }
        public void CompareHealth()
        {
            if (dinoHerd.herdHealth > roboFleet.fleetHealth)
            {
                Console.WriteLine("The Dinosaurs are in the lead!");

            }
            else
            {
                Console.WriteLine("The robots are in the lead!");
            }

        }
        public void DeclareWinner()
        {
            if (dinoHerd.herdHealth > 0)
            {
                Console.WriteLine("The Dinosaurs have won!");
            }
            else
            {
                Console.WriteLine("The Robots have won!");
            }

        }
        
        public void Battle()
        {
            
            Console.WriteLine("Ready to battle!");
            Console.ReadLine();
            
           
        }
    }
}
