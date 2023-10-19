using System;
using System.ComponentModel.DataAnnotations;

namespace UPVTube.Entities
{
    public partial class Evaluation
    {
        public int Id { get; set; }

        public string RejectionReason { get; set; }

        public DateTime EvaluationDate { get; set; }

        [Required]
        public virtual Member Censor { get; set; }

        [Required]
        public virtual Content Content { get; set; }
    }
}

