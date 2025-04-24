using System;
using System.Data.SqlClient;
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
            if (a.Length != b.Length) return false;

            int result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                result |= a[i] ^ b[i];
            }

            return result == 0;
        }

        //Tentar inserir a senha manualmente pelo visual
    //    public static void InserirSenhaCriptografada(string senha)
    //    {
    //        string senhaCriptografada = HashPassword(senha);

    //        string query = "INSERT INTO Usuarios (senha) VALUES (@SenhaHash)";

    //        using (SqlConnection conn = new SqlConnection(connectionString))
    //        {
    //            SqlCommand cmd = new SqlCommand(query, conn);
    //            cmd.Parameters.AddWithValue("@SenhaHash", senhaCriptografada);

    //            try
    //            {
    //                conn.Open();
    //                cmd.ExecuteNonQuery();
    //                Console.WriteLine("Senha criptografada inserida com sucesso!");
    //            }
    //            catch (Exception ex)
    //            {
    //                Console.WriteLine("Erro ao inserir a senha no banco: " + ex.Message);
    //            }
    //        }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string senha = "Dab2479";
    //        Criptografia.InserirSenhaCriptografada(senha);
    //    }
    }
}
