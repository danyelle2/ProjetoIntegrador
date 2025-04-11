using MySql.Data.MySqlClient;
using ProjetoIntegrador.BancoDeDados;
using ProjetoIntegrador.Model;
using System;
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

        public Usuario AuthenticacaoUsuario(string cpf, string senha, bool statusUsuario)
        {
            try
            {
                //  Fiz essa para autenticar login
                string query = "SELECT * FROM usuario WHERE cpf = @cpfdigitado AND status_usuario = @StatusUsuario";
                var parameters = new MySqlParameter[]
                {
                   new MySqlParameter("@cpfdigitado", cpf),
                   new MySqlParameter("@StatusUsuario", statusUsuario ? 1 : 0), 
                };

                using (var respostaBanco = _databaseService.ExecuteQuery(query, parameters))
                {
                    if (respostaBanco.Read())
                    {
                        
                        bool status = Convert.ToBoolean(respostaBanco["status_usuario"]); 

                        
                        string storedHash = respostaBanco["senha"].ToString();
                        string inputHash = Criptografia.HashPassword(senha);

                        if (storedHash == inputHash)
                        {
                            return new Usuario
                            {
                                Id = Convert.ToInt32(respostaBanco["id_usuario"]),
                                Nome = respostaBanco["nome"].ToString(),
                                Senha = respostaBanco["senha"].ToString(),
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
