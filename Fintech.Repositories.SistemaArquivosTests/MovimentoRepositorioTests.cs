using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fintech.Repositories.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fintech.Dominio.Entidades;

namespace Fintech.Repositories.SistemaArquivos.Tests
{
    [TestClass()]
    public class MovimentoRepositorioTests
    {
       
        public Guid Guid { get; set; } = Guid.NewGuid();
        public DateTime Data { get; set; } = DateTime.Now;
        public Operacao Operacao { get; set; }
        public decimal Valor { get; set; }
        public Conta Conta { get; set; }


        [TestMethod()]
        public void InserirTest()
        {
            var agencia = new Agencia();
            agencia.Numero = 2;

            var conta = new ContaCorrente(agencia, 1, "7");

            var movimento = new Movimento(Operacao.Deposito, 10);
            movimento.Conta = conta;

            var repositorio = new MovimentoRepositorio();

            repositorio.Inserir(movimento);
        }
    }
}