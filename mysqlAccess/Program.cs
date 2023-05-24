namespace mysqlAccess;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        string cs = @"server=localhost;userid=daw;pwd=daw;database=daw";
        try {
            var con = new MySql.Data.MySqlClient.MySqlConnection();
            con.ConnectionString = cs;
            con.Open();
            Console.WriteLine($"MySQL version : {con.ServerVersion}");
            string sql = "SELECT * FROM jobs";
            var cmd = new MySqlCommand(sql, con);
            // cmd.Parameters.AddWithValue("@valor", 1);
            cmd.Prepare();
            MySqlDataReader rdr = cmd.ExecuteReader();
            Console.WriteLine($"{rdr.GetName(0),-15} {rdr.GetName(1),-30} {rdr.GetName(2), -10} {rdr.GetName(3), -10}");
            while (rdr.Read())
            {
                Console.WriteLine("{0,-15} {1,-30} {2, 10} {3, 10}", rdr.GetString(0), rdr.GetString(1), rdr.GetInt32(2), rdr.GetInt32(3) );
            }
            con.Close();
            Console.ReadKey();
        } catch(Exception e) {
            System.Console.WriteLine(e.Message);
        }
    }
}
