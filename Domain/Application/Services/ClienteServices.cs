using B_app.Core.Interfaces.Adapter.Sql;
using B_app.Domain.Core.Interfaces.Application.Services;
using B_app.Models;

namespace B_app.Domain.Application.Services;

public class ClienteServices : IClienteServices
{
    private IClienteRepository _clienteRepository;
    public ClienteServices(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }
    public async Task<Cliente> FidelizarTitular(Cliente titular)
    {
        await _clienteRepository.CriarTitular(titular);
        return titular;
    }
}