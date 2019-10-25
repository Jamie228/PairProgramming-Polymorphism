namespace PairProgramming_Polymorphism
{
    public class Monster : Character
    {
        string monsterType;
        bool boss;

        public Monster(int currentX, int currentY, string name, int health, int armour, int damage, string sprite)
        {
            this.currentX = currentX;
            this.currentY = currentY;
            this.name = name;
            this.health = health;
            this.armour = armour;
            this.damage = damage;
            this.sprite = sprite;
        }
    }
}