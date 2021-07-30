using GreenPipes;
using MassTransit;
using MassTransit.Azure.ServiceBus.Core;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.ServiceBus.Primitives;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Teste_Fila_MassTransit.Entidades;

namespace Teste_Fila_MassTransit
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
         
            string connectionString = "sb://magbeneficiossbdev.servicebus.windows.net";           

            // create the bus using Azure Service bus
            var azureServiceBus = Bus.Factory.CreateUsingAzureServiceBus(busFactoryConfig =>
            {        

                busFactoryConfig.Host(connectionString,hostConfig =>
                {
                    // This is optional, but you can specify the protocol to use.
                    hostConfig.TransportType = TransportType.AmqpWebSockets;
                    hostConfig.TokenProvider = TokenProvider.CreateSharedAccessSignatureTokenProvider("RootManageSharedAccessKey", "m6bztYSbBTpkO8JWD6JvEaRaF4PP4ltt30YjdljTp+s=");
                });

             

            });

            services.AddMassTransit(config =>
            {
                config.AddBus(provider => azureServiceBus);

            });

            services.AddSingleton<IPublishEndpoint>(azureServiceBus);
            services.AddSingleton<ISendEndpointProvider>(azureServiceBus);
            services.AddSingleton<IBus>(azureServiceBus);
        }

    
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }


    }
}
