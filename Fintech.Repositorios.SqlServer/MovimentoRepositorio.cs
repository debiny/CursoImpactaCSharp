
using Dapper;
using Fintech.Dominio.Entidades;
using Fintech.Dominio.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Fintech.Repositorios.SqlServer
{
    public class MovimentoRepositorio : IMovimentoRepositorio
    {
        private readonly string stringConexao;

        public MovimentoRepositorio(string stringConexao)
        {
            this.stringConexao = stringConexao;
        }
        public void Atualizar(Movimento movimento)
        {
            throw new System.NotImplementedException();
        }   
        
        public void Inserir(Movimento movimento)
        {
            var instrucao = @$"Insert Movimento(IdConta, Data, Valor, Operacao)
                               values({movimento.Conta.Numero}, @Data, @Valor, @Operacao)";

            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Execute(instrucao, movimento);
            }
        }

        public Movimento Selecionar()
        {
            throw new System.NotImplementedException();
        }

        public Movimento Selecionar(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Movimento> Selecionar(int numeroAgencia, int numeroConta)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Movimento>> SelecionarAsync(int numeroAgencia, int numeroConta)
        {
            var instrucao = @$"Select Data, Operacao, Valor
                 from movimento where IdConta = @numeroConta";

            using (var conexao = new SqlConnection(stringConexao))
            {
                var movimentos = await conexao.QueryAsync<Movimento>(instrucao, new { numeroConta });

                return movimentos.AsList();
            }
        }
    }
}
