using System.Data.SQLite;

namespace SQLiteDatabase
{
    public class ParlemConnection
    {
        private readonly SQLiteConnection con;

        public ParlemConnection()
        {
            con = new("Data Source=parlem.db");
            con.Open();

            CreateTableCustomers();
            InitializeTableCustomers();
            //TODO Create and initialize table Products
        }

        private void InitializeTableCustomers()
        {
            using SQLiteCommand cmd = new(con);
            cmd.CommandText = "Delete from Customers";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO Customers (DocType, DocNum, Email, GivenName, FamilyName, Phone) " +
            "VALUES (@docType, @docNum, @email, @givenName, @familyName, @phone)";

            cmd.Parameters.AddWithValue("@docType", "nif");
            cmd.Parameters.AddWithValue("@docNum", "11223344E");
            cmd.Parameters.AddWithValue("@email", "it@parlem.com");
            cmd.Parameters.AddWithValue("@givenName", "Enriqueta");
            cmd.Parameters.AddWithValue("@familyName", "Parlem");
            cmd.Parameters.AddWithValue("@phone", "668668668");
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@docType", "nif");
            cmd.Parameters.AddWithValue("@docNum", "12345678A");
            cmd.Parameters.AddWithValue("@email", "it@parlem.com");
            cmd.Parameters.AddWithValue("@givenName", "Franchesca");
            cmd.Parameters.AddWithValue("@familyName", "Tívoli");
            cmd.Parameters.AddWithValue("@phone", "no quiere darlo");
            cmd.ExecuteNonQuery();
        }

        private void CreateTableCustomers()
        {
            using SQLiteCommand cmd = new(con);
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Customers (" +
                "Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                "DocType TEXT, " +
                "DocNum TEXT, " +
                "Email TEXT, " +
                "GivenName TEXT, " +
                "FamilyName TEXT, " +
                "Phone TEXT)";
            cmd.ExecuteNonQuery();
        }
    }
}