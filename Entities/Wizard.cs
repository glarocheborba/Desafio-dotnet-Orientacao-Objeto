namespace Desafio_2.Entities
{
    public class Wizard : character
    {
        public Wizard(string Name, int Level, string HeroType, string Weakness, string advantages)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Weakness = Weakness;
            this.advantages = advantages;
        }
        public override string Attack(){
            return this.Name + "Lançou magia";
        }

        public override string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou magia super efetiva com bonus de ataque " + Bonus;
            }
            else
            {
                return this.Name + " Lançou magia fraca com bonus de ataque " + Bonus;
            }
            
        }

        public override string Defense(string NameEnemy)
        {
            if (NameEnemy.ToUpper() == "ARUS"){
                return this.Name + " não defendeu ataque de " + NameEnemy;
            }
            else if (NameEnemy.ToUpper() == "ASVIA"){
                return this.Name + " defendeu o feitiço de " + NameEnemy;
            }
            return "Heroi não compõe o jogo";
        }
    }
}