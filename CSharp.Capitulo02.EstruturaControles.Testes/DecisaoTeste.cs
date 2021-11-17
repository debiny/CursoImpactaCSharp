
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharp.Capitulo02.EstruturaControles.Testes
{
    [TestClass]
    public class DecisaoTeste
    {

        [TestMethod]
        public void AvaliacaoFinalReprovadoTeste()
        {

            var notaFinal = 2.9;
            var resultadoFinal = string.Empty;

            if (notaFinal < 3)
            {
                resultadoFinal = "Reprovado";
            }
            else if (notaFinal is >= 3 and < 5)
            {
                resultadoFinal = "Recuperação";
            }
            else
            {
                resultadoFinal = "Aprovado";
            }

            Assert.AreEqual("Reprovado", resultadoFinal);
        }

        [TestMethod]
        public void AvalicaoFinalRecuperacaoTeste()
        {
            var notaFinal = 2.9;
            string resultadoFinal;

            switch (notaFinal)
            {
                case < 3:
                    resultadoFinal = "Reprovado";
                    break;
                case >= 3 and < 5:
                    resultadoFinal = "Reprovado";
                    break;
                default:
                    resultadoFinal = "Reprovado";
                    break;

            }

            Assert.AreEqual("Recuperação", resultadoFinal);

        }

        [TestMethod]
        public void AvalicaoFinalRecuperacao49Teste()
        {
            var notaFinal = 4.9;

            var resultadoFinal = notaFinal switch
            {
                < 3 => "Recuperação",
                >= 3 and < 5 => "Reprovado",
                _ => "Aprovado"
            };

            Assert.AreEqual("Recuperação", resultadoFinal);

        }

        [TestMethod]
        [DataRow(2.9, "Reprovado")]
        [DataRow(3, "Recuperação")]
        [DataRow(4.9, "Recuperação")]
        [DataRow(5.9, "Aprovado")]

        public void AvalicaoFinalTeste(double notaFinal, string resultadoEsperado)
        {

            var resultadoFinal = notaFinal switch
            {
                < 3 => "Reprovado",
                >= 3 and < 5 => "Recuperação",
                _ => "Aprovado"
            };

            Assert.AreEqual(resultadoEsperado, resultadoFinal);

        }

    }
}
