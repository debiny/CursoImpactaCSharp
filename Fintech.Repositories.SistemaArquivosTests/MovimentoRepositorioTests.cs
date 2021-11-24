using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Fintech.Dominio.Entidades;

namespace Fintech.Repositories.SistemaArquivos.Tests
{
    [TestClass()]
    public class MovimentoRepositorioTests
    {
        //as properties sao publicas e os fields sao privados
        private readonly MovimentoRepositorio repositorio = new ("Dados\\Movimento.txt");



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
                var movimentos = repositorio.Selecionar(2, 1);

                foreach (var movimento in movimentos)
                {
                    Console.WriteLine($"{movimento.Data}: {movimento.Operacao} {movimento.Valor:c}");
                }
            }
        }   
    }
}