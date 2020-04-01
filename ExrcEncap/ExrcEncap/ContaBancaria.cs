﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExrcEncap
{
    class ContaBancaria
    {
        public int Numero { get; private set;}
        public string Nome { get; set;}
        public double Saldo { get; private set;}

        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }
        public ContaBancaria(int numero, string nome, double depositoInicial):this(numero, nome)
        {

            //Saldo = saldo;
            Deposito(depositoInicial);  
        }
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.00;
        }

        public override string ToString()
        {
            return "Conta: " + Numero +
                ", Titular: " + Nome +
                ", Saldo de : " + Saldo.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
