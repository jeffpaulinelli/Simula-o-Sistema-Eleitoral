using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    public class EleicaoLegislativo : Eleicao
    {
        public List<Partido> Partidos { get; set; }
        public List<Candidato> Eleitos { get; set; }
        public int VotosBrancos { get; set; }
        public int VotosNulos { get; set; }
        public int TotaldeVotos { get; set; }
        private int id { get; set; }
        DateTime dataInicio { get; set; }
        DateTime dataFim { get; set; }

    }
}
