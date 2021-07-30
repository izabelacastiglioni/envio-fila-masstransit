using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_Fila_MassTransit.Entidades
{
    public class FatoGerador
    {
        public DateTime Data { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public List<Detalhe> Detalhes { get; set; }
    }
}
