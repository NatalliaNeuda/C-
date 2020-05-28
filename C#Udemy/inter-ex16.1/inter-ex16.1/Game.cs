using System;


namespace inter_ex16._1
{
    partial class Program
    {
        public class Game
        {
            public DateTime _start;
            public DateTime _stop;
            public TimeSpan _duration;
            public int _status = 0;
            public void SetStart()
            {
                _start = DateTime.Now;
                _status = 1;
            }
            public DateTime GetStart()
            {
                return (_start);
            }
            public void SetStop()
            {
                _stop = DateTime.Now;
                _status = 2;
            }
            public DateTime GetStop()
            {
                return (_stop);
            }
            public TimeSpan TimeSpawner()
            {
                _duration = _stop - _start;
                return _duration;
            }

        }
    }
}
