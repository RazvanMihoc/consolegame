using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuClass
{
    public class Menu
    {
        public void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("****************");
            Console.WriteLine("* Select one:  *");
            Console.WriteLine("* 1.Forward    *");
            Console.WriteLine("* 2.Turn left  *");
            Console.WriteLine("* 3.Turn right *");
            Console.WriteLine("* 4.Show menu  *");
            Console.WriteLine("* 9.Exit       *");
            Console.WriteLine("****************");
        }

        public void GameOver()
        {
            Console.WriteLine("******************* \n" +
                              "*    GAME OVER    * \n" +
                              "*    YOU DIED!    * \n" +
                              "*Along the journey* \n" +
                              "*  you collected  * \n" +
                             $"* -goldenCoins-  * \n" +
                              "******************* \n");
        }
    }
}
