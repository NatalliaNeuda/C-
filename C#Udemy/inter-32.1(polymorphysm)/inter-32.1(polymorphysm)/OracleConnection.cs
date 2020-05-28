using System;

namespace inter_32._1_polymorphysm_
{
    public class OracleConnection : DBConnection
    {
        public OracleConnection(string connection, DateTime timeSpan) : base(connection, timeSpan)
        {
        }


        public override void Open()
        {
            Console.WriteLine("Connection Oracle is open");
        }

        public override void Close()
        {
            
            Console.WriteLine("Connection Oracle is closed\nRunning time is : {0}", TimeSpan);
        }
        
    }
}