using System;
using System.Collections.Generic;
using UPVTube.Entities;

namespace UpvTube.Entities
{
	public partial class Content
	{

		public Authorized Authorized
		{
			get;
			set;
		}

		public string ContentURI
		{
			get;
			set;
		}

		public string Description
		{
			get;
			set;
		}

		public int Id
		{
			get;
			set;
		}

		public bool IsPublic
		{
			get;
			set;
		}

		public virtual Member Owner
		{
			get;
			set;
		}

		public string Title
		{
			get;
			set;
		}

		public DateTime UploadDate
		{
			get;
			set;
		}

		public virtual List<Subject> Subjects
		{
			get;
			set;
		}
	}
}

