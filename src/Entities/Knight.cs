using System;
using POO_C_.src.Enums;
using POO_C_.src.Interfaces;

namespace POO_C_.src.Entities
{
    public class Knight : Hero, Attacker
    {
        public Knight(string name, int level, HeroType heroType) : base(name, level, heroType){

        }

        public void HeavyAttack(int damage)
        {
            Console.WriteLine(this.Name + " Used a Heavy Attack, with an axe for " + damage + " damage");
        }

        public void LightAttack(int damage)
        {
            Console.WriteLine(this.Name + " Used a Light Attack, with a dagger for " + damage + " damage");
        }
    }
}