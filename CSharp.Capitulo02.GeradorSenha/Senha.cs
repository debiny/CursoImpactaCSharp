
using System;

namespace CSharp.Capitulo02.GeradorSenha
{
    //dentro classe o public fora da classe ele é visivel, se for privite ele nao e visto para outra classe

    public class Senha
    {

        //public Senha()
        //{
        //    Valor = Gerar();
        //}

        //polimorfismo, a classe pode conter fucionalidades que fazem coisas diferentes com o mesmo nome
        public Senha(int tamanho = 4)
        {
            Tamanho = tamanho;
            Valor = Gerar();

        }
        //variavel constante porque nao muda
        public const int TamanhoMinimo = 4;
        public const int TamanhoMaximo = 10;

        //toda propertie é inicializada com o valor int= 0 / string =null / bolleano = false/ data =01/01/0001
        public int Tamanho { get; set; } //= TamanhoMinimo;
        public string Valor { get; }

        //dentro do metodo - public fora da classe ele é visivel, - privite mebro da classe que é visivel apenas dentro da classe
        private string Gerar()
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
