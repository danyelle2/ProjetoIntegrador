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

        public Usuario AutenticarUsuarionaModalidade(string cpf, string senha, bool statusUsuario, string tipoUsuario)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                throw new ArgumentException("O CPF não pode estar vazio.", nameof(cpf));
            if (string.IsNullOrWhiteSpace(senha))
                throw new ArgumentException("A senha não pode estar vazia.", nameof(senha));
            if (string.IsNullOrWhiteSpace(tipoUsuario))
                throw new ArgumentException("O tipo de usuário não pode estar vazio.", nameof(tipoUsuario));

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
                            throw new UnauthorizedAccessException("O status do usuário não é válido.");

                        string storedHash = respostaBanco["senha"].ToString();
                        string inputHash = Criptografia.HashPassword(senha);

                        if (!Criptografia.SecureEquals(storedHash, inputHash))
                            throw new UnauthorizedAccessException("Senha incorreta.");

                        return new Usuario
                        {
                            Id = Convert.ToInt32(respostaBanco["id_usuario"]),
                            Nome = respostaBanco["nome"].ToString(),
                            TipoUsuario = respostaBanco["tipo_usuario"].ToString(),
                            StatusUsuario = status,
                            Modalidade = respostaBanco["id_modalidade"]?.ToString().ToLower()
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