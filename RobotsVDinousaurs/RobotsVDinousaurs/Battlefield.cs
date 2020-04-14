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
        
            //Round method executes until one opponent has no health left over
        public void Round(Dinosaur dinoOpponent, Robot roboOpponnent)
        {
            dinoOpponent.health = roboOpponnent.RoboAttack(dinoOpponent.health);
            roboOpponnent.health = dinoOpponent.DinoAttack(roboOpponnent.health);
        }
        //Compares which opponent has fallen
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
        //Decides which team won based on how many opponents it lost
        //If one side lost more than the size of the team, then the other team wins
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
            //Variables allowing each team to switch fighters once one is out of health
            //Moving along each list index
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
        //The method that everything will run inside
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
