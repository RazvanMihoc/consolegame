using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerClass;
using Enemy;

namespace Battle
{
    internal class Combat
    {
        public void ActualBattle()
        {
            Player player = new Player();
            NPC enemy = new NPC();

            do
            {
                enemy.DamagedEnemy(player.playerDamage());
                Console.WriteLine($"You dealt {player.playerDamage()} to the enemy!");
                player.damageTaken(enemy.power);
                Console.WriteLine($"You got hit by the enemy, being damaged by {enemy.power}");
            } while (player.CurrentHealth > 0 && enemy.CurrentHealth > 0);
            
        }
    }
}
