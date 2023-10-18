using System.Collections.Generic;

namespace UPVTube.Entities
{
	public partial class Subject
	{
        public Subject()
        {
            this.Contents = new List<Content>();
        }

        public Subject(int code, string fullName, string name) : this()
        {
            this.Code = code;
            this.FullName = fullName;
            this.Name = name;

            this.Contents = new List<Content>();
        }

    }
}

