using System;
using System.Collections.Generic;
using POO_C_.src.Entities;
using POO_C_.src.Enums;
using POO_C_.src.Interfaces;

namespace POO_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 99, HeroType.Knight);
            Wizard wiz = new Wizard("Wiz", 10, HeroType.Wizard);
            List<Attacker> heros = new List<Attacker>();
            heros.Add(arus);
            heros.Add(wiz);

            foreach(var hero in heros){
                hero.HeavyAttack(15);
            }
            wiz.Heal(arus, 20);
        }
    }
}
