using ProjetoIntegrador.Services;
using System;
using MySql.Data.MySqlClient;

namespace ProjetoIntegrador.Controller.Repositorio
{
    internal class RepositorioRecuperarSenha
    {
        private readonly DatabaseService _databaseService;

        public RepositorioRecuperarSenha(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public bool VerificarUsuario(string nome, string cpf)
        {
            string query = "SELECT COUNT(*) FROM usuario WHERE nome = @nome AND cpf = @cpf";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@nome", nome),
                new MySqlParameter("@cpf", cpf)
            };

            object result = _databaseService.ExecuteScalar(query, parameters);
            int count = Convert.ToInt32(result);
            return count > 0;
        }

        public bool AtualizarSenha(string nome, string cpf, string novaSenha)
        {
            string senhaCriptografada = Criptografia.HashPassword(novaSenha);

            string query = "UPDATE usuario SET senha = @senha WHERE nome = @nome AND cpf = @cpf";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@senha", senhaCriptografada),
                new MySqlParameter("@nome", nome),
                new MySqlParameter("@cpf", cpf)
            };

            int rowsAffected = _databaseService.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
    }
}
