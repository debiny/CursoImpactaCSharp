using Fintech.Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Fintech.Repositorios.SqlServer.Tests
{
    [TestClass()]
    public class MovimentoRepositorioTests
    {
        private readonly MovimentoRepositorio repositorio = new("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Fintech;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        [TestMethod()]
        public void InserirTest()
        {
            var agencia = new Agencia();
            agencia.Numero = 2;

            var conta = new ContaCorrente(agencia, 1, "7");

            var movimento = new Movimento(Operacao.Deposito, 10);
            movimento.Conta = conta;


            repositorio.Inserir(movimento);
        }

        [TestMethod()]
        public void SelecionarTest()
        {
            {
                var movimentos = repositorio.SelecionarAsync(2, 1).Result;
                foreach (var movimento in movimentos)
                {
                    Console.WriteLine($"{movimento.Data}: {movimento.Operacao} {movimento.Valor:c}");
                }
            }
        }
    }
}