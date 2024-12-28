using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPersonalizadas
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(string? message) : base(message)
        {
        }

        public SaldoInsuficienteException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public SaldoInsuficienteException(double saque, double saldo) :base($"\nException: Valor do saque {saque} e superior {saldo}")
        {
        }

        public override string Message
        {
            get
            {
                return "Nao existe saldo suficiente para o valor do saque";
            }
        }

        public override string? HelpLink { get => "Info : https://ww.google.com"; }

    }
}
