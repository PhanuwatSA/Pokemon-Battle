using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle.pokemons
{
    internal class Torchic : Pokemon
    {
        public Torchic() 
        {
            this.name = "Torchic";
            Random random = new Random();
            //random number between >= 200 and < 295
            this.HP = random.Next(200, 295);
            this._image = Properties.Resources.torchic;
            this.Attack = random.Next(112, 241);
            this.Defense = random.Next(76, 197);
        }
    }
}
