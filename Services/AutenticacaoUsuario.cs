using MySql.Data.MySqlClient;
using ProjetoIntegrador.Services;
using ProjetoIntegrador.Model;
using System;
using System.Security.Cryptography;
using System.Text;

namespace ProjetoIntegrador.Services
{
    public class AutenticacaoUsuario
    {
        private readonly DatabaseService _databaseService;

        public AutenticacaoUsuario(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public Usuario AutenticarUsuarionaModalidade(string cpf, string senha, bool statusUsuario, string tipoUsuario)
        {
            try
            {
                string query = @"
            SELECT 
                u.id_usuario, 
                u.nome, 
                u.cpf, 
                u.senha, 
                u.tipo_usuario, 
                u.status_usuario, 
                p.id_professor, 
                m.tipo_modalidade 
            FROM usuario u 
            JOIN professor p ON p.id_usuario = u.id_usuario 
            JOIN modalidade m ON p.id_modalidade = m.id_modalidade 
            WHERE u.cpf = @cpf AND u.tipo_usuario = @tipo";

                var parameters = new MySqlParameter[]
                {
            new MySqlParameter("@cpf", cpf),
            new MySqlParameter("@tipo", tipoUsuario)
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
                                IdProfessor = Convert.ToInt32(respostaBanco["id_professor"]),
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
