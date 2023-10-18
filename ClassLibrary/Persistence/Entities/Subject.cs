using System.Collections.Generic;

namespace UPVTube.Entities
{
	public partial class Subject
	{
		public int Code
		{
			get;
			set;
		}

		public virtual ICollection<Content> Contents
		{
			get;
			set;
		}

		public string FullName
		{
			get;
			set;
		}

        public string Name
        {
            get;
            set;
        }
    }
}

