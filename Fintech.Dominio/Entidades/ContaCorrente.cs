using System.Collections.Generic;

namespace Fintech.Dominio.Entidades
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(Agencia agencia, int numero, string digitoVerificador):base(agencia,numero, digitoVerificador)
        {
            //Numero = numero;
            //DigitoVerificador = digitoVerificador;
        }

        public bool EmissaoChequeHabilitada { get; set; }

        public override List<string> Validar()
        {
            var erro = new List<string>();

            if (EmissaoChequeHabilitada == null)
                erro.Add("EmissaoChequeHabilitada vazia");

            return erro;
        }
    }
    
}
