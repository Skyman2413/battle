using System;

namespace Battle
{
    public class Hero
    {
        public string name;
        public bool isAgil;
        public int strenght;
        public int agility;
        public int armor;
        public int baseHealth;
        public int baseDamage;
        public int regen;
        public double currentHealth;

        public Hero(string name, bool isAgil, int strenght, int agility, int armor,  int baseDamage, int regen)
        {
            this.name = name;
            this.isAgil = isAgil;
            this.strenght = strenght;
            this.agility = agility;
            this.armor = armor;
            this.baseDamage = baseDamage;
            this.regen = regen;

            baseHealth = strenght * 30;
            currentHealth = baseDamage;
        }
        public Hero(string name, bool isAgil, int strenght, int agility, int armor,  int baseDamage, int regen, double currentHealth)
        {
            this.name = name;
            this.isAgil = isAgil;
            this.strenght = strenght;
            this.agility = agility;
            this.armor = armor;
            this.baseDamage = baseDamage;
            this.regen = regen;

            baseHealth = strenght * 30;
            this.currentHealth = currentHealth;
        }


        public void Run(bool isSecondRun)
        {
            if(isSecondRun)
            {
                if (new Random().Next(2) == 0)
                {
                    currentHealth += 5 * regen;
                    if (currentHealth > baseHealth) currentHealth = baseDamage;
                }
            }
            else
            {
                currentHealth -= baseHealth * 0.01;
            }
            
            
        }

        public void Attack(Hero hero)
        {
            hero.currentHealth -= armor * agility / 5.0 + baseDamage * strenght / 5.0;
            currentHealth -= baseDamage * strenght / 20.0;
        }

        public override string ToString()
        {
            return name + "," + isAgil + "," + 
                   strenght + "," + agility + "," + 
                   armor + "," + baseDamage + "," + 
                   regen +"," + currentHealth;
        }
    }
}