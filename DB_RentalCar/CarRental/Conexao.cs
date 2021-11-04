using System;
using MySql.Data.MySqlClient;

namespace CarRental
{
    class Conexao
    {
        const String server = "localhost";
        const String user = "root";
        const String pass = "";
        const String database = "db_rentalcar";
        const String port = "3360";

        public static MySqlConnection GetConnection()
        {
            try
            {
                //Monta uma string de conexão com os parâmetros acima
                String myConnString = $"server={server}; uid={user}; pdw={pass};database={database};port={port}";
                //Cria uma instancia da Classe de conexão
                MySqlConnection conn = new MySqlConnection();

                conn.ConnectionString = myConnString;
                return conn;
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
