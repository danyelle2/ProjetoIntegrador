using MySql.Data.MySqlClient;
using ProjetoIntegrador.BancoDeDados;
using ProjetoIntegrador.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Controller.Usuario
{
    public class UsuarioRepositorio
    {
        private readonly DatabaseService _databaseService;

        public UsuarioRepositorio(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public void CadastrarUsuario(ProjetoIntegrador.Model.Usuario usuario)
        {
            if (usuario == null)
            {
                throw new ArgumentNullException(nameof(usuario), "O objeto usuário não pode ser nulo.");
            }

            string senhaHash = Criptografia.HashPassword(usuario.Senha);
            if (string.IsNullOrWhiteSpace(senhaHash))
            {
                throw new InvalidOperationException("A senha criptografada não pode ser nula ou vazia.");
            }

            string query = @"INSERT INTO usuario (nome, cpf, senha, tipo_usuario, status_usuario, id_professor)VALUES (@nome, @cpf, @senha, @tipo_usuario, @status_usuario, @id_professor)";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@nome", usuario.Nome),
                new MySqlParameter("@cpf", usuario.Cpf),
                new MySqlParameter("@senha", senhaHash),
                new MySqlParameter("@tipo_usuario", usuario.TipoUsuario),
                new MySqlParameter("@status_usuario", true),
                new MySqlParameter("@id_professor", usuario.TipoMembro)
            };

            try
            {
                _databaseService.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Erro ao cadastrar usuário.", ex);
            }
        }
    }
}
