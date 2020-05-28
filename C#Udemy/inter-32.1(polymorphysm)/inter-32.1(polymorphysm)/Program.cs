using System;

namespace inter_32._1_polymorphysm_
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLConnection sqlConnection;
            OracleConnection oracleConnection;
            DBCommand dbCommand;
            while (true)
            {
                Console.WriteLine("Sql or Oracle");
                Console.WriteLine("E for Exit.");
                Console.WriteLine("Enter Connection String:");
                string connectionString = Console.ReadLine();
                if (connectionString.ToLower() == "e")
                {
                    Console.WriteLine("Exiting");
                    break;
                }
                Console.WriteLine("Enter Command");
                string command = Console.ReadLine();

                if (connectionString.ToLower().Contains("sql"))
                {
                    sqlConnection = new SQLConnection(connectionString, DateTime.Now);
                    dbCommand = new DBCommand(command, sqlConnection);
                    dbCommand.Execute();
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                else if (connectionString.ToLower().Contains("oracle"))
                {
                    oracleConnection = new OracleConnection(connectionString, DateTime.Now);
                    dbCommand = new DBCommand(command, oracleConnection);
                    dbCommand.Execute();
                    
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                else
                    Console.WriteLine("please use only 'oracle', 'sql' or 'e'");
            }
        }
    }
}
