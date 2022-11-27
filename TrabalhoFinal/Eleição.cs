using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    public abstract class Eleição
    {
        public Eleição() { }

        public int[] candidatos; //arquivo de candidatos salvo a partir das ids
        public int[] eleitos; //arquivo de candidatos eleitos, obs: para pesquisa rodas um for

        private int id { get; set; }
        DateTime dataInicio { get; set; }
        DateTime dataFim { get; set; }
        abstract public int[] ganhadores();
    }
}
