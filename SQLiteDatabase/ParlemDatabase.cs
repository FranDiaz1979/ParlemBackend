using System.Data.SQLite;

namespace SQLiteDatabase
{
    public static class ParlemDatabase
    {
        public static void Create()
        {
            if (File.Exists("/usr/local/bin/parlem.db"))
            {
                return;
            }

            SQLiteConnection connection = new("Data Source=/usr/local/bin/parlem.db");
            connection.Open();

            CreateTableCustomers(connection);
            InitializeTableCustomers(connection);

            CreateTableProducts(connection);
            InitializeTableProducts(connection);

            CreateTableSales(connection);
            InitializeTableSales(connection);
        }

        private static void CreateTableCustomers(SQLiteConnection connection)
        {
            using SQLiteCommand cmd = new(connection);
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

        private static void InitializeTableCustomers(SQLiteConnection connection)
        {
            using SQLiteCommand cmd = new(connection);
            //cmd.CommandText = "Delete from Customers";
            //cmd.ExecuteNonQuery();

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

        private static void CreateTableProducts(SQLiteConnection connection)
        {
            using SQLiteCommand cmd = new(connection);
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Products (" +
                "Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                "Name TEXT, " +
                "Type TEXT)";
            cmd.ExecuteNonQuery();
        }

        private static void InitializeTableProducts(SQLiteConnection connection)
        {
            using SQLiteCommand cmd = new(connection);

            cmd.CommandText = "INSERT INTO Products (Name, Type) " +
                "VALUES (@name, @type)";

            cmd.Parameters.AddWithValue("@name", "Fibra 1000 Adamo");
            cmd.Parameters.AddWithValue("@type", "ftth");
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", "Telefon fixe Mejorola");
            cmd.Parameters.AddWithValue("@type", "tf");
            cmd.ExecuteNonQuery();
        }

        private static void CreateTableSales(SQLiteConnection connection)
        {
            using SQLiteCommand cmd = new(connection);
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS Sales (" +
                "Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                "TerminalId INTEGER, " +
                "SoldAt DATETIME, " +
                "ProductId INTEGER, " +
                "CustomerId INTEGER)";
                // Client don’t mention price, maybe it’s a private data
            cmd.ExecuteNonQuery();
        }

        private static void InitializeTableSales(SQLiteConnection connection)
        {
            using SQLiteCommand cmd = new(connection);

            cmd.CommandText = "INSERT INTO Sales (TerminalId, SoldAt, ProductId, CustomerId) " +
                "VALUES (@terminalId, @soldAt, @productId, @customerId)";

            cmd.Parameters.AddWithValue("@terminalId", 3);
            cmd.Parameters.AddWithValue("@soldAt", new DateTime(2022,10,25));
            cmd.Parameters.AddWithValue("@productId", 1);
            cmd.Parameters.AddWithValue("@customerId", 1);
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@terminalId", 5);
            cmd.Parameters.AddWithValue("@soldAt", new DateTime(2023,03,20));
            cmd.Parameters.AddWithValue("@productId", 2);
            cmd.Parameters.AddWithValue("@customerId", 1);
            cmd.ExecuteNonQuery();
        }
    }
}