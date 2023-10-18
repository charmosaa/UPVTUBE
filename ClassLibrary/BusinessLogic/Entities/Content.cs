using System;
using System.Collections.Generic;

namespace UPVTube.Entities
{
    public partial class Content
    {

        public Content()
        {
            this.Comments = new List<Comment>();
            this.Visualizations = new List<Visualization>();
            this.Subjects = new List<Subject>();
        }

        public Content(string contentURI, string description, bool isPublic, string title, DateTime uploadDate, Member owner) : this()
        {
            this.Authorized = Domains.IsTeacherDomain(owner.Email) ? UPVTube.Entities.Authorized.Yes : UPVTube.Entities.Authorized.Pending;

            this.ContentURI = contentURI;
            this.Description = description;
            this.IsPublic = isPublic;
            this.Title = title;
            this.UploadDate = uploadDate;

            this.Owner = owner;
            this.Evaluation = null;

            this.Comments = new List<Comment>();
            this.Visualizations = new List<Visualization>();
            this.Subjects = new List<Subject>();
        }

    }
}

