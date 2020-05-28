using System;

namespace inter_ex16._2
{
    public class Post
    {
        public Post(DateTime madeDataTime)
        {
            MadeDataTime = madeDataTime;
        }
        public string Title { get; set; }
        public string Discription { get; set; }
        public DateTime MadeDataTime { get; private  set; }

        private int _votationResult = 0;
        public void SetVoting(int vote)
        {
            _votationResult += vote;
        }
        public int GetVoting()
        {
            return (_votationResult);
        }
    }
}
