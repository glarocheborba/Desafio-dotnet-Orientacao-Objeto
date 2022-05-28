using System;

namespace Desafio_2.Entities
{
    public class character
    {
        public character(string Name, int Level, string HeroType, string Weakness, string advantages)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Weakness = Weakness;
            this.advantages = advantages;
        }
        public string Name;
        public int Level;
        public string HeroType;
        public string Weakness;
        public string advantages;


        public override string ToString()
        {
            return "Name:" + this.Name + " Level:" + this.Level + " HeroType:" + this.HeroType + " Weakness:" +  this.Weakness + " Strengh:" + this.advantages;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com sua espada ";
        }

        public virtual string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Atacou com sua espada com dano crítico de " + Bonus;
            }
            else
            {
                return this.Name + " Atacou com sua espada com dano base de " + Bonus;
            }
            
        }


        public virtual string Defense(string NameEnemy)
        {
            if (NameEnemy.ToUpper() == "ASVIA"){
                return this.Name + " foi afetado pela magia de " + NameEnemy;
            }
            else if (NameEnemy.ToUpper() == "JENEKA"){
                return this.Name + " defendeu a magia de " + NameEnemy;
            }
            return "Heroi não compõe o jogo";
        }
    }
}