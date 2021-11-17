
using System;

namespace CSharp.Capitulo02.GeradorSenha
{
    public class Senha
    {

        public Senha()
        {
            Valor = Gerar();
        }
        //variavel constante porque nao muda
        public const int TamanhoMinimo = 4;
        public const int TamanhoMaximo = 10;

        //toda propertie é inicializada com o valor int= 0 / string =null / bolleano = false/ data =01/01/0001
        public int Tamanho { get; set; } = TamanhoMinimo;
        public string Valor { get; set; }

        public string Gerar()
        {

            var senha = string.Empty;
            var randomico = new Random();

            for (int i = 0; i < Tamanho; i++)
            {
                var numero = randomico.Next(10);
                senha += numero;
            }

            return senha;
        }
    }
}
