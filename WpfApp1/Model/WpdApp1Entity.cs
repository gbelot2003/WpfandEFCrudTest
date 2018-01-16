namespace WpfApp1.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WpdApp1Entity : DbContext
    {
        public WpdApp1Entity() : base("name=WpdApp1Entity")
        {
        }

        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artis> Artises { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
