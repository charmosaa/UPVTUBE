﻿using System;
using System.Collections.Generic;

namespace UPVTube.Entities
{
	public partial class Member
	{
		public Member()
		{
			Comments = new List<Comment>();
			Contents = new List<Content>();
			Evaluations = new List<Evaluation>();
			SubscribedTo = new List<Member>();
            Subscriptors = new List<Member>();
            Visualizations = new List<Visualization>();
		}

		public Member(string email, string fullName, DateTime lastAccessDate, string nick, string password) : this()
		{
			this.Email = email;
			this.FullName = fullName;
			this.LastAccessDate = lastAccessDate;
			this.Nick = nick;
			this.Password = password;
		}

        public void AddContent(Content c)
        {
            this.Contents.Add(c);
        }
    }
}

