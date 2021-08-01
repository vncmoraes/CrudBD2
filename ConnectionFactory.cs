using System;
using Npgsql;

namespace CrudBD
{   
    class ConnectionFactory
    {
        // Atributos da classe
        public static string host = "localhost";
        public static string database = "teste";
        public static string username = "postgres";
        public static string password = "admin";

        // Método estático para retornar uma conexão
        public static NpgsqlConnection getConnection()
        {
            try
            {   
                // String de conexão
                string connString = $"Host={host};Database={database};Username={username};Password={password}";
                NpgsqlConnection conn = new NpgsqlConnection(connString);
                return conn;
            }
            catch (NpgsqlException e)
            {

                throw new Exception("Falha na conexão com o banco de dados: ", e);
            }
        }
    }
}