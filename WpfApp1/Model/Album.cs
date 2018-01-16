namespace WpfApp1.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Album
    {
        [Key] public int AlmbumId { get; set; }

        [Required()]
        [StringLength(100, MinimumLength = 2)]
        public string Title { get; set; }

        public decimal Price { get; set; }

        public int ArtistID { get; set; }

        public virtual Artis Artist { get; set; }
    }
}
