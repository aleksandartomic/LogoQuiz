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
                     new Logo { Name = "Barbie", ImageUrl = "barbie.jpg", Level = "Level 1" },
                     new Logo { Name = "Baskin Robbins", ImageUrl = "baskin-robbins.jpg", Level = "Level 1" },
                     new Logo { Name = "Budget", ImageUrl = "budget.jpg", Level = "Level 1" },
                     new Logo { Name = "Carlsberg", ImageUrl = "carlsberg.jpg", Level = "Level 1" },
                     new Logo { Name = "Dunkin Donuts", ImageUrl = "dunkin-donuts.jpg", Level = "Level 1" },
                     new Logo { Name = "Facebook", ImageUrl = "facebook.jpg", Level = "Level 1" },
                     new Logo { Name = "Fedex", ImageUrl = "fedex.jpg", Level = "Level 1" },
                     new Logo { Name = "Holiday inn", ImageUrl = "holiday-inn.jpg", Level = "Level 1" },
                     new Logo { Name = "Jaguar", ImageUrl = "jaguar.jpg", Level = "Level 1" },
                     new Logo { Name = "Kfc", ImageUrl = "kfc.jpg", Level = "Level 1" },
                     new Logo { Name = "Knorr", ImageUrl = "knorr.jpg", Level = "Level 1" },
                     new Logo { Name = "Lexus", ImageUrl = "lexus.jpg", Level = "Level 1" },
                     new Logo { Name = "McDonalds", ImageUrl = "mcdonalds.jpg", Level = "Level 1" },
                     new Logo { Name = "Pepsi", ImageUrl = "pepsi.jpg", Level = "Level 1" },
                     new Logo { Name = "Playboy", ImageUrl = "playboy.jpg", Level = "Level 1" },
                     new Logo { Name = "PlayStation", ImageUrl = "playstation.jpg", Level = "Level 1" },
                     new Logo { Name = "Safeway", ImageUrl = "safeway.jpg", Level = "Level 1" },
                     new Logo { Name = "The Body Shop", ImageUrl = "the-body-shop.jpg", Level = "Level 1" },
                     new Logo { Name = "Visa", ImageUrl = "visa.jpg", Level = "Level 1" },
                     new Logo { Name = "Yahoo", ImageUrl = "yahoo.jpg", Level = "Level 1" },
                     //-Level 2
                     new Logo { Name = "20th Century Fox", ImageUrl = "20th-century-fox.jpg", Level = "Level 2" },
                     new Logo { Name = "Absolut", ImageUrl = "absolut.jpg", Level = "Level 2" },
                     new Logo { Name = "Adidas", ImageUrl = "adidas.jpg", Level = "Level 2" },
                     new Logo { Name = "Amazon", ImageUrl = "amazon.jpg", Level = "Level 2" },
                     new Logo { Name = "American Airlines", ImageUrl = "american-airlines.jpg", Level = "Level 2" },
                     new Logo { Name = "Apple", ImageUrl = "apple.jpg", Level = "Level 2" },
                     new Logo { Name = "Ariel", ImageUrl = "ariel.jpg", Level = "Level 2" },
                     new Logo { Name = "Bank Of America", ImageUrl = "bank-of-america.jpg", Level = "Level 2" },
                     new Logo { Name = "BBC", ImageUrl = "bbc.jpg", Level = "Level 2" },
                     new Logo { Name = "Bluetooth", ImageUrl = "bluetooth.jpg", Level = "Level 2" },
                     new Logo { Name = "Burger King", ImageUrl = "burger-king.jpg", Level = "Level 2" },
                     new Logo { Name = "Crocs", ImageUrl = "crocs.jpg", Level = "Level 2" },
                     new Logo { Name = "Diesel", ImageUrl = "diesel.jpg", Level = "Level 2" },
                     new Logo { Name = "Ghostbusters", ImageUrl = "ghostbusters.jpg", Level = "Level 2" },
                     new Logo { Name = "Glaxosmithklein", ImageUrl = "glaxosmithklein.jpg", Level = "Level 2" },
                     new Logo { Name = "Kodak", ImageUrl = "kodak.jpg", Level = "Level 2" },
                     new Logo { Name = "Lacoste", ImageUrl = "lacoste.jpg", Level = "Level 2" },
                     new Logo { Name = "Milka", ImageUrl = "milka.jpg", Level = "Level 2" },
                     new Logo { Name = "Nickelodeon", ImageUrl = "nickelodeon.jpg", Level = "Level 2" },
                     new Logo { Name = "Nike", ImageUrl = "nike.jpg", Level = "Level 2" },
                     //-Level 3
                     new Logo { Name = "Penguin", ImageUrl = "penguin.jpg", Level = "Level 3" },
                     new Logo { Name = "Pringles", ImageUrl = "pringles.jpg", Level = "Level 3" },
                     new Logo { Name = "Rolls Royce", ImageUrl = "rolls-royce.jpg", Level = "Level 3" },
                     new Logo { Name = "Twitter", ImageUrl = "twitter.jpg", Level = "Level 3" },
                     new Logo { Name = "Goodyear", ImageUrl = "goodyear.jpg", Level = "Level 3" },
                     new Logo { Name = "Harry Potter", ImageUrl = "harry-potter.jpg", Level = "Level 3" },
                     new Logo { Name = "Hello Kitty", ImageUrl = "hello-kitty.jpg", Level = "Level 3" },
                     new Logo { Name = "HM", ImageUrl = "hm.jpg", Level = "Level 3" },
                     new Logo { Name = "Honda", ImageUrl = "honda.jpg", Level = "Level 3" },
                     new Logo { Name = "Nikon", ImageUrl = "nikon.jpg", Level = "Level 3" },
                     new Logo { Name = "Pixar", ImageUrl = "pixar.jpg", Level = "Level 3" },
                     new Logo { Name = "Puma", ImageUrl = "puma.jpg", Level = "Level 3" },
                     new Logo { Name = "Renault", ImageUrl = "renault.jpg", Level = "Level 3" },
                     new Logo { Name = "Seat", ImageUrl = "seat.jpg", Level = "Level 3" },
                     new Logo { Name = "Seven Eleven", ImageUrl = "seven-eleven.jpg", Level = "Level 3" },
                     new Logo { Name = "Tag Heuer", ImageUrl = "tag-heuer.jpg", Level = "Level 3" },
                     new Logo { Name = "Woolmark", ImageUrl = "woolmark.jpg", Level = "Level 3" },
                     new Logo { Name = "Xbox", ImageUrl = "xbox.jpg", Level = "Level 3" },
                     new Logo { Name = "Xerox", ImageUrl = "xerox.jpg", Level = "Level 3" },
                     new Logo { Name = "Yellow Pages", ImageUrl = "yellow-pages.jpg", Level = "Level 3" },
                     //-Level 4
                     new Logo { Name = "ACDC", ImageUrl = "acdc.jpg", Level = "Level 4" },
                     new Logo { Name = "Benetton", ImageUrl = "benetton.jpg", Level = "Level 4" },
                     new Logo { Name = "Budweiser", ImageUrl = "budweiser.jpg", Level = "Level 4" },
                     new Logo { Name = "Cartoon Network", ImageUrl = "cartoon-network.jpg", Level = "Level 4" },
                     new Logo { Name = "Cheerios", ImageUrl = "cheerios.jpg", Level = "Level 4" },
                     new Logo { Name = "Discovery", ImageUrl = "discovery.jpg", Level = "Level 4" },
                     new Logo { Name = "Dove", ImageUrl = "dove.jpg", Level = "Level 4" },
                     new Logo { Name = "Durex", ImageUrl = "durex.jpg", Level = "Level 4" },
                     new Logo { Name = "Fisherprice", ImageUrl = "fisherprice.jpg", Level = "Level 4" },
                     new Logo { Name = "Fosters", ImageUrl = "fosters.jpg", Level = "Level 4" },
                     new Logo { Name = "Illy", ImageUrl = "illy.jpg", Level = "Level 4" },
                     new Logo { Name = "John Deere", ImageUrl = "john-deere.jpg", Level = "Level 4" },
                     new Logo { Name = "Kia", ImageUrl = "kia.jpg", Level = "Level 4" },
                     new Logo { Name = "Kleenex", ImageUrl = "kleenex.jpg", Level = "Level 4" },
                     new Logo { Name = "Kraft", ImageUrl = "kraft.jpg", Level = "Level 4" },
                     new Logo { Name = "Land Rover", ImageUrl = "land-rover.jpg", Level = "Level 4" },
                     new Logo { Name = "Linkedin", ImageUrl = "linkedin.jpg", Level = "Level 4" },
                     new Logo { Name = "Malibu", ImageUrl = "malibu.jpg", Level = "Level 4" },
                     new Logo { Name = "Umbro", ImageUrl = "umbro.jpg", Level = "Level 4" },
                     new Logo { Name = "Wifi", ImageUrl = "wifi.jpg", Level = "Level 4" },
                     //-Level 5
                     new Logo { Name = "Air Jordan", ImageUrl = "air-jordan.jpg", Level = "Level 5" },
                     new Logo { Name = "Android", ImageUrl = "android.jpg", Level = "Level 5" },
                     new Logo { Name = "Asus", ImageUrl = "asus.jpg", Level = "Level 5" },
                     new Logo { Name = "Atari", ImageUrl = "atari.jpg", Level = "Level 5" },
                     new Logo { Name = "Avery", ImageUrl = "avery.jpg", Level = "Level 5" },
                     new Logo { Name = "Chiquita", ImageUrl = "chiquita.jpg", Level = "Level 5" },
                     new Logo { Name = "Chupa Chups", ImageUrl = "chupa-chups.jpg", Level = "Level 5" },
                     new Logo { Name = "Delta", ImageUrl = "delta.jpg", Level = "Level 5" },
                     new Logo { Name = "Fiat", ImageUrl = "fiat.jpg", Level = "Level 5" },
                     new Logo { Name = "Fsc", ImageUrl = "fsc.jpg", Level = "Level 5" },
                     new Logo { Name = "Lays", ImageUrl = "lays.jpg", Level = "Level 5" },
                     new Logo { Name = "Nespresso", ImageUrl = "nespresso.jpg", Level = "Level 5" },
                     new Logo { Name = "Nestle", ImageUrl = "nestle.jpg", Level = "Level 5" },
                     new Logo { Name = "Nivea", ImageUrl = "nivea.jpg", Level = "Level 5" },
                     new Logo { Name = "Pampers", ImageUrl = "pampers.jpg", Level = "Level 5" },
                     new Logo { Name = "Sheraton", ImageUrl = "sheraton.jpg", Level = "Level 5" },
                     new Logo { Name = "Showtime", ImageUrl = "showtime.jpg", Level = "Level 5" },
                     new Logo { Name = "Target", ImageUrl = "target.jpg", Level = "Level 5" },
                     new Logo { Name = "Tictac", ImageUrl = "tictac.jpg", Level = "Level 5" },
                     new Logo { Name = "Total", ImageUrl = "total.jpg", Level = "Level 5" },
                     //-Level 6
                     new Logo { Name = "Bridgestone", ImageUrl = "bridgestone.jpg", Level = "Level 6" },
                     new Logo { Name = "Champion", ImageUrl = "champion.jpg", Level = "Level 6" },
                     new Logo { Name = "Compaq", ImageUrl = "compaq.jpg", Level = "Level 6" },
                     new Logo { Name = "Corona", ImageUrl = "corona.jpg", Level = "Level 6" },
                     new Logo { Name = "Dreamworks", ImageUrl = "dreamworks.jpg", Level = "Level 6" },
                     new Logo { Name = "Fishermans Friend", ImageUrl = "fishermans-friend.jpg", Level = "Level 6" },
                     new Logo { Name = "Fred Perry", ImageUrl = "fred-perry.jpg", Level = "Level 6" },
                     new Logo { Name = "Girl Scouts Of America", ImageUrl = "girl-scouts-of-america.jpg", Level = "Level 6" },
                     new Logo { Name = "Infiniti", ImageUrl = "infiniti.jpg", Level = "Level 6" },
                     new Logo { Name = "Maggi", ImageUrl = "maggi.jpg", Level = "Level 6" },
                     new Logo { Name = "Mastercard", ImageUrl = "mastercard.jpg", Level = "Level 6" },
                     new Logo { Name = "Mozilla", ImageUrl = "mozilla.jpg", Level = "Level 6" },
                     new Logo { Name = "OralB", ImageUrl = "oralb.jpg", Level = "Level 6" },
                     new Logo { Name = "QuickTime", ImageUrl = "quicktime.jpg", Level = "Level 6" },
                     new Logo { Name = "Roland Garros", ImageUrl = "roland-garros.jpg", Level = "Level 6" },
                     new Logo { Name = "Spar", ImageUrl = "spar.jpg", Level = "Level 6" },
                     new Logo { Name = "Thai Airways", ImageUrl = "thai-airways.jpg", Level = "Level 6" },
                     new Logo { Name = "Tissot", ImageUrl = "tissot.jpg", Level = "Level 6" },
                     new Logo { Name = "USB", ImageUrl = "usb.jpg", Level = "Level 6" },
                     new Logo { Name = "USPS", ImageUrl = "usps.jpg", Level = "Level 6" },
                     //-Level 7
                     new Logo { Name = "Banana Boat", ImageUrl = "banana-boat.jpg", Level = "Level 7" },
                     new Logo { Name = "Bertolli", ImageUrl = "bertolli.jpg", Level = "Level 7" },
                     new Logo { Name = "Danone", ImageUrl = "danone.jpg", Level = "Level 7" },
                     new Logo { Name = "Total", ImageUrl = "total.jpg", Level = "Level 7" },
                     new Logo { Name = "Delonghi", ImageUrl = "delonghi.jpg", Level = "Level 7" },
                     new Logo { Name = "Dupont", ImageUrl = "dupont.jpg", Level = "Level 7" },
                     new Logo { Name = "Emirates", ImageUrl = "emirates.jpg", Level = "Level 7" },
                     new Logo { Name = "NASA", ImageUrl = "nasa.jpg", Level = "Level 7" },
                     new Logo { Name = "Oxfam", ImageUrl = "oxfam.jpg", Level = "Level 7" },
                     new Logo { Name = "Panam", ImageUrl = "panam.jpg", Level = "Level 7" },
                     new Logo { Name = "Parker", ImageUrl = "parker.jpg", Level = "Level 7" },
                     new Logo { Name = "Parker Brothers", ImageUrl = "parker-brothers.jpg", Level = "Level 7" },
                     new Logo { Name = "Paul And Shark", ImageUrl = "paul-and-shark.jpg", Level = "Level 7" },
                     new Logo { Name = "Pfizer", ImageUrl = "pfizer.jpg", Level = "Level 7" },
                     new Logo { Name = "Piaggio", ImageUrl = "piaggio.jpg", Level = "Level 7" },
                     new Logo { Name = "RSS", ImageUrl = "rss.jpg", Level = "Level 7" },
                     new Logo { Name = "Snapple", ImageUrl = "snapple.jpg", Level = "Level 7" },
                     new Logo { Name = "Stabilo", ImageUrl = "stabilo.jpg", Level = "Level 7" },
                     new Logo { Name = "The North Face", ImageUrl = "the-north-face.jpg", Level = "Level 7" },
                     new Logo { Name = "Tomtom", ImageUrl = "tomtom.jpg", Level = "Level 7" },
                     new Logo { Name = "Unicef", ImageUrl = "unicef.jpg", Level = "Level 7" },
                     //-Level 8
                     new Logo { Name = "Bugatti", ImageUrl = "bugatti.jpg", Level = "Level 8" },
                     new Logo { Name = "Cat", ImageUrl = "cat.jpg", Level = "Level 8" },
                     new Logo { Name = "Enron", ImageUrl = "enron.jpg", Level = "Level 8" },
                     new Logo { Name = "Estee Lauder", ImageUrl = "estee-lauder.jpg", Level = "Level 8" },
                     new Logo { Name = "EuroSport", ImageUrl = "eurosport.jpg", Level = "Level 8" },
                     new Logo { Name = "Exxon", ImageUrl = "exxon.jpg", Level = "Level 8" },
                     new Logo { Name = "Fender", ImageUrl = "fender.jpg", Level = "Level 8" },
                     new Logo { Name = "Fendi", ImageUrl = "fendi.jpg", Level = "Level 8" },
                     new Logo { Name = "Firebird", ImageUrl = "firebird.jpg", Level = "Level 8" },
                     new Logo { Name = "Firestone", ImageUrl = "firestone.jpg", Level = "Level 8" },
                     new Logo { Name = "Fruit Of The Loom", ImageUrl = "fruit-of-the-loom.jpg", Level = "Level 8" },
                     new Logo { Name = "Fujitsu", ImageUrl = "fujitsu.jpg", Level = "Level 8" },
                     new Logo { Name = "Gatorade", ImageUrl = "gatorade.jpg", Level = "Level 8" },
                     new Logo { Name = "Hot Wheels", ImageUrl = "hot-wheels.jpg", Level = "Level 8" },
                     new Logo { Name = "Hsbc", ImageUrl = "hsbc.jpg", Level = "Level 8" },
                     new Logo { Name = "Kenwood", ImageUrl = "kenwood.jpg", Level = "Level 8" },
                     new Logo { Name = "Linkin Park", ImageUrl = "linkin-park.jpg", Level = "Level 8" },
                     new Logo { Name = "Logitech", ImageUrl = "logitech.jpg", Level = "Level 8" },
                     new Logo { Name = "Lufthansa", ImageUrl = "lufthansa.jpg", Level = "Level 8" },
                     new Logo { Name = "Mont Blanc", ImageUrl = "mont-blanc.jpg", Level = "Level 8" },
                     //-Level 9
                     new Logo { Name = "Akzo Nobel", ImageUrl = "akzo-nobel.jpg", Level = "Level 9" },
                     new Logo { Name = "Allianz", ImageUrl = "allianz.jpg", Level = "Level 9" },
                     new Logo { Name = "Asics", ImageUrl = "asics.jpg", Level = "Level 9" },
                     new Logo { Name = "Bad Religion", ImageUrl = "bad-religion.jpg", Level = "Level 9" },
                     new Logo { Name = "Bat", ImageUrl = "bat.jpg", Level = "Level 9" },
                     new Logo { Name = "Billabong", ImageUrl = "billabong.jpg", Level = "Level 9" },
                     new Logo { Name = "Metallica", ImageUrl = "metallica.jpg", Level = "Level 9" },
                     new Logo { Name = "Minecraft", ImageUrl = "minecraft.jpg", Level = "Level 9" },
                     new Logo { Name = "Nandos", ImageUrl = "nandos.jpg", Level = "Level 9" },
                     new Logo { Name = "Novartis", ImageUrl = "novartis.jpg", Level = "Level 9" },
                     new Logo { Name = "Pearl Jam", ImageUrl = "pearl-jam.jpg", Level = "Level 9" },
                     new Logo { Name = "Quaker Oats", ImageUrl = "quaker-oats.jpg", Level = "Level 9" },
                     new Logo { Name = "Sanyo", ImageUrl = "sanyo.jpg", Level = "Level 9" },
                     new Logo { Name = "Subaru", ImageUrl = "Subaru.jpg", Level = "Level 9" },
                     new Logo { Name = "Suzuki", ImageUrl = "suzuki.jpg", Level = "Level 9" },
                     new Logo { Name = "Tdk", ImageUrl = "tdk.jpg", Level = "Level 9" },
                     new Logo { Name = "TopGun", ImageUrl = "topgun.jpg", Level = "Level 9" },
                     new Logo { Name = "UEFA", ImageUrl = "uefa.jpg", Level = "Level 9" },
                     new Logo { Name = "Whirlpool", ImageUrl = "whirlpool.jpg", Level = "Level 9" },
                     new Logo { Name = "Wilson", ImageUrl = "wilson.jpg", Level = "Level 9" },
                     //-Level 10
                     new Logo { Name = "Burton", ImageUrl = "burton.jpg", Level = "Level 10" },
                     new Logo { Name = "Capcom", ImageUrl = "capcom.jpg", Level = "Level 10" },
                     new Logo { Name = "Dole", ImageUrl = "dole.jpg", Level = "Level 10" },
                     new Logo { Name = "Erricson", ImageUrl = "erricson.jpg", Level = "Level 10" },
                     new Logo { Name = "Huawei", ImageUrl = "huawei.jpg", Level = "Level 10" },
                     new Logo { Name = "Icq", ImageUrl = "icq.jpg", Level = "Level 10" },
                     new Logo { Name = "Kyocera", ImageUrl = "kyocera.jpg", Level = "Level 10" },
                     new Logo { Name = "Lancome", ImageUrl = "lancome.jpg", Level = "Level 10" },
                     new Logo { Name = "Lotto", ImageUrl = "lotto.jpg", Level = "Level 10" },
                     new Logo { Name = "Lucent", ImageUrl = "lucent.jpg", Level = "Level 10" },
                     new Logo { Name = "Massey Ferguson", ImageUrl = "massey-ferguson.jpg", Level = "Level 10" },
                     new Logo { Name = "Ncr", ImageUrl = "ncr.jpg", Level = "Level 10" },
                     new Logo { Name = "Nortel", ImageUrl = "nortel.jpg", Level = "Level 10" },
                     new Logo { Name = "Nvidia", ImageUrl = "nvidia.jpg", Level = "Level 10" },
                     new Logo { Name = "Pelikan", ImageUrl = "pelikan.jpg", Level = "Level 10" },
                     new Logo { Name = "SAP", ImageUrl = "sap.jpg", Level = "Level 10" },
                     new Logo { Name = "Tata", ImageUrl = "tata.jpg", Level = "Level 10" },
                     new Logo { Name = "Texas Instruments", ImageUrl = "texas-instruments.jpg", Level = "Level 10" },
                     new Logo { Name = "The Ramones", ImageUrl = "the-ramones.jpg", Level = "Level 10" },
                     new Logo { Name = "WWE", ImageUrl = "wwe.jpg", Level = "Level 10" }
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
