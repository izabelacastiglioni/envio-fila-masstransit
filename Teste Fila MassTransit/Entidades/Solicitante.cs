using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_Fila_MassTransit.Entidades
{
    public class Solicitante
    {
        public string Nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public string Cpf { get; set; }
        public Identidade Identidade { get; set; }
        public Telefone Telefone { get; set; }
        public Celular Celular { get; set; }
        public string Email { get; set; }
        public Endereco Endereco { get; set; }
    }
}
