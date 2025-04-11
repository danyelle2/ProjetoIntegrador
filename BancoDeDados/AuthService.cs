////-- Services/AuthService.cs
//using ConexaoMySQL.Models;
//using ConexaoMySQL.Services;
using MySql.Data.MySqlClient;
using ProjetoIntegrador.BancoDeDados;
using ProjetoIntegrador.Model;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ProjetoIntegrador.BancoDeDados
{
    public class AuthService
    {
        private readonly DatabaseService _databaseService;

        public AuthService(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public Usuario Authenticate(string usuario, string senha)
        {
            try
            {
                // Primeiro busca o usuário pelo email
                // colocar do jeito que ta no banco de dados usuario aluno etc.
                string query = "SELECT id, nome, cpf, idade, responsavel, telefone, data_entrada, data_saida, tipo_usuario,senha, status_usuario FROM usuarios"; // WHERE email = @emailDigitado";
                var parameters = new MySqlParameter[]
                {

                    new MySqlParameter("@emailDigitado", usuario),

                };

                using (var respostaBanco = _databaseService.ExecuteQuery(query, parameters))
                {
                    if (respostaBanco.Read())

                    {
                        // Verifica a senha
                        string storedHash = respostaBanco["senha_hash"].ToString();
                        string inputHash = Criptografia.HashPassword(senha);

                        if (storedHash == inputHash)
                        {
                            return new Usuario
                            {
                                Id = Convert.ToInt32(respostaBanco["id"]),
                                Nome = respostaBanco["nome"].ToString(),
                                SenhaHash = respostaBanco["senha_hash"].ToString(),
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