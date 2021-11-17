using System;

namespace CSharp.Capitulo02.GeradorSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeDigitos;
            //executa sempre a primeira vez e vai ser retetido enquanto o while for true
            do
            {
                Console.Write("Informe aquantidade de digitos entre 4 e 10: ");
                quantidadeDigitos = ObterQuantidadeDigitos();

            } while (quantidadeDigitos == 0);

            Senha senha = new();
            Console.Write($"Senha gerada {senha} ");

            //outra forma de instanciar
            Console.Write($"Senha gerada {new Senha()}");
            Console.Write($"Senha gerada {new Senha(quantidadeDigitos).Valor}");


        }

        private static int ObterQuantidadeDigitos()
        {
            int.TryParse(Console.ReadLine(), out int quantidadeDigitos);

            //if (quantidadeDigitos < 4 || quantidadeDigitos > 10 || quantidadeDigitos % 2 != 0)
            if (quantidadeDigitos is < 4 or > 10 || quantidadeDigitos % 2 != 0)
            {
                Console.Write($"O valor {quantidadeDigitos} esta for das regras. ");
                quantidadeDigitos = 0;
            }
            return quantidadeDigitos;
        }
    }
}
