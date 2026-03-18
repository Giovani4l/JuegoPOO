using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPOO
{
    internal class Arquero : Personaje
    {
        public Arquero() : base("Arquero", 100, 15)
        {
        }
        public override int Atacar()
        {
            
            return Ataque + 3; 
        }
    }
}
