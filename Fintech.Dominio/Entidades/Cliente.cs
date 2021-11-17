using System;

namespace Fintech.Dominio.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Sexo Sexo { get; set; }
        public int MyProperty { get; set; }
        public Endereco EnderecoResidencial { get; set; }
        public ContaCorrente ContaCorrente { get; set; }
    }
}