using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetPoo.src.Entities
{
    public class Wizard : Hero
    {

        public Wizard(string Name, int Level,int HP, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
        }

        public override string Attack()
        {
            return this.Name + " Lançou magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus < 6)
            {
                return this.Name + "Lançou magia fraca + bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou magia super efetiva + bonus de " + Bonus;
            }
        }

    }
}
