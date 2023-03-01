using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerClass;

namespace Enemy
{
    internal class NPC
    {
        public NPC()
        {
            currentHealth = maxHealth;
        }
        public double CurrentHealth
        {
            get
            {
                return currentHealth;
            }
        }
        double maxHealth = 100.0;
        double currentHealth;
        public int power = 2;
        double critChance = 0;
        double damageReduction = 5;
        double xpMultiplier = 1;


        public void DamagedEnemy(double playerDamage)
        {
            currentHealth -= playerDamage;
        }
    }


}
