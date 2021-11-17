using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharp.Capitulo02.EstruturaControles.Testes
{
    [TestClass]
    public class RepeticaoTeste
    {
        [TestMethod]
        public void TabuadaTeste()
        {

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }

            }
        }

        [TestMethod]
        public void EstruturaForTeste()
        {
            var i = 1;
            for (Console.WriteLine("Inicioou"); i>=3; Console.WriteLine(i))
			{
                i++;
            }
        }

    
        [TestMethod]
        public void ForApenasComCondicaoTeste()
        {
            var i = 1;

            for (; i <= 3;)
            {
                Console.WriteLine(i++);
            }
        }

        [TestMethod]
        public void ContinueTest()
        {
            for (int i= 1; i <=10; i++)
            {
                if (i<=5)
                {
                    //se cai no continue ele volta para o começo do for
                    continue;
                }
                Console.WriteLine(i);
            }         
        }

        [TestMethod]
        public void BreakTest()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i > 5)
                {
                    //se cai no continue ele volta para o começo do for
                    break;
                }
                Console.WriteLine(i);
            }
        }

    }
}
