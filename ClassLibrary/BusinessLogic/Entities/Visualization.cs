using System;

namespace UPVTube.Entities
{
    public partial class Visualization
    {
        public Visualization() { }

        public Visualization(DateTime dateTime, Content content, Member member) : this()
        {
            this.VisualizationDate = dateTime;
            this.Content = content;
            this.Member = member;
        }
    }
}

