using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPOO
{
    internal class Heroe : Personaje
    {
        public Heroe() : base("117", 400, 50)
        {
        }
        
        public override int Atacar()
        {
           
            return Ataque + 15; 
        }
    }
}
