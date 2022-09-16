using System.Reflection.Metadata.Ecma335;

namespace B_app.Models;

public class Cliente
{
    public int Conta { get; set; }
    public int Agencia { get; set; }
    public decimal Saldo { get; set; }
    public DateTime Data { get; set; } = DateTime.Now;

    public Cliente(int conta, int agencia)
    {
        Conta = conta;
        Agencia = agencia;
    }

    public void Credito(decimal valor)
    {
        Saldo += valor;
    }

    public void Debito(decimal valor)
    {
        if(valor < Saldo)
            throw new ArgumentException("Seu saldo é insuficiente para transferencia", nameof(valor));
        Saldo -= valor;
    }
}