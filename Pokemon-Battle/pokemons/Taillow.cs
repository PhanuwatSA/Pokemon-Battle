using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle.pokemons
{
    public class Taillow : Pokemon
    {

        public Taillow() 
        {
            this.name = "Taillow";
            Random random = new Random();

            this.HP = random.Next(190, 285);
            this._image = Properties.Resources.taillow;
            this.Attack = random.Next(103, 230);
            this.Defense = random.Next(58, 175);
        }

    }
}
