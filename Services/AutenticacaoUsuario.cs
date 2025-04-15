using MySql.Data.MySqlClient;
using ProjetoIntegrador.BancoDeDados;
using ProjetoIntegrador.Model;
using System;
using System.Security.Cryptography;
using System.Text;

namespace ProjetoIntegrador.BancoDeDados
{
    public class AutenticacaoUsuario
    {
        private readonly DatabaseService _databaseService;

        public AutenticacaoUsuario(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }
              
            public Usuario AutenticarUsuarionaModalidade(string cpf, string senha, bool statusUsuario)
        {
            try
            {
                string query = @"SELECT u.*, m.tipo_modalidade FROM usuario u JOIN professor p ON u.id_professor = p.Id_professor JOIN modalidade m ON p.id_modalidade = m.id_modalidade WHERE u.cpf = @cpf";

                var parameters = new MySqlParameter[]
                {
                     new MySqlParameter("@cpf", cpf)
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

                        if (Criptografia.SecureEquals(storedHash, inputHash))
                        {
                            return new Usuario
                            {
                                Id = Convert.ToInt32(respostaBanco["id_usuario"]),
                                Nome = respostaBanco["nome"].ToString(),
                                TipoUsuario = respostaBanco["tipo_usuario"].ToString(),
                                TipoMembro = Convert.ToInt32(respostaBanco["id_professor"]),
                                StatusUsuario = status,
                                Modalidade = respostaBanco["tipo_modalidade"].ToString().ToLower()
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
