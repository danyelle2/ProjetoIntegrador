using MySql.Data.MySqlClient;
using ProjetoIntegrador.Services;
using ProjetoIntegrador.Model;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;

namespace ProjetoIntegrador.Services
{
    public class AutenticacaoUsuario
    {
        private readonly DatabaseService _databaseService;

        public AutenticacaoUsuario(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public Usuario AutenticarUsuario(string cpf, string senha)
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
                                   u.id_modalidade
                      FROM usuario u
                      WHERE u.cpf = @cpf"; 

                    var parameters = new MySqlParameter[]
                    {
                        new MySqlParameter("@cpf", cpf)
                    };

                    using (var respostaBanco = _databaseService.ExecuteQuery(query, parameters))
                    {
                    if (respostaBanco.Read())
                    {
                        bool status = Convert.ToBoolean(respostaBanco["status_usuario"]);

                        if (!status)
                        {
                            throw new UnauthorizedAccessException("Usuário inativo.");
                        }
                        string storedHash = respostaBanco["senha"].ToString();
                        string inputHash = Criptografia.HashPassword(senha);

                              if (!Criptografia.SecureEquals(storedHash, inputHash))
                              {
                                throw new UnauthorizedAccessException("Senha incorreta.");

                              }
                                  return new Usuario
                                  {
                                    Id = Convert.ToInt32(respostaBanco["id_usuario"]),
                                    Nome = respostaBanco["nome"].ToString(),
                                     TipoUsuario = respostaBanco["tipo_usuario"].ToString(),
                                     StatusUsuario = status,
                                     IdModalidade = Convert.ToInt32(respostaBanco["id_modalidade"])
                                  };
                    }
                    throw new KeyNotFoundException("Usuário não encontrado.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro durante autenticação: " + ex.Message, ex);
            }
        }
    }
}