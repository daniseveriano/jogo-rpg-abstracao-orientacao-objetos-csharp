using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo_rpg_abstracao_orientacao_objetos_csharp.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroTpe) : base(Name, Level, HeroTpe)
        {}
    }
}