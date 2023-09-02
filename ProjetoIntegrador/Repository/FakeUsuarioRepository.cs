using ProjetoIntegrador.Models;

namespace ProjetoIntegrador.Repository
{
    public class FakeUsuarioRepository : IUsuarioRepository

    {
        private List<Usuario> usuarioList;

        public FakeUsuarioRepository()
        {
            this.usuarioList = new List<Usuario>();
        }

        public List<Usuario> List()
        {
            return this.usuarioList;
        }

        public Usuario Create(CreateUsuarioRequest usuarioRequest)
        {
            // 1. (tentar) converter request para usuario
            // 2. salvar usuario na lista
            // 3. retornar usuario
            Usuario usuario = Usuario.FromRequest(usuarioRequest);
            usuarioList.Add(usuario);

            return usuario;
        }

        public void Delete(Guid id)
        {
            // 1. Achar usuário com id especificado
            // 1.5? pensar no que acontece se a gente passar um id que não existe
            // 2. List.remove(usuario)

            Usuario? deletedUsuario = Get(id);

            usuarioList.Remove(deletedUsuario);
        }

        public Usuario Get(Guid id)
        {
            Usuario? usuario = usuarioList.Find(o => o.Id == id);

            if (usuario == null)
            {
                throw new Exception();
            }

            return usuario;
        }

        public Usuario Update(UpdateUsuarioRequest usuarioRequest)
        {
            throw new NotImplementedException();
        }
    }
}
