namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TruyenOnlineDbContext : DbContext
    {
        public TruyenOnlineDbContext()
            : base("name=TruyenOnline")
        {
        }

        public virtual DbSet<AnhHungXaDieu> AnhHungXaDieu { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnhHungXaDieu>()
                .Property(e => e.ChapName)
                .IsUnicode(false);
        }
    }
}
