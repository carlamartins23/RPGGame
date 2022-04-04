namespace Projeto.RPGGame
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType)
        {
            base.Name = Name;
            base.Level = Level;
            base.HeroType = HeroType;
        }
        public override string Attack(){
            return this.Name + " Atacou com shuriken ";
        }

    }
}