using B_app.Models;

namespace B_app.Domain.Core.Interfaces.Application.Services;

public interface IClienteServices
{
   Task<Cliente> FidelizarTitular(Cliente titular);
}