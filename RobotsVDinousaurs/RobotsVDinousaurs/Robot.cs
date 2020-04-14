using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RobotsVDinousaurs
{
    class Robot
    {
        // Member Variables
        public string name;
        public int health;
        public int powerLevel;
        public List<Weapon> weaponsList = new List<Weapon>();
        public Weapon blaster = new Weapon("Blaster", 30);
        public Weapon electroBlade = new Weapon("Electro-Blade", 50);
        public Weapon spear = new Weapon("Spear", 35);
        
        Weapon roboWeapon;
        Random random = new Random();
        
        

        
        // Constructor
        public Robot(string name)
        {
            this.name = name;
            health = 100;
            powerLevel = 100;
            weaponsList.Add(blaster);
            weaponsList.Add(electroBlade);
            weaponsList.Add(spear);

            this.roboWeapon = AddWeapon();

        }
        //Member Methods
        public int RandomNumber(int min, int max, Random random)
        {
            int index = random.Next(min, max);
            return index;
        }
        //Randomly adds a weapon to each Robot object
        public Weapon AddWeapon()
        {
            int i = RandomNumber(0, weaponsList.Count, random);

            roboWeapon = weaponsList[i];
            return roboWeapon;
        }

        public int RoboAttack(int enemyHealth)
        {
            enemyHealth -= roboWeapon.weaponPower;
            return enemyHealth;
        }
    }
}
