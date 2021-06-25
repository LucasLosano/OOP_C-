using System;
using POO_C_.src.Enums;
using POO_C_.src.Interfaces;

namespace POO_C_.src.Entities
{
    public class Wizard : Hero , Attacker, Healer
    {
        public Wizard(string name, int level, HeroType heroType) : base(name, level, heroType)
        {
            
        }

        public void Heal(Hero ally, int hp)
        {
            Console.WriteLine(this.Name + " Used a Healing Spell on " + ally.Name + ", healing " + hp + "hp");
        }

        public void HeavyAttack(int damage)
        {
            Console.WriteLine(this.Name + " Used a Heavy Attack, with a blast spell for " + damage + " damage");
        }

        public void LightAttack(int damage)
        {
            Console.WriteLine(this.Name + " Used a Light Attack, with a fire spell for " + damage + " damage");
        }
    }
}