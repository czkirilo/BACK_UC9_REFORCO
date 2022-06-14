using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BACK_UC9_REFORCO
{
    public abstract class Pessoa
    {
        public string nome { get; set; }
        public Endereco endereco { get; set; }   
        public abstract double  PagarImposto(float rendimento);     
    }
}