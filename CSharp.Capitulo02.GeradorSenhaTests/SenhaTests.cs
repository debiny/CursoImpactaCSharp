using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharp.Capitulo02.GeradorSenha.Tests
{
    [TestClass()]
    public class SenhaTests
    {
        //[TestMethod()]
        //public void GerarSenhaSemParametrosDeveRetornarSenhaPadrao()
        //{
        //    Senha senha = new();

        //    //senha.Tamanho = 6;

        //    var valorSenha = senha.Gerar();

        //    Assert.IsTrue(valorSenha.Length == Senha.TamanhoMinimo);
        //    Console.WriteLine(valorSenha);
        //}

        [TestMethod()]
        public void ConstrutorPadraoDeveRetornarSenhaPadrao()
        {
            var senha = new Senha();
            Assert.IsTrue(senha.Valor.Length == Senha.TamanhoMinimo);
            Console.WriteLine(senha.Valor);
        }

        [TestMethod()]
        [DataRow(6)]
        [DataRow(8)]
        [DataRow(10)]
        public void ConstrutorComParametroDeveRetornarSenha(int tamanho)
        {
            var senha = new Senha(tamanho);

            Assert.IsTrue(senha.Valor.Length == senha.Tamanho);
            Console.WriteLine(senha.Valor);
        }

    }
}