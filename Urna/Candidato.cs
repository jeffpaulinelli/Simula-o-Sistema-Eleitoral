using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urna
{
    //Classe abstrata para que se crie posteriormente duas classes irão herda-lá
     public class Candidato
    {
        
        private int id { get; set; } //id será também o número do canditado
        private string? nome { get; set; }
        DateTime nasc { get; set; }
        private int qtdVotos { get; set; }



        //protected Candidato() { }
        //public abstract void computaVoto();
        }
}
