using Fintech.Dominio.Entidades;
using Fintech.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Fintech.Repositories.SistemaArquivos
{
    public class MovimentoRepositorio : IMovimentoRepositorio
    {
        private const string DiretorioBase = "Dados";

        public MovimentoRepositorio(string caminho)
        {
            Caminho = caminho;
        }

        public string Caminho { get; }

        void IMovimentoRepositorio.Atualizar(Movimento movimento)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Movimento movimento)
        {
            string registro = $"{movimento.Guid}|{movimento.Conta.Agencia.Numero}|{movimento.Conta.Numero}|{movimento.Data}|{(int)movimento.Operacao}|{movimento.Valor}";

            if (!Directory.Exists(DiretorioBase))
            {
                Directory.CreateDirectory(DiretorioBase);

            }
            File.AppendAllText(@$"{DiretorioBase}\\Movimento.txt", registro + Environment.NewLine);
        }

        public Movimento Selecionar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Movimento> Selecionar(int numeroAgencia, int numeroConta)
        {
            var movimentos = new List<Movimento>();

            foreach (var linha in File.ReadAllLines("Dados\\Movimento.txt"))
            {
                if (linha == string.Empty) continue;
              
                var propriedades = linha.Split("|");
                var guid = new Guid(propriedades[0]);
                var propiedadeNumeroAgencia = Convert.ToInt32(propriedades[1]);
                var propiedadeNumeroConta = Convert.ToInt32(propriedades[2]);
                var data = Convert.ToDateTime(propriedades[3]);
                var operacao = (Operacao)Convert.ToInt32(propriedades[4]);
                var valor = Convert.ToDecimal(propriedades[5]);

                if (numeroAgencia == propiedadeNumeroAgencia && numeroConta == propiedadeNumeroConta)
                {         
                    var movimento = new Movimento(operacao, valor);
                    movimento.Guid = guid;
                    movimento.Data = data;

                    movimentos.Add(movimento);

                }
            }

            return movimentos;
        }
    }
}