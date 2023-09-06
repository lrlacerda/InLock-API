using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interfaces
{
    public interface IEstudioRepository
    {
        /// <summary>
        /// Cadastrar um novo Estudio
        /// </summary>
        /// <param name="novoEstudio">objeto que será cadastrado</param>
        void Cadastrar(EstudioDomain novoEstudio);
        /// <summary>
        /// Listar todos os objetos cadastrados
        /// </summary>
        /// <returns>Lista com os objetos</returns>
        List<EstudioDomain> Listar();
        /// <summary>
        /// Atuslizar um objeto existente passandoseu id pelo corpo da requisição
        /// </summary>
        /// <param name="genero">Objetocom atualizado</param>
        void Atualizar(EstudioDomain estudio);
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
        EstudioDomain BuscarPorId(int id);

    }
}
