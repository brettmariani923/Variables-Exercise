using System.Threading.Tasks.Dataflow;
namespace VariablesExercise
{
      public class Program
        
    {
        static void Main(string[] args)
        {
        string pokemonName = "Raichu";
        int pokemonNumber = 26;
        int thunderboltDamage = 95;
        char pokemonFirstLetter = 'R';
        bool raichuIsTheBestPokemon = true;
        double pokemonSuperEffectiveDamage = (thunderboltDamage * 2);
        decimal pokemonSameTypeAttackBonus = ((decimal)thunderboltDamage / 2) + thunderboltDamage;
     
     if (raichuIsTheBestPokemon == true)
      { 
         Console.WriteLine($"\n{pokemonName} is, to put it quite simply, the coolest pokemon in the world.\n\nBeing pokemon number {pokemonNumber} of the original 151 and one of only 6 pokemon in the first generation \nthat begins with an {pokemonFirstLetter}, {pokemonName} has a variety of cool and powerful attack type moves\nsuch as thunderbolt, which does a fearsome {thunderboltDamage} damage to types not resistant to electric type attacks!\n\nBut because raichu is also an electric type pokemon, he gains a same type attack bonus against all \neneimes, because like {pokemonName} thunderbolt also has electric typing!\n\nThis causes {pokemonSameTypeAttackBonus} of damage against a pokeomon instead of the original {thunderboltDamage} that thunderbolt typically does!\n\nHow cool is that!\n\nDont even get me started on what happens if {pokemonName} uses thunderbolt against a pokemon who is weak to electricity!\n\nA type weak to electric type attacks will suffer a staggering {pokemonSuperEffectiveDamage} points of damage from thunderbolt! \n\nThats GAME OVER !! ");
      }
      else
       {
         Console.WriteLine("I guess we will never know who the greatest pokemon is..");  
        }
      }
    }
}
