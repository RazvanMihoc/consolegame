using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Battle;
using MenuClass;
using PlayerClass;

namespace Game
{

    class GameClass
    {
        static void Main(string[] args)
        {

            Menu printMenu = new Menu();
            printMenu.ShowMenu();
            Player player = new Player();
            Combat combat = new Combat();
            string selected;


            do
            {
                if(player.CurrentHealth <= 0)
                {
                    printMenu.GameOver();
                    break;
                }
                Console.ForegroundColor = ConsoleColor.White;
                selected = Console.ReadLine();
                bool usedExistingOption = false;

                Console.ForegroundColor = ConsoleColor.Red;
                switch (selected)
                {
                    case "1":
                        Console.WriteLine("You went forward ! \n");
                        usedExistingOption = true;
                        break;
                    case "2":
                        Console.WriteLine("You turned left ! \n");
                        usedExistingOption = true;
                        break;
                    case "3":
                        Console.WriteLine("You turned right ! \n");
                        usedExistingOption = true;
                        break;
                    case "4":
                        printMenu.ShowMenu();
                        break;
                }
                if (usedExistingOption == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    int eventActioned = new Random().Next(1, 3);
                    switch (eventActioned)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("You encountered an enemy! \n" + "To fight him type  1\n" + "To pass him by type 2");
                            selected = Console.ReadLine();
                            if(selected == "1")
                            {
                                combat.ActualBattle(player);
                            }
                            printMenu.ShowMenu();
                            break;
                        case 2:
                            Console.WriteLine("called event 2 \n");
                            break;
                        case 3:
                            Console.WriteLine("called event 3 \n");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Select an existing option!");
                }
            } while (selected != "9");




        }
    }
}