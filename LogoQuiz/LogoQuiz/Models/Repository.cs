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
                     //-Level 1
                     new Logo { Name = "Barbie", Hint = "***", ImageUrl = "barbie.jpg", Level = "Level 1" },
                     new Logo { Name = "Baskin Robbins", Hint = "***", ImageUrl = "baskin-robbins.jpg", Level = "Level 1" },
                     new Logo { Name = "Budget", Hint = "***", ImageUrl = "budget.jpg", Level = "Level 1" },
                     new Logo { Name = "Carlsberg", Hint = "***", ImageUrl = "carlsberg.jpg", Level = "Level 1" },
                     new Logo { Name = "Dunkin Donuts", Hint = "***", ImageUrl = "dunkin-donuts.jpg", Level = "Level 1" },
                     new Logo { Name = "Facebook", Hint = "***", ImageUrl = "facebook.jpg", Level = "Level 1" },
                     new Logo { Name = "Fedex", Hint = "***", ImageUrl = "fedex.jpg", Level = "Level 1" },
                     new Logo { Name = "Holiday inn", Hint = "***", ImageUrl = "holiday-inn.jpg", Level = "Level 1" },
                     new Logo { Name = "Jaguar", Hint = "***", ImageUrl = "jaguar.jpg", Level = "Level 1" },
                     new Logo { Name = "Kfc", Hint = "***", ImageUrl = "kfc.jpg", Level = "Level 1" },
                     new Logo { Name = "Knorr", Hint = "***", ImageUrl = "knorr.jpg", Level = "Level 1" },
                     new Logo { Name = "Lexus", Hint = "***", ImageUrl = "lexus.jpg", Level = "Level 1" },
                     new Logo { Name = "McDonalds", Hint = "***", ImageUrl = "mcdonalds.jpg", Level = "Level 1" },
                     new Logo { Name = "Pepsi", Hint = "***", ImageUrl = "pepsi.jpg", Level = "Level 1" },
                     new Logo { Name = "Playboy", Hint = "***", ImageUrl = "playboy.jpg", Level = "Level 1" },
                     new Logo { Name = "PlayStation", Hint = "***", ImageUrl = "playstation.jpg", Level = "Level 1" },
                     new Logo { Name = "Safeway", Hint = "***", ImageUrl = "safeway.jpg", Level = "Level 1" },
                     new Logo { Name = "The Body Shop", Hint = "***", ImageUrl = "the-body-shop.jpg", Level = "Level 1" },
                     new Logo { Name = "Visa", Hint = "***", ImageUrl = "visa.jpg", Level = "Level 1" },
                     new Logo { Name = "Yahoo", Hint = "***", ImageUrl = "yahoo.jpg", Level = "Level 1" },
                     //-Level 2
                     new Logo { Name = "20th Century Fox", Hint = "***", ImageUrl = "20th-century-fox.jpg", Level = "Level 2" },
                     new Logo { Name = "Absolut", Hint = "***", ImageUrl = "absolut.jpg", Level = "Level 2" },
                     new Logo { Name = "Adidas", Hint = "***", ImageUrl = "adidas.jpg", Level = "Level 2" },
                     new Logo { Name = "Amazon", Hint = "***", ImageUrl = "amazon.jpg", Level = "Level 2" },
                     new Logo { Name = "American Airlines", Hint = "***", ImageUrl = "american-airlines.jpg", Level = "Level 2" },
                     new Logo { Name = "Apple", Hint = "***", ImageUrl = "apple.jpg", Level = "Level 2" },
                     new Logo { Name = "Ariel", Hint = "***", ImageUrl = "ariel.jpg", Level = "Level 2" },
                     new Logo { Name = "Bank Of America", Hint = "***", ImageUrl = "bank-of-america.jpg", Level = "Level 2" },
                     new Logo { Name = "BBC", Hint = "***", ImageUrl = "bbc.jpg", Level = "Level 2" },
                     new Logo { Name = "Bluetooth", Hint = "***", ImageUrl = "bluetooth.jpg", Level = "Level 2" },
                     new Logo { Name = "Burger King", Hint = "***", ImageUrl = "burger-king.jpg", Level = "Level 2" },
                     new Logo { Name = "Crocs", Hint = "***", ImageUrl = "crocs.jpg", Level = "Level 2" },
                     new Logo { Name = "Diesel", Hint = "***", ImageUrl = "diesel.jpg", Level = "Level 2" },
                     new Logo { Name = "Ghostbusters", Hint = "***", ImageUrl = "ghostbusters.jpg", Level = "Level 2" },
                     new Logo { Name = "Glaxosmithklein", Hint = "***", ImageUrl = "glaxosmithklein.jpg", Level = "Level 2" },
                     new Logo { Name = "Kodak", Hint = "***", ImageUrl = "kodak.jpg", Level = "Level 2" },
                     new Logo { Name = "Lacoste", Hint = "***", ImageUrl = "lacoste.jpg", Level = "Level 2" },
                     new Logo { Name = "Milka", Hint = "***", ImageUrl = "milka.jpg", Level = "Level 2" },
                     new Logo { Name = "Nickelodeon", Hint = "***", ImageUrl = "nickelodeon.jpg", Level = "Level 2" },
                     new Logo { Name = "Nike", Hint = "***", ImageUrl = "nike.jpg", Level = "Level 2" },
                     //-Level 3
                     new Logo { Name = "Penguin", Hint = "***", ImageUrl = "penguin.jpg", Level = "Level 3" },
                     new Logo { Name = "Pringles", Hint = "***", ImageUrl = "pringles.jpg", Level = "Level 3" },
                     new Logo { Name = "Rolls Royce", Hint = "***", ImageUrl = "rolls-royce.jpg", Level = "Level 3" },
                     new Logo { Name = "Twitter", Hint = "***", ImageUrl = "twitter.jpg", Level = "Level 3" },
                     new Logo { Name = "Goodyear", Hint = "***", ImageUrl = "goodyear.jpg", Level = "Level 3" },
                     new Logo { Name = "Harry Potter", Hint = "***", ImageUrl = "harry-potter.jpg", Level = "Level 3" },
                     new Logo { Name = "Hello Kitty", Hint = "***", ImageUrl = "hello-kitty.jpg", Level = "Level 3" },
                     new Logo { Name = "HM", Hint = "***", ImageUrl = "hm.jpg", Level = "Level 3" },
                     new Logo { Name = "Honda", Hint = "***", ImageUrl = "honda.jpg", Level = "Level 3" },
                     new Logo { Name = "Nikon", Hint = "***", ImageUrl = "nikon.jpg", Level = "Level 3" },
                     new Logo { Name = "Pixar", Hint = "***", ImageUrl = "Pixar.jpg", Level = "Level 3" },
                     new Logo { Name = "Puma", Hint = "***", ImageUrl = "puma.jpg", Level = "Level 3" },
                     new Logo { Name = "Renault", Hint = "***", ImageUrl = "renault.jpg", Level = "Level 3" },
                     new Logo { Name = "Seat", Hint = "***", ImageUrl = "seat.jpg", Level = "Level 3" },
                     new Logo { Name = "Seven Eleven", Hint = "***", ImageUrl = "seven-eleven.jpg", Level = "Level 3" },
                     new Logo { Name = "Tag Heuer", Hint = "***", ImageUrl = "tag-heuer.jpg", Level = "Level 3" },
                     new Logo { Name = "Woolmark", Hint = "***", ImageUrl = "woolmark.jpg", Level = "Level 3" },
                     new Logo { Name = "Xbox", Hint = "***", ImageUrl = "xbox.jpg", Level = "Level 3" },
                     new Logo { Name = "Xerox", Hint = "***", ImageUrl = "xerox.jpg", Level = "Level 3" },
                     new Logo { Name = "Yellow Pages", Hint = "***", ImageUrl = "yellow-pages.jpg", Level = "Level 3" },
                     //-Level 4
                     new Logo { Name = "ACDC", Hint = "***", ImageUrl = "acdc.jpg", Level = "Level 4" },
                     new Logo { Name = "Benetton", Hint = "***", ImageUrl = "benetton.jpg", Level = "Level 4" },
                     new Logo { Name = "Budweiser", Hint = "***", ImageUrl = "budweiser.jpg", Level = "Level 4" },
                     new Logo { Name = "Cartoon Network", Hint = "***", ImageUrl = "cartoon-network.jpg", Level = "Level 4" },
                     new Logo { Name = "Cheerios", Hint = "***", ImageUrl = "cheerios.jpg", Level = "Level 4" },
                     new Logo { Name = "Discovery", Hint = "***", ImageUrl = "discovery.jpg", Level = "Level 4" },
                     new Logo { Name = "Dove", Hint = "***", ImageUrl = "dove.jpg", Level = "Level 4" },
                     new Logo { Name = "Durex", Hint = "***", ImageUrl = "durex.jpg", Level = "Level 4" },
                     new Logo { Name = "Fisherprice", Hint = "***", ImageUrl = "fisherprice.jpg", Level = "Level 4" },
                     new Logo { Name = "Fosters", Hint = "***", ImageUrl = "fosters.jpg", Level = "Level 4" },
                     new Logo { Name = "Illy", Hint = "***", ImageUrl = "illy.jpg", Level = "Level 4" },
                     new Logo { Name = "John Deere", Hint = "***", ImageUrl = "john-deere.jpg", Level = "Level 4" },
                     new Logo { Name = "Kia", Hint = "***", ImageUrl = "kia.jpg", Level = "Level 4" },
                     new Logo { Name = "Kleenex", Hint = "***", ImageUrl = "kleenex.jpg", Level = "Level 4" },
                     new Logo { Name = "Kraft", Hint = "***", ImageUrl = "kraft.jpg", Level = "Level 4" },
                     new Logo { Name = "Land Rover", Hint = "***", ImageUrl = "land-rover.jpg", Level = "Level 4" },
                     new Logo { Name = "Linkedin", Hint = "***", ImageUrl = "linkedin.jpg", Level = "Level 4" },
                     new Logo { Name = "Malibu", Hint = "***", ImageUrl = "malibu.jpg", Level = "Level 4" },
                     new Logo { Name = "Umbro", Hint = "***", ImageUrl = "umbro.jpg", Level = "Level 4" },
                     new Logo { Name = "Wifi", Hint = "***", ImageUrl = "wifi.jpg", Level = "Level 4" },
                     //-Level 5
                     new Logo { Name = "Air Jordan", Hint = "***", ImageUrl = "air-jordan.jpg", Level = "Level 5" },
                     new Logo { Name = "Android", Hint = "***", ImageUrl = "android.jpg", Level = "Level 5" },
                     new Logo { Name = "Asus", Hint = "***", ImageUrl = "asus.jpg", Level = "Level 5" },
                     new Logo { Name = "Atari", Hint = "***", ImageUrl = "atari.jpg", Level = "Level 5" },
                     new Logo { Name = "Avery", Hint = "***", ImageUrl = "avery.jpg", Level = "Level 5" },
                     new Logo { Name = "Chiquita", Hint = "***", ImageUrl = "chiquita.jpg", Level = "Level 5" },
                     new Logo { Name = "Chupa Chups", Hint = "***", ImageUrl = "chupa-chups.jpg", Level = "Level 5" },
                     new Logo { Name = "Delta", Hint = "***", ImageUrl = "delta.jpg", Level = "Level 5" },
                     new Logo { Name = "Fiat", Hint = "***", ImageUrl = "fiat.jpg", Level = "Level 5" },
                     new Logo { Name = "Fsc", Hint = "***", ImageUrl = "fsc.jpg", Level = "Level 5" },
                     new Logo { Name = "Lays", Hint = "***", ImageUrl = "lays.jpg", Level = "Level 5" },
                     new Logo { Name = "Nespresso", Hint = "***", ImageUrl = "nespresso.jpg", Level = "Level 5" },
                     new Logo { Name = "Nestle", Hint = "***", ImageUrl = "nestle.jpg", Level = "Level 5" },
                     new Logo { Name = "Nivea", Hint = "***", ImageUrl = "nivea.jpg", Level = "Level 5" },
                     new Logo { Name = "Pampers", Hint = "***", ImageUrl = "pampers.jpg", Level = "Level 5" },
                     new Logo { Name = "Sheraton", Hint = "***", ImageUrl = "sheraton.jpg", Level = "Level 5" },
                     new Logo { Name = "Showtime", Hint = "***", ImageUrl = "showtime.jpg", Level = "Level 5" },
                     new Logo { Name = "Target", Hint = "***", ImageUrl = "target.jpg", Level = "Level 5" },
                     new Logo { Name = "Tictac", Hint = "***", ImageUrl = "tictac.jpg", Level = "Level 5" },
                     new Logo { Name = "Total", Hint = "***", ImageUrl = "total.jpg", Level = "Level 5" }
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

        public void Save()
        {
            SaveChanges();
        }
    }
}
