using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_Fila_MassTransit.Entidades;

namespace Teste_Fila_MassTransit
{
    public class ConsumidorTeste : IConsumer<AvisoProcesso>
    {
        public Task Consume(ConsumeContext<AvisoProcesso> context)
        {
            Console.Write("TXT: " + context.Message);
            Console.Write("  PROCESSED: " + DateTime.Now);
            Console.WriteLine(" (" + System.Threading.Thread.CurrentThread.ManagedThreadId + ")");
            return Task.FromResult(0);
        }
    }
}
