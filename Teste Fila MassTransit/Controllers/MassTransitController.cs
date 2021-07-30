using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.ServiceBus;
using Teste_Fila_MassTransit.Entidades;

namespace Teste_Fila_MassTransit.Controllers
{
    [Route("api/teste-masstransit")]
    [ApiController]
    public class MassTransitController : Controller
    {
        private readonly IBus _bus;

        public MassTransitController(IBus bus)
        {
            _bus = bus;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var menssagem = new Menssagem().MessagemBemLeve();
            var sendEndpoint = await _bus.GetSendEndpoint(new Uri($"topic:processo.evento.recebido"));
            await sendEndpoint.Send<AvisoProcesso>(menssagem);
                     
            return Ok();
        }

        
    }
}