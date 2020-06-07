using Microsoft.EntityFrameworkCore.Migrations;

namespace LogoQuiz.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logos",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Hint = table.Column<string>(nullable: true),
                    IsSucceed = table.Column<bool>(nullable: false),
                    Level = table.Column<string>(nullable: true),
                    Point = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "423F5CDA2F2F408A91E9D8863D493226", "***", "barbie.jpg", false, "Level 1", "Barbie", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "49C5595139DE4441BD07A7A827B66115", "***", "kia.jpg", false, "Level 4", "Kia", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "D8A00F327C6F4C849CBF7169AF738B79", "***", "john-deere.jpg", false, "Level 4", "John Deere", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "378D75B8800A4EB2BF8F5EEF1EE186B8", "***", "illy.jpg", false, "Level 4", "Illy", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "886734374CE54A1FA8C45C141C02FB1D", "***", "fosters.jpg", false, "Level 4", "Fosters", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "FA19D31AB8EE4A27A99D691918AA0EFA", "***", "fisherprice.jpg", false, "Level 4", "Fisherprice", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "3F96E8FD0CBA4015BC7490A317E1F70F", "***", "durex.jpg", false, "Level 4", "Durex", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "6B3EF3D7847C4E7797EB69AB267009F2", "***", "dove.jpg", false, "Level 4", "Dove", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "B59C247344974BDAA41043E15E5F020C", "***", "discovery.jpg", false, "Level 4", "Discovery", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "93A5944F5E174BC2ABCDEE0CB6A7F012", "***", "cheerios.jpg", false, "Level 4", "Cheerios", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "F98E6639F1B94AC69D27A5D6F5F46660", "***", "cartoon-network.jpg", false, "Level 4", "Cartoon Network", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "8A535414A956479D89CA843CDEC00CAF", "***", "budweiser.jpg", false, "Level 4", "Budweiser", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "1152A4419AB8417BA4F332E515E60B2B", "***", "benetton.jpg", false, "Level 4", "Benetton", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "8FBBBE6B5A5246EDAF162D817088B523", "***", "acdc.jpg", false, "Level 4", "ACDC", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "B43A6FC703D14E23A646D2686668A4F0", "***", "yellow-pages.jpg", false, "Level 3", "Yellow Pages", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "E6CA560123BD422895104598BEC34596", "***", "xerox.jpg", false, "Level 3", "Xerox", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "A4CA923E46314ED0B909B6C5CB9DB151", "***", "xbox.jpg", false, "Level 3", "Xbox", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "BCF463F6B7724AFCB8F47A110E9B4BAA", "***", "woolmark.jpg", false, "Level 3", "Woolmark", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "471024E886284B32805A4860C416C8D5", "***", "tag-heuer.jpg", false, "Level 3", "Tag Heuer", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "7624EA82F6A845E6A770DE63D63F7312", "***", "seven-eleven.jpg", false, "Level 3", "Seven Eleven", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "0B48A3DD753E45DD842D1F0D11031E22", "***", "seat.jpg", false, "Level 3", "Seat", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "9AD6FD4C2DEA4A08AFA9EE05EDE4FF41", "***", "renault.jpg", false, "Level 3", "Renault", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "D6DFADB6695A4977B72A169E40D9DAE3", "***", "kleenex.jpg", false, "Level 4", "Kleenex", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "492B0D5909704D3E8319677A18F19F71", "***", "puma.jpg", false, "Level 3", "Puma", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "3830F1DD03BB442888B1FBFCABCAE6DC", "***", "kraft.jpg", false, "Level 4", "Kraft", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "6DE509FB1B134ADC88A25CE408AAF1E6", "***", "linkedin.jpg", false, "Level 4", "Linkedin", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "860D583A41424F9F9958A529A8277398", "***", "target.jpg", false, "Level 5", "Target", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "523375D0093B4E349C9275FBEFFE3400", "***", "showtime.jpg", false, "Level 5", "Showtime", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "99840B7DB6F14207A9D4D528EC2D0DAF", "***", "sheraton.jpg", false, "Level 5", "Sheraton", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "06B1DB46F9254CB48DBEBCA96B6FCF7F", "***", "pampers.jpg", false, "Level 5", "Pampers", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "08C731497B4B4A389EB1968158E6E2AC", "***", "nivea.jpg", false, "Level 5", "Nivea", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "5477F9D7C75A4D0582C6448907EC042F", "***", "nestle.jpg", false, "Level 5", "Nestle", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "F21376B08ADC47C58B6830FDBD23B773", "***", "nespresso.jpg", false, "Level 5", "Nespresso", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "5EB6B239F7434816AF8ED5DF14F0B4B6", "***", "lays.jpg", false, "Level 5", "Lays", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "454272D2ED1B42B9BF91A738099B48F7", "***", "fsc.jpg", false, "Level 5", "Fsc", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "7290606630024ABFBC19852CD91B674E", "***", "fiat.jpg", false, "Level 5", "Fiat", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "4A3FEAC780BD40FE9631C92A8D1B5D3B", "***", "delta.jpg", false, "Level 5", "Delta", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "72B031F7B4AC446F87017160253AC9C7", "***", "chupa-chups.jpg", false, "Level 5", "Chupa Chups", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "2CCB469B650C45908F6619F2AF289574", "***", "chiquita.jpg", false, "Level 5", "Chiquita", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "BE4D307949544E54B4B8C7559C801230", "***", "avery.jpg", false, "Level 5", "Avery", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "056395EC6473402899A429B466B7A91C", "***", "atari.jpg", false, "Level 5", "Atari", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "9F5B076EB83643B596B53C544079BAD5", "***", "asus.jpg", false, "Level 5", "Asus", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "CDF8EA6B8E954D7BA8AD4CB6967E63FD", "***", "android.jpg", false, "Level 5", "Android", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "6AC8E2C97FED4054AB4559F961C4658B", "***", "air-jordan.jpg", false, "Level 5", "Air Jordan", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "A9AAFFFC4F0F4E34AC348477686FA9C3", "***", "wifi.jpg", false, "Level 4", "Wifi", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "8A5E4D27DA6247E4BCAB4D68A19F2356", "***", "umbro.jpg", false, "Level 4", "Umbro", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "8B96C0935A3C4CE48B77188F329CB5BC", "***", "malibu.jpg", false, "Level 4", "Malibu", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "E008EF7DF2664293BF6E7C0C11366268", "***", "land-rover.jpg", false, "Level 4", "Land Rover", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "6AF0769F619E40C7A5631ED7A46B893F", "***", "Pixar.jpg", false, "Level 3", "Pixar", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "2D25E94CB5AE43BB8D8A55B805E48818", "***", "nikon.jpg", false, "Level 3", "Nikon", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "F721268FEBBE4F78A631698DEF388313", "***", "honda.jpg", false, "Level 3", "Honda", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "D069CFBB445C439E80ACB63AECBF2EC2", "***", "absolut.jpg", false, "Level 2", "Absolut", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "BC3D0428054F400FBBBCF4552B0897B1", "***", "20th-century-fox.jpg", false, "Level 2", "20th Century Fox", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "428D3A53434C4C8C9B9DEAACAD0529E9", "***", "yahoo.jpg", false, "Level 1", "Yahoo", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "8B05739E8B4944699F3FF07814A31477", "***", "visa.jpg", false, "Level 1", "Visa", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "92D8CD24EDB34A7CB6CB62127742C539", "***", "the-body-shop.jpg", false, "Level 1", "The Body Shop", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "354BD9280B334E2697F66D94FAEDD689", "***", "safeway.jpg", false, "Level 1", "Safeway", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "728AEAA382ED4765A062EA2CCA6CD955", "***", "playstation.jpg", false, "Level 1", "PlayStation", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "8B9432BBCA3F46D5A3FB5F6915618F63", "***", "playboy.jpg", false, "Level 1", "Playboy", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "74CB906E01224B0B8B2D671690C5E47E", "***", "pepsi.jpg", false, "Level 1", "Pepsi", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "CAA05AC083BA4D6AA24573D25959B6F3", "***", "mcdonalds.jpg", false, "Level 1", "McDonalds", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "C208578F528F4A2F954274CC32C5A93D", "***", "lexus.jpg", false, "Level 1", "Lexus", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "E84BF526DF6B42A98EEC854EF9261F8E", "***", "knorr.jpg", false, "Level 1", "Knorr", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "C7BF4DA2007349B6A423F78ECB47FD86", "***", "kfc.jpg", false, "Level 1", "Kfc", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "3CC3522FBA564AA197BF0F9AFD2F629D", "***", "jaguar.jpg", false, "Level 1", "Jaguar", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "B66787EE43164CC1B27524470233AD33", "***", "holiday-inn.jpg", false, "Level 1", "Holiday-inn", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "BDEB213702E64636814E1E1F36ED9A43", "***", "fedex.jpg", false, "Level 1", "Fedex", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "BC47FF53F3B54E3385D8FEC4EF3B679E", "***", "facebook.jpg", false, "Level 1", "Facebook", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "003A422112684B03A5A08362E9BD8765", "***", "dunkin-donuts.jpg", false, "Level 1", "Dunkin Donuts", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "A02B76FC43504C4688587E6310223DD4", "***", "carlsberg.jpg", false, "Level 1", "Carlsberg", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "EA01929A30F14C0DB59D34226976FF8A", "***", "budget.jpg", false, "Level 1", "Budget", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "65E0F3A493544DEA96E22B5D9BC2FF1A", "***", "baskin-robbins.jpg", false, "Level 1", "Baskin Robbins", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "3FFAB14DBF38407A9905CA85E74E0D48", "***", "adidas.jpg", false, "Level 2", "Adidas", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "502DE760BDDA47ADABA958CD99464326", "***", "amazon.jpg", false, "Level 2", "Amazon", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "84CBE51ED2684C5FB6B5CB11986E6896", "***", "american-airlines.jpg", false, "Level 2", "American Airlines", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "B180B34D0FAE49A0BD96F15F455E80EA", "***", "apple.jpg", false, "Level 2", "Apple", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "6CBD026238694E7EBCEF0B92E181972B", "***", "hm.jpg", false, "Level 3", "HM", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "A88E32EA02384164A6D444D11B9DC15D", "***", "hello-kitty.jpg", false, "Level 3", "Hello Kitty", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "ED7A0BF2CF544C5E8225A67DE14E4587", "***", "harry-potter.jpg", false, "Level 3", "Harry Potter", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "4741704A0889428D8065D2D347C07D84", "***", "goodyear.jpg", false, "Level 3", "Goodyear", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "EF2BD46B750E4CF88958A46EF7E270A9", "***", "twitter.jpg", false, "Level 3", "Twitter", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "0A6CB91D08CD49038B7FA1A2CD372206", "***", "rolls-royce.jpg", false, "Level 3", "Rolls Royce", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "BDCD29C9CFD1456C88DAB82258C5712B", "***", "pringles.jpg", false, "Level 3", "Pringles", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "79717D99BD934DF789C50B730D0C71BF", "***", "penguin.jpg", false, "Level 3", "Penguin", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "A26DCFECEFBE40FD9C7C17040BB0A35C", "***", "nike.jpg", false, "Level 2", "Nike", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "EA9DA6FD6ECA4486BA70AA439D8E07BB", "***", "nickelodeon.jpg", false, "Level 2", "Nickelodeon", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "A67FE8FEB2914AF69BE93ECA8B53ED2A", "***", "tictac.jpg", false, "Level 5", "Tictac", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "8D4C551D5A4E4045B07B7960449C9BE6", "***", "milka.jpg", false, "Level 2", "Milka", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "391AE3FE86FC4CA48123BD7A19872F18", "***", "kodak.jpg", false, "Level 2", "Kodak", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "9AABEF3DABED481293C55A66F6F93099", "***", "glaxosmithklein.jpg", false, "Level 2", "Glaxosmithklein", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "853373A74DDF40BD9200C97E54DB89E0", "***", "ghostbusters.jpg", false, "Level 2", "Ghostbusters", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "BEA91DB628674FB1A4702D49303EC0C6", "***", "diesel.jpg", false, "Level 2", "Diesel", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "9E0D5608835442A281293C516A9CFECE", "***", "crocs.jpg", false, "Level 2", "Crocs", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "064CCA0F843642508DD761577726A9DD", "***", "burger-king.jpg", false, "Level 2", "Burger King", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "17D45B3F9E1B44938A2052E79BFE64F7", "***", "bluetooth.jpg", false, "Level 2", "Bluetooth", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "FBD96D8B17CC4AB88E0E289CDA1ADB3A", "***", "bbc.jpg", false, "Level 2", "BBC", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "AD9F673A2D1F4E35A98C5EC1D9250F8F", "***", "bank-of-america.jpg", false, "Level 2", "Bank Of America", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "121958E0637C49A688561DA5D9E29F0B", "***", "ariel.jpg", false, "Level 2", "Ariel", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "23BC0F99906B4E7AA4FC7188C13CD713", "***", "lacoste.jpg", false, "Level 2", "Lacoste", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "B7E6EF634E5142E4B6DE4782538BE004", "***", "total.jpg", false, "Level 5", "Total", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logos");
        }
    }
}
