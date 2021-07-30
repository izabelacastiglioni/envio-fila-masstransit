using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_Fila_MassTransit.Entidades
{
    public class AvisoProcesso
    {
        public Segurado Segurado { get; set; }
        public Processo Processo { get; set; }
        public Atendimento Atendimento { get; set; }
    }
}
