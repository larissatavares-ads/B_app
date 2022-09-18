using B_app.Core.Interfaces.Adapter.Sql;
using B_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace B_app.Domain.Application.Services;

public class ClienteServices
{
    private IClienteRepository _clienteRepository;
    public async Task<Cliente> CriarTitular(Cliente titular)
    {
        await _clienteRepository.CriarTitular(titular);
        return titular;
    }
}