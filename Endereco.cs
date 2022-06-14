using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BACK_UC9_REFORCO
{
    public class Endereco
    {
        public string logradouro { get; set; }
        public int Numero { get; set; }
        public string complemento { get; set; }
        public bool enderecoComercial { get; set; }
    }
}