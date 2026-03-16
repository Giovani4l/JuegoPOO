using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPOO
{
    internal class Boss : Personaje
    {
        // Usar las estadísticas esperadas para el Boss
        public Boss() : base("Boss", 400, 50)
        {
        }
        
        public override int Atacar()
        {
            // El boss tiene un ataque especial que inflige daño adicional
            return Ataque +15; // Daño adicional de 15
        }
    }
}
