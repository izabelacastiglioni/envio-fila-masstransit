using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_Fila_MassTransit.Entidades
{
    public class Beneficiario
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public Identidade Identidade { get; set; }
        public string EstadoCivil { get; set; }
        public int NumeroFilhos { get; set; }
        public string FaixaRenda { get; set; }
        public bool Pep { get; set; }
        public bool ResidenteBrasil { get; set; }
        public bool ObrigacoesFiscais { get; set; }
        public Profissao Profissao { get; set; }
        public Telefone Telefone { get; set; }
        public Celular Celular { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
        public DadosBancario DadosBancarios { get; set; }
        public decimal Percentual { get; set; }
        public string GrauParentesco { get; set; }
        public string Sexo { get; set; }
        public decimal Valor { get; set; }
    }
}
