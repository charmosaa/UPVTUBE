using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UPVTube.Entities
{
	public partial class Subject
	{

        #region ATTRIBUTES

        public int Code { get; set; }

        public string FullName { get; set; }

        public string Name { get; set; }

        #endregion

        #region RELATIONSHIPS

        public virtual ICollection<Content> Contents { get; set; }

        #endregion
    }
}

