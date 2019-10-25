using System;

namespace PairProgramming_Polymorphism
{
    public class Character 
    {
        protected int currentX;
        protected int currentY;
        protected string name;
        protected int health;
        protected int armour;
        protected int damage;
        protected string sprite;

        public void MoveUp()
        {
            currentY += 1;
        }

        public void MoveDown()
        {
            currentY -= 1;
        }

        public void MoveLeft()
        {
            currentX -= 1;
        }

        public void MoveRight()
        {
            currentX += 1;
        }

        public void Update()
        {

        }

        public void Attack()
        {

        }

        public void Draw()
        {
            Console.WriteLine("Sprite: " + sprite);
            Console.WriteLine("X: " + currentX);
            Console.WriteLine("Y: " + currentY);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Armour: " + armour);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Damage: " + damage);
        }
    }
}