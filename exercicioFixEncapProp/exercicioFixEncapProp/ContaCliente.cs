using System;
using System.Collections.Generic;
using System.Text;
using
    System.Globalization;

namespace exercicioFixEncapProp
{
    class ContaCliente
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaCliente(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;            
        }
        public ContaCliente(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            //Saldo = saldo;
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void saque(double quantia)
        {
            Saldo-=quantia +5.00;
        }
        public override string ToString()
        {
            return "Conta " + Numero + 
                   ", Titular: " + Titular + 
                   ", Saldo: $ " + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
