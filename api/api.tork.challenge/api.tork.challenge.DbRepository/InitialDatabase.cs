using Microsoft.Data.SqlClient;

namespace api.tork.challenge.DbRepository
{
    public class InitialDatabase
    {
        public InitialDatabase() {

            try
            {
                var connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Integrated Security=True;Initial Catalog=TempDB;Integrated Security=True";

                var connection = new SqlConnection(connectionString);
                connection.Open();

                string scriptPath = Path.Combine("..", "SqlFiles", "default_data.sql");
                string script = File.ReadAllText(scriptPath);

                var command = new SqlCommand(script, connection);
                command.ExecuteNonQuery();
            }
            catch( Exception ex) {}
        }
    }
}
