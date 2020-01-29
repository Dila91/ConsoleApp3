using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Battle
    {
        string userInput = "initial";
        public Battle()
        {
            Console.WriteLine("Constructor was called");
            Console.WriteLine("=======================================================");
           
        }

        public void SimulateFight(character hero, character vilain)
        {
           
            // They fight
            while (userInput != "Q")
            {
                Console.WriteLine("Fighing has started");
                if (hero.Health > 0 && vilain.Health > 0)
                {

                    Console.WriteLine("Hero gets hit by 1 damage");
                         
                    Round.Count++;

                    Console.WriteLine("If you want to stopp press Q" + " OR  Press any key to continu");
                    userInput = Console.ReadLine();
                }
                else
                    userInput = "Q";

                
            }
            if (userInput == "Q")
                hero.Health = 0;
        }
        public void DisplayStartingInfo()
        {
            Console.WriteLine("Welcome to battle arena!");

        }
        
        

    }
}
