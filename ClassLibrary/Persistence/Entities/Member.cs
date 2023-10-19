using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UPVTube.Entities
{
	public partial class Member
	{
        #region ATTRIBUTES

        [Required]
        public string Email { get; set; }
        
        public string FullName { get; set; }
        
        public DateTime LastAccessDate { get; set; }

        [Key]
        public string Nick { get; set; }

        [Required]
        public string Password { get; set; }

        #endregion


        #region RELATIONSHIPS

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Content> Contents { get; set; }

        public virtual ICollection<Evaluation> Evaluations { get; set; }

        public virtual ICollection<Member> SubscribedTo { get; set; }
        public virtual ICollection<Member> Subscriptors { get; set; }

        public virtual ICollection<Visualization> Visualizations { get; set; }

        #endregion
    }
}

