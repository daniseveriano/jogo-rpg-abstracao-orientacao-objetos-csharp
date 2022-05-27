using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo_rpg_abstracao_orientacao_objetos_csharp.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroTpe) : base(Name, Level, HeroTpe)
        {}

        public override string Attack() //metodo
        {
            return this.Name + " Lançou magia";
        }

        public string Attack(int Bonus)
        { //encapsulamento
            if (Bonus > 6) {
                return this.Name + " Lançou Magia super efetiva com bonus de " + Bonus;
            } else {
                return this.Name + " Lançou Magia com força fraca com bonus de " + Bonus;
            }            
        }
    }
}