namespace UPVTube.Entities

{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Visualization
    {
        public int Id { get; set; }

        public DateTime VisualizationDate { get; set; }

        [Required]
        public virtual Content Content { get; set; }

        [Required]
        public virtual Member Member { get; set; }
    }
}
