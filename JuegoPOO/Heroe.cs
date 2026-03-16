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
            // El héroe tiene un ataque especial que inflige daño adicional
            return Ataque + 15; // Daño adicional de 15
        }
    }
}
