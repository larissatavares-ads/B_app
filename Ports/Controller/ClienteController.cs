using B_app.Domain.Core.Interfaces.Application.Services;
using B_app.Models;
using B_app.Ports.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace B_app.Controller;
[ApiController]
[Route("cliente")]
public class ClienteController : ControllerBase
{
    private IClienteServices _clienteServices;
    public ClienteController(IClienteServices clienteServices)
    {
        _clienteServices = clienteServices;
    }
    [HttpPost("criar")]
    public async Task<IActionResult> PostAsync(
        [FromBody] ClienteViewModel model)
    {
        var titular = new Cliente
        {
            Nome = model.Nome,
            Cpf = model.Cpf
        };
        await _clienteServices.FidelizarTitular(titular);
        return Ok(titular);
    }
}