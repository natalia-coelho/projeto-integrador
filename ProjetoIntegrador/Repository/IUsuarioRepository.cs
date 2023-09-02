using ProjetoIntegrador.Models;

namespace ProjetoIntegrador.Repository
{
    public interface IUsuarioRepository
    {
        public Usuario Get(Guid id);
        public List<Usuario> List();
        public Usuario Create(CreateUsuarioRequest usuarioRequest);
        public Usuario Update(UpdateUsuarioRequest usuarioRequest);
        public void Delete(Guid id);
    }
}
