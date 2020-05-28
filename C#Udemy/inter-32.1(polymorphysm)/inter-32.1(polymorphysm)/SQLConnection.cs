using System;

namespace inter_32._1_polymorphysm_
{
    public class SQLConnection : DBConnection
    {
        public SQLConnection(string connection, DateTime timeSpan) : base(connection, timeSpan)
        {
        }

        public override void Open() 
        {
            Console.WriteLine("Connection SQL is open");
        }

        public override void Close()
        {
            Console.WriteLine("Connection SQL is closed\nRunning time is : {0}", TimeSpan);
        }
    }
}