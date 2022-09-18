using B_app.Models;

namespace B_app.Core.Interfaces.Adapter.Sql;

public interface IClienteRepository
{
    Task CriarTitular(Cliente titular);
}