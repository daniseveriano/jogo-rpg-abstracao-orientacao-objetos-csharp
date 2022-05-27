using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo_rpg_abstracao_orientacao_objetos_csharp.src.Entities
{
    public abstract class Hero //classe abstrata, que serve pra gerar outras classes. Não pode ser invocada diretamente
    {
        public Hero(string Name, int Level, string HeroTpe) //metodo construtor
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroTpe = HeroTpe;
        }
        public string Name;
        public int Level;
        public string HeroTpe;

        public override string ToString() //metodo com override (sobrescrita de metodo)
        {
            return this.Name + " " + this.Level + " " + this.HeroTpe;
        }

        public virtual string Attack() //metodo
        {
            return this.Name + " Atacou com a sua espada";
        }
    }
}