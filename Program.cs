using System;

namespace PairProgramming_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Elliot!");
            Player player1 = new Player(0, 0, "Bob", 100, 45, 20, "!");
            player1.Draw();
        }
    }
}
