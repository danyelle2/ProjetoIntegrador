using MySql.Data.MySqlClient;
using ProjetoIntegrador.BancoDeDados;
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

        public void CadastrarUsuario(Usuario usuario)
            {
                string query = @"
            INSERT INTO usuario (nome, cpf, senha, tipo_usuario, status_usuario, id_professor)
            VALUES (@nome, @cpf, @senha, @tipo_usuario, @status_usuario, @id_professor)";

                var parameters = new MySqlParameter[]
                {
            new MySqlParameter("@nome", usuario.Nome),
            new MySqlParameter("@cpf", usuario.Cpf),
            new MySqlParameter("@senha", Criptografia.HashPassword(usuario.Senha)),
            new MySqlParameter("@tipo_usuario", usuario.TipoUsuario),
            new MySqlParameter("@status_usuario", true),
            new MySqlParameter("@id_professor", usuario.TipoMembro)
                };

                _databaseService.ExecuteNonQuery(query, parameters);
            }
        }

    }
}
