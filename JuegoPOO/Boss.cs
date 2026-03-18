using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoPOO
{
    internal class Boss : Personaje
    {
        
        public Boss() : base("Boss", 400, 50)
        {
        }
        
        public override int Atacar()
        {
            
            return Ataque +15; 
        }
    }
}
