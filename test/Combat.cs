using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerClass;
using Enemy;
using MenuClass;
using Game;
namespace Battle
{
    internal class Combat
    {
        public void ActualBattle(Player player)
        {
            GameClass game = new GameClass();
            NPC enemy = new NPC();
            string selected;
            Console.WriteLine("Type 'f' to begin fight!");
            Menu showMenu = new Menu(); 
                do
                {
                selected = Console.ReadLine();
                if (selected == "f")
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    enemy.DamagedEnemy(player.playerDamage());

                    Console.WriteLine($"You dealt {player.playerDamage()} to the enemy! \n" + $"Your Health: {player.CurrentHealth}\n" + $"Enemy's Health: {enemy.CurrentHealth}\n");
                
                    Console.ForegroundColor = ConsoleColor.Red;

                    player.damageTaken(enemy.power);

                    Console.WriteLine($"You got hit by the enemy, being damaged by {enemy.power} \n" + $"Your Health: {player.CurrentHealth}\n" + $"Enemy's Health: {enemy.CurrentHealth}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Use 'f'!");
                }
                if (enemy.CurrentHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("The enemy has been defeated!");
                }
            } while (player.CurrentHealth > 0 && enemy.CurrentHealth > 0);

            
            
        }
    }
}