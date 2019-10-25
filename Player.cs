namespace PairProgramming_Polymorphism
{
    public class Player : Character
    {
        
        int experience;

        public Player(int currentX, int currentY, string name, int health, int armour, int damage, string sprite)
        {        
            this.currentX = currentX;
            this.currentY = currentY;
            this.name = name;
            this.health = health;
            this.armour = armour;
            this.damage = damage;
            this.sprite = sprite;
        }


        
        /*public void ManualMove()
        {
                
            if(keypressed == keychar"")
            {
            MoveUp();
            }

            else if()
            {
            MoveDown();
            }

            else if()
            {
            MoveLeft();
            }

            else if()
            {
            MoveRight();
            }
        } */

        






    }
}