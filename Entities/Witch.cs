namespace Desafio_2.Entities
{
    public class Witch : character
    {
        public Witch(string Name, int Level, string HeroType, string Weakness, string advantages)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Weakness = Weakness;
            this.advantages = advantages;
        }
        public override string Attack(){
            return this.Name + "Lançou um feitiço";
        }

        public override string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Utilizou feitiço de veneno em seu inimigo com dano de: " + Bonus;
            }
            else
            {
                return this.Name + " Utilizou feitiço de simples em seu inimigo com dano de: " + Bonus;
            }
        }

        public override string Defense(string NameEnemy)
        {
            if (NameEnemy.ToUpper() == "ARUS"){
                return this.Name + " defendeu ataque de " + NameEnemy;
            }
            else if (NameEnemy.ToUpper() == "JENEKA"){
                return this.Name + " defendeu a magia de " + NameEnemy;
            }
            return "Heroi não compõe o jogo";
        }
    }
}