using System.Collections.Generic;

namespace Fintech.Dominio.Entidades
{

    //Herança
    public class Poupanca : Conta
    {
        public decimal TaxaRendimento { get; set; }

        public override List<string> Validar()
        {
            var erro = base.ValidarBase();

            if (TaxaRendimento <= 0)
                erro.Add("TaxaRendimento vazia");

            return erro;

        }
    }
}
