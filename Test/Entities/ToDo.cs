using System;

namespace MongoDB_Learning.Entities
{
    public class ToDo
    {
        public string Text { get; set; }
        public DateTime DeadLine { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Complete { get; set; }
    }
}
