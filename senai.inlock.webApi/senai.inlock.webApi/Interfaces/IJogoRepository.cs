using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    public interface IJogoRepository
    {
        /// <summary>
        /// Cadastrar um novo Estudio
        /// </summary>
        /// <param name="novoJogo">objeto que será cadastrado</param>
        void Cadastrar(JogoDomain novoJogo);
        /// <summary>
        /// Listar todos os objetos cadastrados
        /// </summary>
        /// <returns>Lista com os objetos</returns>
        List<JogoDomain> Listar();
        /// <summary>
        /// Atuslizar um objeto existente passandoseu id pelo corpo da requisição
        /// </summary>
        /// <param name="genero">Objetocom atualizado</param>
        void Atualizar(JogoDomain jogo);
        /// <summary>
        /// Deletar um objeto
        /// </summary>
        /// <param name="Id">id do objetoserá deletado</param>
        void Deletar(int id);
        /// <summary>
        /// Busca um obejto atravez do seu id
        /// </summary>
        /// <param name="Id">id do obejeto a ser buscado</param>
        /// <returns>objeto buscado</returns>
        JogoDomain BuscarPorId(int id);
    }
}
