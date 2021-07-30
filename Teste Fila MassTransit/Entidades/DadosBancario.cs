using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teste_Fila_MassTransit.Entidades
{
    public class DadosBancario
    {
        public string TipoConta { get; set; }
        public string NomeBanco { get; set; }
        public string NumeroBanco { get; set; }
        public string NumeroAgencia { get; set; }
        public string DigitoAgencia { get; set; }
        public string NumeroConta { get; set; }
        public string DigitoConta { get; set; }
    }
}
