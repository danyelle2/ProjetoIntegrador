using System;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace ProjetoIntegrador.Services
{
    public class Criptografia
    {
        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public static bool SecureEquals(string a, string b)
        {
            if (a == null || b == null || a.Length != b.Length)
                return false;

            int result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                result |= a[i] ^ b[i];
            }
            return result == 0;
        }
        public static bool VerificarSenha(string senhaDigitada, string hashArmazenado)
        {
            if (string.IsNullOrEmpty(senhaDigitada))
            {
                return false;
            }
            string hashDigitado = HashPassword(senhaDigitada);
            return SecureEquals(hashDigitado, hashArmazenado);
        }

        // Método para inserir senha criptografada (ativo agora) ESSE O CHAT DIGITOU MAS NÃO ENTENDI O UPDATE DE ATUALIZAR
        public static void InserirSenhaCriptografada(string connectionString, string senha, int usuarioId)
        {
            string senhaCriptografada = HashPassword(senha);

            string query = "UPDATE Usuarios SET senha = @SenhaHash WHERE id_usuario = @UsuarioId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SenhaHash", senhaCriptografada);
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine(rowsAffected > 0
                        ? "Senha atualizada com sucesso!"
                        : "Nenhum usuário encontrado com o ID especificado.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao atualizar a senha: " + ex.Message);
                }
            }
        }
    }
}