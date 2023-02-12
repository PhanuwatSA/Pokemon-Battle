using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle.pokemons
{
    public class Wingull : Pokemon
    {
        public Wingull() 
        {
            this.name = "Wingull";
            Random random = new Random();

            this.HP = random.Next(190, 285);
            this._image = Properties.Resources.wingull;
            this.Attack = random.Next(58, 175);
            this.Defense = random.Next(58, 175);
        }
    }
}
