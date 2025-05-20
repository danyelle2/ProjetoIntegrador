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
            
        
    }
}