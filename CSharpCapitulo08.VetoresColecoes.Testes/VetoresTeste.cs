using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharpCapitulo08.VetoresColecoes.Testes
{
    [TestClass]
    public class VetoresTeste
    {
        [TestMethod]
        public void Vetores()
        {
            var inteiros = new int[5];
            inteiros[0] = 42;
            inteiros[1] = 18;

            var decimais = new decimal[] {0.4m,-3.8m,7.6m,4 };

            string[] nomes = { "maria", "Joao", "clovis" };

            var chars = new[] { 'a','b','c'};

            foreach (var @decimal in decimais)
            {
                Console.WriteLine(@decimal);
            }
            Console.WriteLine($"Tamanho do vetor {nameof(decimais)}: {decimais.Length}");

        }

        [TestMethod]
        public void RedimensionanamentoTeste()
        {
            
            var decimais = new decimal[] { 0.4m, -3.8m, 7.6m, 4 };

            Array.Resize(ref decimais,5);
            decimais[4] = 2.3m;        

        }
        [TestMethod]
        public void OrdenacaoTeste()
        {
            var decimais = new decimal[] { 0.4m, -3.8m, 7.6m, 4 };

            Array.Sort(decimais);

            Assert.AreEqual(decimais[0], -3.8m);
        }

        public decimal Media(decimal a, decimal b)
        {
            return (a + b) / 2;
        }

        //metodo que recebe um vetor de decimais
        public decimal CalculaMedia(params decimal[] valores)
        {
            var tamanho = valores.Length;
            decimal soma = 0;

            foreach (var valor in valores)
            {
                soma += valor;
            }

            return soma/tamanho;
        }

        [TestMethod]
        public void ParamsTEste()
        {
            var decimais = new decimal[] { 10m, 10m, 10m, 10m };

            Console.WriteLine(CalculaMedia(decimais));

            Console.WriteLine(CalculaMedia(2,-18m,4.4m,9.15m));


        }

        [TestMethod]
        public void TodaStringEUmVetor()
        {
            var nome = "Vitor";

            Assert.AreEqual(nome[0], 'V');


            foreach (var @char in nome)
            {
                Console.WriteLine(@char);
            }
            //StringBuilder;
        }

    }
}
