using System;
using System.Threading;

namespace AdvancedExercises
{
    public abstract class DbConnection
    {
        protected string connectionString;
        protected TimeSpan timeout;

        public DbConnection(string connectionString, TimeSpan timeout)
        {
            if (connectionString == null)
            {
                throw new InvalidOperationException("Invalid connection string");
            }
            else if (connectionString == "")
            {
                throw new InvalidOperationException("Invalid connection string");
            }
            this.connectionString = connectionString;
            this.timeout = timeout;
        }

        public abstract void Open();
        public abstract void Close();
    }

    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString, TimeSpan timeout)
            : base(connectionString, timeout)
        {
        }

        public override void Open()
        {
            var startTime = DateTime.Now;
            Thread.Sleep(2000);
            var endTime = DateTime.Now;
            var diffs = endTime - startTime;
            if (diffs.TotalSeconds <= timeout.TotalSeconds)
            {
                Console.WriteLine("Connected to SQL Server");
            }
            else
            {
                throw new InvalidOperationException("Unable to connect to the SQL Server within timeout.");
            }
        }

        public override void Close()
        {
            Console.WriteLine("SQL Connection Closed.");
        }
    }

    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString, TimeSpan timeout)
            : base(connectionString, timeout)
        {
        }

        public override void Open()
        {
            var startTime = DateTime.Now;
            Thread.Sleep(2000);
            var endTime = DateTime.Now;
            var diffs = endTime - startTime;
            if (diffs.TotalSeconds <= timeout.TotalSeconds)
            {
                Console.WriteLine("Connected to Oracle Server");
            }
            else
            {
                throw new InvalidOperationException("Unable to connect to the Oracle Server within timeout.");
            }
        }

        public override void Close()
        {
            Console.WriteLine("Oracle Connection Closed.");
        }
    }
    public class DbCommand
    {
        protected DbConnection dbConnection;
        public DbCommand(DbConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }
        public void SendInstruction()
        {
            Console.WriteLine("Sent instruction to: " + dbConnection);
        }

    }
    class MainProgram
    {
        static void Main(string[] args)
        {

            TimeSpan timeout1 = TimeSpan.FromSeconds(1);
            try
            {

                var connection1 = new SqlConnection("Server=myServer;Database=myDb;", timeout1);
                connection1.Open();

                connection1.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Timeout expired");
            }
            try
            {
                var connection2 = new OracleConnection("Data Source=OracleDB;", timeout1);
                connection2.Open();
                connection2.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Timeout expired");
            }

            TimeSpan timeout2 = TimeSpan.FromSeconds(10);
            var connection3 = new SqlConnection("Server=myServer;Database=myDb;", timeout2);
            connection3.Open();
            var dbCommand1 = new DbCommand(connection3);
            dbCommand1.SendInstruction();
            connection3.Close();

            var connection4 = new OracleConnection("Data Source=OracleDB;", timeout2);
            connection4.Open();
            var dbCommand2 = new DbCommand(connection4);
            dbCommand2.SendInstruction();
            connection4.Close();


        }
    }
}
