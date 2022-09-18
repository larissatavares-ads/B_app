using B_app.Data;
using B_app.Models;
using B_app.Ports.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace B_app.Controller;
[ApiController]
[Route("cliente")]
public class ClienteController : ControllerBase
{
    [HttpPost("criar")]
    public async Task<IActionResult> PostAsync(
        [FromBody] ClienteViewModel model)
    {
        var titular = new Cliente
        {
            Nome = model.Nome,
            Cpf = model.Cpf
        };
        
    }
}