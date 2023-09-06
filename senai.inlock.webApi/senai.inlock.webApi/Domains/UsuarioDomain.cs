using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
    public class UsuarioDomain
    {
        /// <summary>
        /// Classe que representa um usuário.
        /// </summary>
        public int IdUsuario { get; set; }
        public int IdTipoUsuario { get; set; }
        [Required(ErrorMessage = "Email é obrigatório")]
        public string Email { get; set; }
        [StringLength(15, MinimumLength = 8, ErrorMessage = "A senha deve ter de 3 à 20 caracteres")]
        [Required(ErrorMessage = "A Senha é Obrigatória")]
        public string Senha { get; set; }
    }
}
