namespace ProjetoIntegrador.Models
{
    public class Usuario
    {
        public Guid Id;
        public String? Nome { get; set; }
        public String? Email { get; set; }
        public String? Telefone { get; set; }
        private Usuario() { }

        public static Usuario FromRequest(CreateUsuarioRequest request)
        {
            return new Usuario
            {
                Id = Guid.NewGuid(),
                Nome = request.Nome,
                Email = request.Email,
                Telefone = request.Telefone
            };
        }

        public Usuario Update(UpdateUsuarioRequest updateRequest)
        {
            this.Nome = updateRequest.Nome;
            this.Email = updateRequest.Email;
            this.Telefone = updateRequest.Telefone;

            return this;
        }
    }
}
