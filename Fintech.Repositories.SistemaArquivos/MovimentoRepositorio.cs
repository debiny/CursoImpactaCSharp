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

        void IMovimentoRepositorio.Atualizar(Movimento movimento)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Movimento movimento)
        {
            string registro = $"{movimento.Guid}|{movimento.Conta.Agencia.Numero}|{movimento.Data}|{(int)movimento.Operacao}|{movimento.Valor}";

            if (!Directory.Exists(DiretorioBase))
            {
                Directory.CreateDirectory(DiretorioBase);

            }
            File.AppendAllText(@$"{DiretorioBase}\\Movimento.txt", registro + Environment.NewLine);
        }

        Movimento IMovimentoRepositorio.Selecionar(int id)
        {
            throw new NotImplementedException();
        }

        List<Movimento> IMovimentoRepositorio.Selecionar(int numeroAgencia, int numeroConta)
        {
            throw new NotImplementedException();
        }
    }
}
