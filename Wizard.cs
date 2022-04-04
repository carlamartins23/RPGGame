namespace Projeto.RPGGame
{
    public class Wizard : Hero
    {
         public Wizard(string Name, int Level, string HeroType)
         {
              base.Name = Name;
              base.Level = Level;
              base.HeroType = HeroType;
         }
         
         public override string Attack(){
              return this.Name + " Lançou magia";
         }
         public string Attack(int Bonus){
              if (Bonus > 6){
                return this.Name + " Lançou magia super efetiva " + Bonus;   
          }else{
                return this.Name + " Lançou magia força fraca com Bonus de " + Bonus;
          }
        }
    } 
}