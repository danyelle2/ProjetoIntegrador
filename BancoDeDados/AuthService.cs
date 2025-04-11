using MySql.Data.MySqlClient;
using ProjetoIntegrador.BancoDeDados;
using ProjetoIntegrador.Model;
using System;
using System.Security.Cryptography;
using System.Text;

namespace ProjetoIntegrador.BancoDeDados
{
    public class AuthService
    {
        private readonly DatabaseService _databaseService;

        public AuthService(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public Usuario AuthenticateUsuario(string cpf, string senha, bool statusUsuario)
        {
            try
            {
                // Query SQL agora valida o CPF e o status do usuário.
                string query = "SELECT * FROM usuario WHERE cpf = @cpfdigitado AND status_usuario = @StatusUsuario";
                var parameters = new MySqlParameter[]
                {
                   new MySqlParameter("@cpfdigitado", cpf),
                   new MySqlParameter("@StatusUsuario", statusUsuario ? 1 : 0), // Converte o valor de bool para 1 ou 0
                };

                using (var respostaBanco = _databaseService.ExecuteQuery(query, parameters))
                {
                    if (respostaBanco.Read())
                    {
                        // Verificando o status do usuário armazenado no banco
                        bool status = Convert.ToBoolean(respostaBanco["status_usuario"]); // A conversão para booleano

                        // Comparando a senha
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
                                StatusUsuario = status, // Retorna o status convertido corretamente
                            };
                        }
                    }
                }

                // Retorna null se o usuário não for encontrado ou se as credenciais forem inválidas
                return null;
            }
            catch (Exception ex)
            {
                // Retorna um erro detalhado caso algo aconteça durante a autenticação
                throw new Exception("Erro durante autenticação: " + ex.Message);
            }
        }
    }
}
