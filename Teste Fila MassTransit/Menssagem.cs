using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_Fila_MassTransit.Entidades;

namespace Teste_Fila_MassTransit
{
    public class Menssagem
    {

        public string  Mensagem { get; set; }

        public AvisoProcesso MessagemBemLeve()
        {

            var segurado = new Segurado()
            {
                Nome = "PRISCILA FRANCA DE GODOY",
                Cpf= "03561144900"
            };

            var detalhe = new Detalhe()
            {
                Codigo = "InicioAfastamento",
                Valor = "2021-05-11 T00:00:00"
            };

            var detalhes = new List<Detalhe>() { detalhe };

            var fatoGerador = new FatoGerador()
            {
                Data = Convert.ToDateTime("2020-04-15"),
                Sigla = "ITD",
                Descricao = "INCAPACIDADE TEMPORÁRIA DOENÇA",
                Detalhes = detalhes,

            };

            var cobertura = new Cobertura()
            {
                Inscricao = "102976277581",
                Identificador = "10297627715811091",
                Descricao = "DIT",
                CapitalSegurado = 1326.87M,
                Premio = 27.73M,
                Valor = 3765.71M
            };

            var coberturas = new List<Cobertura>() { cobertura };

            var processo = new Processo()
            {
                Numero = "2021011228",
                Sequencial = 0,
                ValorProcesso = 3765.71M,
                Origem = "Digital",
                DataAviso = Convert.ToDateTime("2021-05-11"),
                DataStatus = Convert.ToDateTime("2021-05-21"),
                Status = "Avisado" ,
                FatoGerador = fatoGerador,
                Coberturas = coberturas

            };

            var atendimento = new Atendimento()
            {
                Motivo = "HABILITAÇÃO DE BENEFÍCIO - DIÁRIA DE INCAPACIDADE TEMPORÁRIA",
                Descricao = "Solicitação de beneficio"
            };

            var avisoProcesso = new AvisoProcesso()
            {
                Segurado = segurado,
                Processo = processo,
                Atendimento = atendimento
            };

            return avisoProcesso;
        }
    }
}
