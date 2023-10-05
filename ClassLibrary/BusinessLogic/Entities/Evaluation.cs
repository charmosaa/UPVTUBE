using System;

namespace UpvTube.Entities
{
    public partial class Evaluation
    {
        public Evaluation() { }

        public Evaluation(DateTime evaluationDate, string rejectionReason, Member censor, Content content) : this()
        {
            this.EvaluationDate = evaluationDate;
            this.RejectionReason = rejectionReason;
            this.Censor = censor;
            this.Content = content;
        }
    }
}
