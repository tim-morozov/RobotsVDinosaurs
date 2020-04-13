using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinousaurs
{
    class Herd
    {
         public Dinosaur mastodon = new Dinosaur("Mastodon", 30);
         public Dinosaur raptor = new Dinosaur("Raptor", 35);
         public Dinosaur tRex = new Dinosaur("Trex", 45);
         public   List<Dinosaur> dList = new List<Dinosaur>();
        // Member Variables

        public int herdHealth;
        // Constructor
        public Herd()
        {
            this.herdHealth = mastodon.health + raptor.health + tRex.health;

            dList.Add(mastodon);
            dList.Add(raptor);
            dList.Add(tRex);
        }
        //Member Methods
    }
}
