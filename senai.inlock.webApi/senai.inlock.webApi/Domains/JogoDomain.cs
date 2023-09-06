using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
    /// <summary>
    /// Classe que representa um jogo.
    /// </summary>
    public class JogoDomain
    {
        public int IdJogo { get; set; }
        public int IdEstudio { get; set; }

        [Required(ErrorMessage = "Nome do Jogo é obrigatório")]
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "Valor do Jogo é obrigatório")]
        public double Valor { get; set; }
    }
}
