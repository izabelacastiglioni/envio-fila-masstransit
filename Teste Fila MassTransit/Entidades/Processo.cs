using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_Fila_MassTransit.Entidades
{
    public class Processo
    {
        public string Numero { get; set; }
        public int Sequencial { get; set; }
        public decimal ValorProcesso { get; set; }
        public string Origem { get; set; }
        public DateTime DataAviso { get; set; }
        public DateTime DataStatus { get; set; }
        public string Status { get; set; }
        public FatoGerador FatoGerador { get; set; }
        public List<string> Cids { get; set; }
        public List<Medico> Medicos { get; set; }
        public Solicitante Solicitante { get; set; }
        public List<Beneficiario> Beneficiarios { get; set; }
        public List<Cobertura> Coberturas { get; set; }
        public List<Documento> Documentos { get; set; }
        public string TipoRegulacao { get; set; }
    }
}
