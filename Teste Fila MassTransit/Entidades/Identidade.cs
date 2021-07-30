using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_Fila_MassTransit.Entidades
{
    public class Identidade
    {
        public string Numero { get; set; }
        public string Emissor { get; set; }
        public DateTime Data { get; set; }
    }
}
