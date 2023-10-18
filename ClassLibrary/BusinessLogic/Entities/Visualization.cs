using System;

namespace UPVTube.Entities
{
    public partial class Visualization
    {
        public Visualization() { }

        public Visualization(DateTime dateTime, Content content, Member member) : this()
        {
            this.VisualizationTime = dateTime;
            this.Content = content;
            this.Member = member;
        }
    }
}

