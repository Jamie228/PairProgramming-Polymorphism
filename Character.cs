using System;

namespace PairProgramming_Polymorphism
{
    public class Character
    {
        int currentX;
        int currentY;
        string name;
        int health;
        int armour;
        int damage;
        char sprite;

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

        }
    }
}