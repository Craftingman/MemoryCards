using MemoryCards.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MemoryCards.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {
        public DbSet<CardContent> CardContents { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardCollection> CardsCollections { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CardCollection>()
                .HasMany(c => c.Cards)
                .WithOne(c => c.CardCollection)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<CardCollection>().HasOne(c => c.Owner)
                .WithMany(u => u.CardCollections)
                .HasForeignKey(c => c.OwnerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<AppUser>().HasMany(u => u.CardCollections)
                .WithOne(c => c.Owner)
                .HasForeignKey(c => c.OwnerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Card>().HasMany(c => c.Contents)
                .WithOne(cc => cc.Card)
                .HasForeignKey(cc => cc.CardId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(builder);
        }
    }
}
