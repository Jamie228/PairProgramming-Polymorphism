using System;

namespace PairProgramming_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Player player1 = new Player(0, 0, "Bob", 100, 45, 20, "!");
            player1.Draw();
            Monster monster1 = new Monster(10, 10, "Dr Fear", 100, 50, 30, "*");
            monster1.Draw();

        }
           
    }
}
