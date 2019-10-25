using System;

namespace PairProgramming_Polymorphism
{
    public static class Game
    {
        public static void Menu()
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

        public static void SettingsMenu()
        {
            Console.Clear();
            /* Replace Between These Comments */
            Console.WriteLine("Not implemented yet..");
            Console.ReadKey(true);
            /* Replace Between These Comments */
            Menu();
        }

        public static void Run()
        {
            while(true)
            {
                
            }
        }
    }
}