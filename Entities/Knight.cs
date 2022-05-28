namespace Desafio_2.Entities
{
    public class Knight : character
    {
        public Knight(string Name, int Level, string HeroType, string Weakness, string advantages)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Weakness = Weakness;
            this.advantages = advantages;
        }

    }
}