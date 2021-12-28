using exemplo_dotnet_enum.Enums;
using exemplo_dotnet_apienum.Models;
using Microsoft.AspNetCore.Mvc;

namespace exemplo_dotnet_apienum.Controllers;

[ApiController]
[Route("[controller]")]
public class ClienteController : Controller
{

    [HttpGet(Name = "GetCliente")]
    public IEnumerable<Cliente> Get()
    {
        return new List<Cliente>()
        {
            new Cliente("Ana", "aninha_htinha@email.com", StatusClienteEnum.Ativo),
            new Cliente("João", "joazinho_sk8@email.com", StatusClienteEnum.Inativo),
            new Cliente("José", "ze@email.com", StatusClienteEnum.Excluido),
        };
    }
}