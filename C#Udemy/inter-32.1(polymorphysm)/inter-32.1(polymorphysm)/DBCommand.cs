using System;

namespace inter_32._1_polymorphysm_
{
    public class DBCommand
    {
        private readonly string _instruction;
        private DBConnection _dbConnection;
       
        public DBCommand(string instruction, DBConnection dbConnection)
        {
            if (instruction != null && dbConnection != null)
            {
                _instruction = instruction;
                _dbConnection = dbConnection;
            }
            else
                Console.WriteLine("Invalid connection data");
        }
        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine($"Executing the command: \"{_instruction}\"");
            _dbConnection.Close();
        }
    }
}
