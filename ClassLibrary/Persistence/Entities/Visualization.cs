﻿namespace UPVTube.Entities

{
    using System;
    public partial class Visualization
    {
        public DateTime VisualizationDate
        {
            get;
            set;
        }

        public virtual Content Content
        {
            get;
            set;
        }

        public virtual Member Member
        {
            get;
            set;
        }
    }
}

