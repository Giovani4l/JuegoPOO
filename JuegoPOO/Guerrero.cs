using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPOO
{
    internal class Guerrero : Personaje
        {
        public Guerrero() : base("Guerrero",150,20)
        {
        }
        
        public override int Atacar()
        {
            // El guerrero tiene un ataque especial que inflige daño adicional
            return Ataque + 5; // Daño adicional de 5
        }
    }

}
