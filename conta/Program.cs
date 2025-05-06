using System;
using controleconta;

using System;

namespace conta
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando cliente 1
            Cliente cliente1 = new Cliente("Maria", new DateTime(1993, 1, 1), "12345678901");

            // Criando cliente 2
            Cliente cliente2 = new Cliente("João", new DateTime(1998, 5, 20), "98765432100");

            // Criando Banco
            Banco banco1 = new Banco("Banco do Mundo", 123);

            // Criando agência
            Agencia agencia1 = new Agencia(101, "27280000", "2433330000", banco1);

            // Conta 1
            Conta conta1 = new Conta(1001, 1500.50m, cliente1, agencia1);

            // Conta 2
            Conta conta2 = new Conta(1002, 2500.75m, cliente2, agencia1);

            // Exibir informações das contas
            Console.WriteLine("Conta 1: Número = {0}, Cliente = {1}, CPF = {2}, Saldo = {3:C2} | Idade: {4} ({5})",
                conta1.Numero, conta1.Titular.Nome, conta1.Titular.CPF, conta1.Saldo, conta1.Titular.Idade, conta1.Titular.IdadeEmRomanos());

            Console.WriteLine("Conta 2: Número = {0}, Cliente = {1}, CPF = {2}, Saldo = {3:C2} | Idade: {4} ({5})",
                conta2.Numero, conta2.Titular.Nome, conta2.Titular.CPF, conta2.Saldo, conta2.Titular.Idade, conta2.Titular.IdadeEmRomanos());

            // Total e maior saldo
            Console.WriteLine("\nSaldo total geral: {0:C2}", Conta.SaldoTotal);
            Console.WriteLine("Maior saldo: Conta {0}, Saldo = {1:C2}", Conta.NumeroContaMaiorSaldo, Conta.MaiorSaldo);

            // Testando a função de saque
            conta1.Sacar(200);
            Console.WriteLine("Após saque, Saldo da Conta 1: {0:C2}", conta1.Saldo);

            // Testando a função de depósito
            conta2.Depositar(500);
            Console.WriteLine("Após depósito, Saldo da Conta 2: {0:C2}", conta2.Saldo);

            Console.ReadLine();
        }
    }
}
