using System;
using POO_C_.src.Enums;

namespace POO_C_.src.Entities
{
    public abstract class Hero
    {
        public Hero(string name, int level, HeroType heroType){
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
        public string Name;
        public int Level;
        public HeroType HeroType;

        public override string ToString()
        {
            return "Name: " + this.Name + Environment.NewLine +
                    "Level: " + this.Level + Environment.NewLine +
                    "HeroType: " + this.HeroType + Environment.NewLine;
        }
    }
}