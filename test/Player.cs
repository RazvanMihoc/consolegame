
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Enemy;

namespace PlayerClass
{
    public class Player
    {
        public Player()
        {
            currentHealth = maxHealth;
        }
        int attack;
        double maxHealth = 100.0;
        double currentHealth;
        public int power = 10;
        double critChance = 2;
        double damageReduction = 10;
        double xpMultiplier = 1;
        public double CurrentHealth
        { 
            get
            {
                return currentHealth;
            }
        }
        public void damageTaken(double enemyDamage)
        {
            currentHealth -= enemyDamage * (100.0 - damageReduction) / 100.0;
        }

        public double playerDamage()
        {
            int randomNumber = new Random().Next(1, 10);

            if (randomNumber <= critChance)
            {
                attack = power * 2;
                return attack;
            }
            else
            {
                return power;
            }
        }

        public void Healing(double healingAmount)
        {
            currentHealth += healingAmount;
            if(currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }
        }



    }
}