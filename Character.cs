using System;

namespace PairProgramming_Polymorphism
{
    public class Character
    {
        public int currentX;
        public int currentY;
        public string name;
        public int health;
        public int armour;
        public int damage;
        public string sprite;

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