using System.Reflection.Metadata.Ecma335;

namespace B_app.Models;

public class ContaCorrente
{
    public int Conta { get; set; }
    public int Agencia { get; set; }
    public decimal Saldo { get; set; }
    public Cliente Titular { get; set; }
    public DateTime Data { get; set; } = DateTime.Now;

    public ContaCorrente(int conta, int agencia)
    {
        Conta = conta;
        Agencia = agencia;
    }

    public void Creditar(decimal valor)
    {
        Saldo += valor;
    }

    public void Debitar(decimal valor, ContaCorrente contaDestino)
    {
        if(valor < Saldo)
            throw new ArgumentException("Seu saldo é insuficiente para transferencia", nameof(valor));
        Saldo -= valor;
        contaDestino.Creditar(valor);
    }
}