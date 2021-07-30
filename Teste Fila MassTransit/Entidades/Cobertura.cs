using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_Fila_MassTransit.Entidades
{
    public class Cobertura
    {
        public string Inscricao { get; set; }
        public string Identificador { get; set; }
        public string Descricao { get; set; }
        public decimal CapitalSegurado { get; set; }
        public decimal Premio { get; set; }
        public decimal Valor { get; set; }
        public string Status { get; set; }
        public string MotivoNegativa { get; set; }
        public List<Beneficiario> Beneficiarios { get; set; }
        public decimal Percentual { get; set; }
        public DateTime DataStatus { get; set; }
    }
}
