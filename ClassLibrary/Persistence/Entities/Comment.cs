using System;

namespace UPVTube.Entities
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime WritingDate { get; set; }
        public virtual Member Writer { get; set; }
        public virtual Content Content { get; set; }
    }
}

