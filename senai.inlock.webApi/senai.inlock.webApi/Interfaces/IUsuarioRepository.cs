using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório UsuarioRepository
    /// Definir os métodos que serão implementados pelo UsuarioRepository
    /// </summary>
    public interface IUsuarioRepository
    {
        UsuarioDomain Login(string Email, string Senha);
    }
}
