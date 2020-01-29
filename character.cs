using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class character
    {

        public character()
        {
        }

        private int _maxValues = 12;
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (true)
                {
                    _name = value;
                }
            }
        }
        public int Strength { get; set; }

        public int Health { get; set; }

        //public void printmessage()
        //{
        //    Console.WriteLine("Enter your name");


        //}

        public void CreateHero()
        {
            Random rnd = new Random();
            Strength = rnd.Next(3, 7);
            Health = _maxValues - Strength;
        }

        public void CreateEnemy()
        {
            Random rnd = new Random();
            Strength = rnd.Next(1, 4);
            Health = _maxValues - Strength;
        }

    }

}


