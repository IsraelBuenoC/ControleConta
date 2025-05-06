using System;

namespace controleconta
{
    class Conta
    {
        public static decimal SaldoTotal { get; private set; }
        public static decimal MaiorSaldo { get; private set; }
        public static int NumeroContaMaiorSaldo { get; private set; }
        private decimal saldo;
        public int Numero { get; private set; }
        public Cliente Titular { get; private set; }
        public Agencia Agencia { get; private set; }

        public Conta(int numero, decimal saldoInicial, Cliente titular, Agencia agencia)
        {
            if (saldoInicial < 10.00m)
            {
                throw new ArgumentException("Saldo inicial deve ser igual ou maior que R$10,00.");
            }

            Numero = numero;
            saldo = saldoInicial;
            Titular = titular ?? throw new ArgumentNullException(nameof(titular));
            Agencia = agencia ?? throw new ArgumentNullException(nameof(agencia));
        }

        public decimal Saldo => saldo;

        public decimal Sacar(decimal valor)
        {
            if (valor > 0 && valor <= saldo)
            {
                saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saque inválido.");
            }
            return saldo;
        }

        public void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                saldo += valor;
            }
            else
            {
                Console.WriteLine("Depósito inválido.");
            }
        }
    }
}
