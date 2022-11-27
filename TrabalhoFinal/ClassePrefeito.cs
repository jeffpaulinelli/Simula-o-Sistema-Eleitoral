using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinal
{
    class ClassePrefeito : Candidato
    {
        //id com 02 números?
        int viceId { get; set; }
        string nomeVice { get; set; }
        public override void computaVoto()
        {
             int qtdeVotos= +1;
        }
    }
}
