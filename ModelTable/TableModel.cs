namespace ModelTable
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TableModel : DbContext
    {
        public TableModel()
            : base("name=TableModel")
        {
        }

        public virtual DbSet<UserTable> UserTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTable>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<UserTable>()
                .Property(e => e.Passward)
                .IsUnicode(false);
        }
    }
}
