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

            int idModalidade;

            if (usuario.TipoUsuario == "usuario_padrao")
            {
                idModalidade = usuario.IdModalidade;
            }
            else
            {
                idModalidade = 1;
                //modalidade 1 é GERAL DO ADM
                // 2 ZUMBA, 3 FUNCIONAL, 4 MUAY THAI
            }

            string query = @"
                INSERT INTO usuario (nome, cpf,senha, tipo_usuario, status_usuario, id_modalidade)
                  VALUES (@nome, @cpf, @senha, @tipo_usuario, @status_usuario, @id_modalidade); 
                    SELECT LAST_INSERT_ID();";

            var parameters = new MySqlParameter[]

            {

             new MySqlParameter("@nome", usuario.Nome),
                new MySqlParameter("@cpf", usuario.Cpf),
                   new MySqlParameter("@senha", senhaHash),
                     new MySqlParameter("@tipo_usuario", usuario.TipoUsuario),
                       new MySqlParameter("@status_usuario", true),
                         new MySqlParameter("@id_modalidade", idModalidade),
            };
            // parametros é só quando o usuario for digitar um dado. Quando é autoincrement não precisa
            // todavia quando o id não for da tabela, como o id_modalidade, ele precisa ser passado por isso é passado no query2
            // parametros serve para segurança do código.


           


            try
            {
                int idUsuario = Convert.ToInt32(_databaseService.ExecuteScalarTransaction(query, parameters));

                if (usuario.TipoUsuario == "usuario_padrao")
                {
                    string query2 = @" 
                         INSERT INTO professor (id_usuario, id_modalidade)
                         VALUES (@id_usuario, @id_modalidade)";

                    var parameters2 = new MySqlParameter[]
                    {
                          new MySqlParameter("@id_usuario", idUsuario),
                      new MySqlParameter("@id_modalidade", idModalidade),
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