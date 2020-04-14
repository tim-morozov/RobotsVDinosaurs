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
        Dinosaur dinoFighter;
        Robot roboFighter;
        int dinoDown = 0;
        int roboDown = 0;

        
        // Member Variables

        // Constructor
        public Battlefield()
        {
            dinoHerd = new Herd();
            roboFleet = new Fleet();
        }
        //Member Methods
        public void Round(Dinosaur dinoOpponent, Robot roboOpponnent)
        {
            dinoOpponent.health = roboOpponnent.RoboAttack(dinoOpponent.health);
            roboOpponnent.health = dinoOpponent.DinoAttack(roboOpponnent.health);
        }
        public void CompareHealth(int dinoHealth, int roboHealth)
        {
            if (dinoHealth > roboHealth)
            {
                roboDown++;
                
            }
            else
            {
                dinoDown ++;

            }
            

        }
        public void DeclareWinner()
        {
            if (dinoDown < roboDown)
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
            dinoFighter = dinoHerd.dList[dinoDown];
            roboFighter = roboFleet.rList[roboDown];
           
            
            while (dinoFighter.health >= 0 && roboFighter.health >= 0)
            {
                Round(dinoFighter, roboFighter);
            }
             CompareHealth(dinoFighter.health, roboFighter.health);
            if (dinoDown < 3 && roboDown < 3)
            {
                dinoFighter = dinoHerd.dList[dinoDown];
                roboFighter = roboFleet.rList[roboDown];
            }
            else
            {
                DeclareWinner(); 
            }

        }

        public void Run()
        {
            Console.WriteLine("Ready to battle!");
            while (roboDown < 3 && dinoDown < 3)
            {
                Battle();
                
            }
           
        }
        
    }
}
