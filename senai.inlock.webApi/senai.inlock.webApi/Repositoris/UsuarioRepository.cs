using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interfaces;
using System.Data.SqlClient;

namespace senai.inlock.webApi.Repositoris
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string StringConexao = "Data Source=NOTE06-S15; Initial Catalog=inlock_games_Lucas; User Id=sa; Password=Senai@134;";
        public UsuarioDomain Login(string Email, string Senha)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string querySelect = "SELECT IdUsuario, Email, IdTipoUsuario FROM Usuario WHERE Email = @Email AND Senha = @Senha";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(querySelect, con))
                {
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Senha", Senha);

                    SqlDataReader rdr = cmd.ExecuteReader();
                    {
                        if (rdr.Read())
                        {
                            UsuarioDomain usuario = new UsuarioDomain()
                            {
                                IdUsuario = Convert.ToInt32(rdr["IdUsuario"]),
                                Email = Convert.ToString(rdr["Email"]),
                                IdTipoUsuario = Convert.ToInt32(rdr["IdTipoUsuario"]),
                            };

                            return usuario;
                        }
                        else
                        {
                            return null; 
                        }
                    }
                }
            }
        }
    }
}
