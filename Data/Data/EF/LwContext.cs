using Microsoft.EntityFrameworkCore;

namespace Data.EF
{
    public partial class LwContext : DbContext
    {
        public LwContext()
        {
        }

        public LwContext(DbContextOptions<LwContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accounting>? Accountings { get; set; }
        public virtual DbSet<Transaction>? Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=Lw;user=root;password=0210564732", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.28-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Accounting>(entity =>
            {
                entity.ToTable("accounting");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address).HasColumnType("tinytext");

                entity.Property(e => e.Agreement).HasColumnType("tinytext");

                entity.Property(e => e.Institution).HasColumnType("tinytext");

                entity.Property(e => e.Payer).HasColumnType("tinytext");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.ToTable("transactions");

                entity.HasIndex(e => e.PayerId, "fk_trans_to_acc_idx");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Payer)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.PayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_trans_to_acc");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
