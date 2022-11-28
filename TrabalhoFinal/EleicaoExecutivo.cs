using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    public class EleicaoExecutivo : Eleicao
    {
        public int[] candidatos; //arquivo de candidatos salvo a partir das ids
        public int[] eleitos; //arquivo de candidatos eleitos, obs: para pesquisa rodas um for

        private int id { get; set; }
        DateTime dataInicio { get; set; }
        DateTime dataFim { get; set; }
        override public int[] ganhadores(){
            return eleitos;
        }
    }
}
