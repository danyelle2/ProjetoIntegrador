﻿// Services/DatabaseService.cs
using System;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ProjetoIntegrador.Services
{
    public class DatabaseService : IDisposable
    {
        public readonly MySqlConnection _connection;
        public MySqlConnection Connection => _connection;
        private bool _disposed = false;

        public DatabaseService()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            _connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();

            }

        }

        public void CloseConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Closed)
            {
                _connection.Close();
            }
        }
        public MySqlDataReader ExecuteQuery(string query, MySqlParameter[] parameters = null)


        {
            try
            {
                OpenConnection();
                var command = new MySqlCommand(query, _connection);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteReader();
            }
            catch (Exception ex)
            {
                CloseConnection();
                throw new Exception("Erro ao executar consulta: " + ex.Message);
            }
        }

        public int ExecuteNonQuery(string commandText, MySqlParameter[] parameters = null, MySqlTransaction transaction = null)
        {
            try
            {
                OpenConnection();
                var command = new MySqlCommand(commandText, _connection);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar comando: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public object ExecuteScalar(string commandText, MySqlParameter[] parameters = null, MySqlTransaction transaction = null)
        {
            try
            {
                OpenConnection();
                var command = new MySqlCommand(commandText, _connection);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar scalar: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        
         
           public object ExecuteScalarTransaction(string commandText, MySqlParameter[] parameters = null)
        {
            // Executa o comando em uma transação para eu conseguir ligar duas tabelas do banco de dados 
            try
            {
                OpenConnection(); // <- ABRE PRIMEIRO!

                MySqlTransaction transaction = _connection.BeginTransaction(); // <- DEPOIS COMEÇA A TRANSAÇÃO

                var command = new MySqlCommand(commandText, _connection, transaction);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                var result = command.ExecuteScalar(); // Executa o insert

                transaction.Commit(); // COMITA A TRANSAÇÃO!!! (esse passo é importante, senão não salva!)

                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar scalar transaction: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _connection.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}