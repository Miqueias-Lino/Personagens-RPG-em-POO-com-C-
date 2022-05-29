using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetPoo.src.Entities
{
    public abstract class Hero {

        public string Name;
        public int Level;
        public string HeroType;
        public int HP;

        public Hero(string Name, int Level, int HP, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;

        }

        public Hero()
        {

        }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com uma espada";
        }
    }
}
