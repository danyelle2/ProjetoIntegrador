using MySql.Data.MySqlClient;
using ProjetoIntegrador.BancoDeDados;
using ProjetoIntegrador.Model;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace ProjetoIntegrador.BancoDeDados
{
    public class AutenticacaoLogin
    {
        private readonly DatabaseService _databaseService;

        public AutenticacaoLogin(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public Usuario AutenticarUsuario(string cpf, string senha, bool statusUsuario)
        {
            try
            {
                string query = "SELECT * FROM usuario WHERE cpf = @cpf";
                var parameters = new MySqlParameter[]
                {
            new MySqlParameter("@cpf", cpf),
                };



                using (var respostaBanco = _databaseService.ExecuteQuery(query, parameters))
                {
                    if (respostaBanco.Read())
                    {
                        bool status = Convert.ToBoolean(respostaBanco["status_usuario"]);
                        if (status != statusUsuario)
                            return null;

                        string storedHash = respostaBanco["senha"].ToString();
                        string inputHash = Criptografia.HashPassword(senha);

                        if (SecureEquals(storedHash, inputHash))
                        {
                            return new Usuario
                            {
                                Id = Convert.ToInt32(respostaBanco["id_usuario"]),
                                Nome = respostaBanco["nome"].ToString(),
                                TipoUsuario = respostaBanco["tipo_usuario"].ToString(),
                                TipoMembro = Convert.ToInt32(respostaBanco["id_professor"]),
                                StatusUsuario = status,
                            };
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro durante autenticação: " + ex.Message);
            }
        }
    }
}
