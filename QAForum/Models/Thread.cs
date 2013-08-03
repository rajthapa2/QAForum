using System;

namespace QAForum.Models
{
    public class Thread
    {
        public int ThreadID { get; set; }
        public int ForumID { get; set; }
        public Guid OwnerID { get; set; }
        public string ThreadTitle { get; set; }
    }
}