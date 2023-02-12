using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle.pokemons
{
    internal class Wurmple : Pokemon
    {
        public Wurmple()
        {
            this.name = "Wurmple";
            Random random = new Random();
            
            this.HP = random.Next(200, 295);
            this._image = Properties.Resources.wurmple;
            this.Attack = random.Next(85, 208);
            this.Defense = random.Next(67, 186);
        }
    }
}
