using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle.pokemons
{
    public class Lotad : Pokemon
    {
        public Lotad() 
        {
            this.name = "Lotad";
            Random random = new Random();
            
            this.HP = random.Next(190, 285);
            this._image = Properties.Resources.lotad;
            this.Attack = random.Next(58, 175);
            this.Defense = random.Next(58, 175);
        }
    }
}
