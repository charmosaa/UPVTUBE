using System.Collections.Generic;

namespace UpvTube.Entities
{
	public partial class Subject
	{
		public int Code
		{
			get;
			set;
		}

		public virtual List<Content> Contents
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

