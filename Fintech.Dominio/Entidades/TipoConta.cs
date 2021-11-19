using System.ComponentModel;

namespace Fintech.Dominio.Entidades
{
    public enum TipoConta
    {
        [Description("Conta Corrente")]
        ContaCorrente = 1,

        [Description("Conta Especial")]
        ContaEspecial = 2,

        [Description("Poupança")]
        Poupanca = 3
    }
}
