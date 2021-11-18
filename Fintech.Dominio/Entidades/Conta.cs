using System;
using System.Collections.Generic;

namespace Fintech.Dominio.Entidades
{
    //classe conta nao pode ser instanciada porque ela nao tem um significado completo, para isso usa-se o obstract
    public abstract class Conta
    {
        public int Id { get; set; }
        public Agencia Agencia { get; set; }
        public int Numero { get; set; }
        public string DigitoVerificador { get; set; }
        public decimal Saldo { get; set; }
        public Cliente Cliente { get; set; }

        //metodo virtual pode ser substituido por um override na classe filha
        public virtual void EfetuarOperacao(decimal valor, Operacao operacao)
        {
            switch (operacao)
            {
                case Operacao.Deposito:
                    Saldo += valor;
                    break;
                case Operacao.Saque:
                    if (Saldo > valor)
                        Saldo -= valor;
                    break;
            }
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
