using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_Fila_MassTransit.Entidades
{
    public class Medico
    {
        public string Crm { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
        public string Cpf { get; set; }
        public string Especialidade { get; set; }
    }
}
