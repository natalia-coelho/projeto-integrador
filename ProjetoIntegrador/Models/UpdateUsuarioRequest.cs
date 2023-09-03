namespace ProjetoIntegrador.Models
{
    public record UpdateUsuarioRequest
    (
        Guid Id,
        String Nome,
        String Email,
        String Telefone
    );
}
