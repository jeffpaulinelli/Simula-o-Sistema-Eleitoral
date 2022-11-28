using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna
{
    public abstract class Eleicao
    {
        public Eleicao() { }

        public int[] Candidatos; //arquivo de candidatos salvo a partir das ids
        public int[] Eleitos; //arquivo de candidatos eleitos, obs: para pesquisa rodas um for

        public List<Partido> Partidos { get; set; }

        private int Id { get; set; }
        DateTime DataInicio { get; set; }
        DateTime DataFim { get; set; }
        abstract public int[] ganhadores();

    }
}
