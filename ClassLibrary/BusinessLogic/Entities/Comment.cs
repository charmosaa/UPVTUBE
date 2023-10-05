using System;

namespace UpvTube.Entities
{
    public partial class Comment
    {
        public Comment(string Text, DateTime WritingDate, Content Content, Member Writer)
        {
            this.Text = Text;
            this.WritingDate = WritingDate;
            this.Content = Content;
            this.Writer = Writer;
        }
    }
}

