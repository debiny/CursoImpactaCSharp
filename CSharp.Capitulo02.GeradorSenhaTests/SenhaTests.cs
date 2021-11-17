using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp.Capitulo02.GeradorSenha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Capitulo02.GeradorSenha.Tests
{
    [TestClass()]
    public class SenhaTests
    {
        [TestMethod()]
        public void GerarSenhaSemParametrosDeveRetornarSenhaPadrao()
        {
            Senha senha = new();

            //senha.Tamanho = 6;

            var valorSenha = senha.Gerar();

            Assert.IsTrue(valorSenha.Length == Senha.TamanhoMinimo);
            Console.WriteLine(valorSenha);
        }

        [TestMethod()]
        public void ConstrutorPadraoDeveRetornarSenhaPadrao()
        {
            var senha = new Senha();
            Assert.IsTrue(senha.Valor.Length == Senha.TamanhoMinimo);
            Console.WriteLine(senha.Valor);
        }

    }
}