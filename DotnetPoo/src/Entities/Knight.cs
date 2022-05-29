using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetPoo.src.Entities
{
    internal class Knight : Hero
    {
        public Knight(string Name, int Level, int HP, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;

        }
        public string Attack(int Bonus)
        {
            if (Bonus < 6)
            {
                return this.Name + " atacou com a espada + " + Bonus;
            }
            else
            {
                return this.Name + " atacou com a espada + flexas + " + Bonus;
            }
        }
    }
}
