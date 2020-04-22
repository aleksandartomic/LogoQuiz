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

            Database.EnsureCreated();
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
                     new Logo { Name = "Apple", Hint = "A*p***", ImageUrl = "APPLE.png" },
                     new Logo { Name = "Facebook", Hint = "Fa*e**o*", ImageUrl = "FACEBOOK.png" },
                     new Logo { Name = "Google Chrome", Hint = "G**gl* C***me", ImageUrl = "GOOGLECHROME.png" },
                     new Logo { Name = "Huawei", Hint = "H****i", ImageUrl = "HUAWEI.png" },
                     new Logo { Name = "Instagram", Hint = "I***ag**m", ImageUrl = "INSTAGRAM.png" },
                     new Logo { Name = "Mercedes", Hint = "M***e**s", ImageUrl = "MERCEDES.png" },
                     new Logo { Name = "Samsung", Hint = "*a***ng", ImageUrl = "SAMSUNG.png" },
                     new Logo { Name = "Skype", Hint = "Sk**e", ImageUrl = "SKYPE.png" },
                     new Logo { Name = "Twitter", Hint = "*****er", ImageUrl = "TWITTER.png" },
                     new Logo { Name = "YouTube", Hint = "Y*u*T***", ImageUrl = "YOUTUBE.png" },
                     new Logo { Name = "BMW", Hint = "BMW", ImageUrl = "BMW.jpg" }
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
