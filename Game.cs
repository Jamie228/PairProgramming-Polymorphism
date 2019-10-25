using System;
using System.Threading;

namespace PairProgramming_Polymorphism
{
    public class Game
    {
         Player player1 = new Player(0, 0, "Bob", 100, 45, 20, "!");
         Monster monster1 = new Monster(10, 10, "Dr Fear", 100, 50, 30, "*");
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("-------------");
            Console.WriteLine("1 | Game");
            Console.WriteLine("2 | Settings");
            Console.WriteLine("3 | Exit");
            Console.WriteLine("-------------");
            switch(Console.ReadKey(true).KeyChar)
            {
                case '1': Run();
                    break;
                case '2': SettingsMenu();
                    break;
                case '3': Environment.Exit(0);
                    break;
            }
        }

        public void SettingsMenu()
        {
            Console.Clear();
            /* Replace Between These Comments */
            Console.WriteLine("Not implemented yet..");
            Console.ReadKey(true);
            /* Replace Between These Comments */
            Menu();
        }

        public void Run()
        {
           

            while(true)
            {
                Update();
                Draw();
                Thread.Sleep(100);
            }
        }

        public void Draw()
        {
            Console.Clear();
            player1.Draw();
            monster1.Draw();
        }

        public void Update()
        {

        }


    }
}