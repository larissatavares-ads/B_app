using B_app.Data;
using Microsoft.AspNetCore.Mvc;

namespace B_app.Controller;
[ApiController]
[Route("transferencia")]
public class ClienteController
{
    //UPDATE
    [HttpPut("transferencia/credito")]
    public async Task<IActionResult> PutAsync(
       [FromServices] DataContext)
}