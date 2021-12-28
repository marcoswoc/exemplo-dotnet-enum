using exemplo_dotnet_enum.Enums;

namespace exemplo_dotnet_apienum.Models;
public class Cliente
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public StatusClienteEnum Status { get; set; }
    public Cliente(string nome, string email, StatusClienteEnum status)
    {
        Nome = nome;
        Email = email;
        Status = status;
    }
}