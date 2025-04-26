using MySql.Data.MySqlClient;
using ProjetoIntegrador.Model;
using ProjetoIntegrador.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

            string query = @"
            INSERT INTO usuario (nome, cpf, senha, tipo_usuario, status_usuario)
            VALUES (@nome, @cpf, @senha, @tipo_usuario, @status_usuario); 
            SELECT LAST_INSERT_ID ();";



            // parametros é só quando o usuario for digitar um dado. Quando é autoincrement não precisa
            // todavia quando o id não for da tabela, como o id_modalidade, ele precisa ser passado por isso é passado no query2
            // parametros serve para segurança do código.

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@nome", usuario.Nome),
                new MySqlParameter("@cpf", usuario.Cpf),
                new MySqlParameter("@senha", senhaHash),
                new MySqlParameter("@tipo_usuario", usuario.TipoUsuario),
                new MySqlParameter("@status_usuario", true),
            };

            int idModalidade;

            if (usuario.TipoUsuario == "administrador")
            {
                idModalidade = 5;
                //modalidade 5 é GERAL DO ADM
            }
            else
            {
                
                idModalidade = usuario.IdModalidade;
            }


            try
            {
                int idUsuario = Convert.ToInt32(_databaseService.ExecuteScalarTransaction(query, parameters));

                if (usuario.TipoUsuario == "usuario_padrao")
                {
                    string query2 = @" 
                         INSERT INTO modalidade (tipo_modalidade)
                         VALUES (@tipo_modalidade)";

                    var parameters2 = new MySqlParameter[]
                    {
                      new MySqlParameter("@tipo_modalidade", idModalidade),
                    };

                    _databaseService.ExecuteNonQuery(query2, parameters2);
                }
                
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Erro ao cadastrar usuário.", ex);
            }
        }
    }
}