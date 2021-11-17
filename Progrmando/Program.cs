using System;

namespace ProgramandoComCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            
            Console.Write("Funcionário: ");
            var nome = Console.ReadLine();

            Console.Write("Salário: ");
            var salario = Convert.ToDecimal(Console.ReadLine());
            //decimal salario = decimal.Parse(Console.ReadLine());


            Console.Write("Gasto com transporte: ");
            var gasto = Convert.ToDecimal(Console.ReadLine());

            var descontoMaximo = salario * 0.06m;

            var descontoVt = gasto > descontoMaximo ? descontoMaximo : gasto;


            var resultado = $"\nO desconto do {nome}\n" +
                $"com salario de: {salario:c}\n" +
                $"é de : {descontoVt:c}";

            Console.Write(resultado);

            Console.Write("\nPressione para novo calculo ou Esc para sair" );

            var comando = Console.ReadKey();

            if (comando.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }

            Console.Clear();

            goto Inicio;
        }
    }
}
