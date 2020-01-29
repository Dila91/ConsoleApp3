using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Battle battle = new Battle();
            character ch = new character();
            ch.Name = "Hercules";
            ch.CreateHero();
            battle.DisplayStartingInfo();

            while (ch.Health > 0)
            {
                //Create an enemy
                character enemy = new character();
                enemy.CreateEnemy();

                //Let the hero fight him/her/it
                battle.SimulateFight(ch, enemy);

                if (ch.Health < 1) 
                {
                    Console.WriteLine("{0} was defeated", ch.Name);

                }
                Console.WriteLine(" {0} fought {1} times", ch.Name, Round.Count);



                //string test = ch.Name;



                Console.ReadKey();


            }
         }
    }
}
