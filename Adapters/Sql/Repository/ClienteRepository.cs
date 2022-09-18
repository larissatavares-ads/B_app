using System.Data;
using System.Data.SqlClient;
using B_app.Core.Interfaces.Adapter.Sql;
using B_app.Core.Settings;
using B_app.Models;
using Dapper;

namespace B_app.Repository;

public class ClienteRepository : IClienteRepository
{
    private string _connectionString;
    public ClienteRepository(ConnectionStringSettings settings)
    {
        _connectionString = settings.ConnectionString();
    }
    public async Task CriarTitular(Cliente titular)
    {
        using (IDbConnection conexao = new SqlConnection(_connectionString))
        {
            conexao.Open();
            await conexao
                .ExecuteAsync("INSERT INTO Cliente (Nome, Cpf) VALUES (@Nome, @Cpf);", titular)
        }
    }
}