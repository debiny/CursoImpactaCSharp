using System;
using System.Collections.Generic;
using System.Linq;

namespace Fintech.Dominio.Entidades
{
    //classe conta nao pode ser instanciada porque ela nao tem um significado completo, para isso usa-se o obstract
    public abstract class Conta
    {
        protected Conta(Agencia agencia, int numero, string digitoVerificador)
        {
            Agencia = agencia;
            Numero = numero;
            DigitoVerificador = digitoVerificador;
        }

        public int Id { get; set; }
        public Agencia Agencia { get; set; }
        public int Numero { get; set; }
        public string DigitoVerificador { get; set; }
        public decimal Saldo 
        {
            get { return TotalDepositos - TotalSaques; }
            private set { }
        }
        public Cliente Cliente { get; set; }
        public List<Movimento> Movimentos { get; set; } = new List<Movimento>();
        public decimal TotalDepositos
        {
            get
            {
                return Movimentos.Where(m => m.Operacao == Operacao.Deposito).Sum(m => m.Valor);
            }

        }
        //ouotra maneira de escrever uma propertie
        public decimal TotalSaques => Movimentos.Where(m => m.Operacao == Operacao.Saque).Sum(m => m.Valor);
       

        //metodo virtual pode ser substituido por um override na classe filha
        public virtual Movimento EfetuarOperacao(decimal valor, Operacao operacao, decimal limite = 0)
        {
            //var sucesso = true;
            Movimento movimento = null;

            switch (operacao)
            {
                case Operacao.Deposito:
                    Saldo += valor;
                    break;
                case Operacao.Saque:
                    if (Saldo  + limite> valor)
                        Saldo -= valor;
                    else
                    {
                        //sucesso = false;
                        //throw new SystemException("Saldo insuficiente");
                        throw new SaldoInsuficienteException();
                    }
                    break;
            }
            //if (sucesso)
            //{
                movimento = new Movimento(operacao, valor);
                movimento.Conta = this;

                Movimentos.Add(movimento);
            //}
            return movimento;

        }

        //metodo abstract nao possui implementação na classe base mais as classes filhas precisam implementar
        public abstract List<string> Validar();

        public List<string> ValidarBase()
        {
            var erro = new List<string>();

            if (Numero <= 0)
                erro.Add("Numero da conta inválido");

            if (string.IsNullOrEmpty(DigitoVerificador))
                erro.Add("Digito verificador é inválido");

            return erro;

        }
    }
}
