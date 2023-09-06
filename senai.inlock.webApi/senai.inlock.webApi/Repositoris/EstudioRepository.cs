using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using System.Data.SqlClient;

namespace senai.inlock.webApi.Repositoris
{
    public class EstudioRepository : IEstudioRepository
    {
        private string StringConexao = "Data Source=NOTE06-S15; Initial Catalog=inlock_games_Lucas; User Id=sa; Password=Senai@134;";
        public void Atualizar(EstudioDomain estudio)
        {
            throw new NotImplementedException();
        }

        public EstudioDomain BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(EstudioDomain novoEstudio)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<EstudioDomain> Listar()
        {
            List<EstudioDomain> listaEstudio = new List<EstudioDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string querySelectAll = "SELECT IdEstudio, Nome FROM Estudio";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        EstudioDomain estudio = new EstudioDomain()
                        {
                            IdEstudio = Convert.ToInt32(rdr[0]),

                            Nome = Convert.ToString(rdr["Nome"])
                        };

                        listaEstudio.Add(estudio);

                    }
                }
            }
            return listaEstudio;
        }
    }
}
