using LogoQuiz.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LogoQuiz.Models
{
    public class Repository : DbContext, IRepository<Logo>
    {
        public DbSet<Logo> Logos { get; set; }
        string _dbPath;
        public Repository()
        {

        }
        public Repository(string dbPath) : base()
        {
            _dbPath = dbPath;
            Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Logo>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Logo>()
                 .HasData(
                     new Logo { Name = "Apple", Hint = "A*p***", ImageUrl = "APPLE.png", Level = "Level 1" },
                     new Logo { Name = "Facebook", Hint = "Fa*e**o*", ImageUrl = "FACEBOOK.png", Level = "Level 1" },
                     new Logo { Name = "Google Chrome", Hint = "G**gl* C***me", ImageUrl = "GOOGLECHROME.png", Level = "Level 2" },
                     new Logo { Name = "Huawei", Hint = "H****i", ImageUrl = "HUAWEI.png", Level = "Level 1" },
                     new Logo { Name = "Instagram", Hint = "I***ag**m", ImageUrl = "INSTAGRAM.png", Level = "Level 1" },
                     new Logo { Name = "Mercedes", Hint = "M***e**s", ImageUrl = "MERCEDES.png", Level = "Level 1" },
                     new Logo { Name = "Samsung", Hint = "*a***ng", ImageUrl = "SAMSUNG.png", Level = "Level 2" },
                     new Logo { Name = "Skype", Hint = "Sk**e", ImageUrl = "SKYPE.png", Level = "Level 2" },
                     new Logo { Name = "Twitter", Hint = "*****er", ImageUrl = "TWITTER.png", Level = "Level 2" },
                     new Logo { Name = "YouTube", Hint = "Y*u*T***", ImageUrl = "YOUTUBE.png", Level = "Level 2" },
                     new Logo { Name = "BMW", Hint = "BMW", ImageUrl = "BMW.jpg", Level = "Level 1" }
                 );
        }

        public async Task<IEnumerable<Logo>> GetLogosAsync(bool forceRefresh = false)
        {
            var allLogos = await Logos.ToListAsync();
            return allLogos;
        }

        public async Task<Logo> GetLogoAsync(string id)
        {
            var logo = await Logos.FirstOrDefaultAsync(x => x.Id == id);
            return logo;
        }
    }
}
