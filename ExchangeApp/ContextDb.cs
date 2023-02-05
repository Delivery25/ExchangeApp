using Microsoft.EntityFrameworkCore;

namespace ExchangeApp;

public partial class ContextDb : DbContext
{
    public ContextDb()
    {
        Database.EnsureCreated();
    }

    public virtual DbSet<FavoriteValute> Favorites { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=ExchangeDatabase.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FavoriteValute>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.HasIndex(e => e.Code, "IX_Favorites_Code").IsUnique();

            entity.Property(e => e.Code).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}