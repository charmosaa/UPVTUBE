using System;
using System.ComponentModel.DataAnnotations;

namespace UPVTube.Entities
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime WritingDate { get; set; }

        [Required]
        public virtual Member Writer { get; set; }

        [Required]
        public virtual Content Content { get; set; }
    }
}

