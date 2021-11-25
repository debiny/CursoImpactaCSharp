using System;
using System.Runtime.Serialization;

namespace Fintech.Dominio.Entidades
{
    [Serializable]
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException() : base("saldo insuficiente")
        {
            //base.Message = "Saldo Insuficiente";
        }

        public SaldoInsuficienteException(string message) : base(message)
        {
        }

        public SaldoInsuficienteException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SaldoInsuficienteException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}