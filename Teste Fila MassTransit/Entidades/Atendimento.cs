using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_Fila_MassTransit.Entidades
{
    public class Atendimento
    {
        public string Cpf { get; set; }
        public string CategoriaMotivo { get; set; }
        public string Motivo { get; set; }
        public string Descricao { get; set; }
        public string NumeroProcesso { get; set; }
        public string Protocolo { get; set; }
    }
}
