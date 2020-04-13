using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinousaurs
{
    class Robot
    {
        // Member Variables
        public string name;
        public int health;
        public int powerLevel;
        public Weapon blaster = new Weapon("Blaster", 30);
        public Weapon electroBlade = new Weapon("Electro-Blade", 50);
        public Weapon spear = new Weapon("Spear", 35);
        public List<Weapon> weaponsList = new List<Weapon>();
        Weapon roboWeapon;
        
        
        

        
        // Constructor
        public Robot(string name)
        {
            this.name = name;
            health = 100;
            powerLevel = 100;
            weaponsList.Add(blaster);
            weaponsList.Add(electroBlade);
            weaponsList.Add(spear);
             
            roboWeapon = AddWeapon();

        }
        //Member Methods
        public Weapon AddWeapon()
        {
            for (int i = 0; i <= 2; i++)
            {
                roboWeapon = weaponsList[i];                            
            }
            return roboWeapon;
        }

        public int RoboAttack(int enemyHealth)
        {
            enemyHealth -= roboWeapon.weaponPower;
            return enemyHealth;
        }
    }
}
