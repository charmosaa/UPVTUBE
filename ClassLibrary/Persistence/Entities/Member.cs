using System;
using System.Collections.Generic;

namespace UpvTube.Entities
{
	public partial class Member
	{
        #region ATTRIBUTES

        public string Email { get; set; }
        
        public string FullName { get; set; }
        
        public DateTime LastAccessDate { get; set; }

        public string Nick { get; set; }

        public string Password { get; set; }

        #endregion


        #region RELATIONSHIPS

        public virtual List<Comment> Comments { get; set; }

        public virtual List<Content> Contents { get; set; }

        public virtual List<Evaluation> Evaluations { get; set; }

        public virtual List<Member> SubscribedTo { get; set; }

        public virtual List<Visualization> Visualizations { get; set; }

        #endregion
    }
}

