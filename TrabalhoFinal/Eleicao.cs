using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    public abstract class Eleicao
    {
        public Eleicao() { }

        public int[] Candidatos; //arquivo de candidatos salvo a partir das ids
        public int[] Eleitos; //arquivo de candidatos eleitos, obs: para pesquisa rodas um for
        public int VotosBrancos { get; set; }
        public int VotosNulos { get; set; }
        public int TotaldeVotos { get; set; }
        public List<Partido> Partidos { get; set; }
        private int Id { get; set; }
        DateTime DataInicio { get; set; }
        DateTime DataFim { get; set; }


    }
}
