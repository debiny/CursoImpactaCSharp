using System.Collections.Generic;

namespace Fintech.Dominio.Entidades
{
    public class ContaCorrente : Conta
    {
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
