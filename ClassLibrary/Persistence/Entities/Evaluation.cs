using System;

namespace UPVTube.Entities
{
	public partial class Evaluation
	{
		public int Id { get; set; }
		public string RejectionReason { get; set; }
		public DateTime EvaluationDate { get; set; }
		public virtual Member Censor { get; set; }
		public virtual Content Content { get; set; }
	
	}
}

