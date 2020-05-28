using System;

namespace inter_32._1_polymorphysm_
{
    public abstract class DBConnection
    {
        private string Connection;
        public TimeSpan TimeSpan;
        private DateTime timeSpan;

        protected DBConnection(string connection, DateTime timeSpan )
        {
            if (connection != null)
                Connection = connection;
            else
                Console.WriteLine("Invalid connection API");
            TimeSpan = DateTime.Now - timeSpan;

        }

        /*protected DBConnection(string connection, DateTime timeSpan)
        {
            Connection = connection;
            this.timeSpan = timeSpan;
        }*/

        public abstract void Open();
        public abstract void Close();
    }
}
