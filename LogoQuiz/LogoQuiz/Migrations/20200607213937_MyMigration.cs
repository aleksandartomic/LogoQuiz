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
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "15034BCC049F4DBDA7AFA082587EDAC4", "barbie.jpg", false, "Level 1", "Barbie", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "FF301A945D6D4ED489E5043C020A5AF8", "nasa.jpg", false, "Level 7", "NASA", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "7043ED5584F041F9B2DBDE1D74C5583A", "oxfam.jpg", false, "Level 7", "Oxfam", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "FEF158FCC63242B19184C20A5A25172B", "panam.jpg", false, "Level 7", "Panam", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "F88FBB305F5847209DAA04ED2D2719FD", "parker.jpg", false, "Level 7", "Parker", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "706F8C3C002749C6A80E52706E2F91A4", "parker-brothers.jpg", false, "Level 7", "Parker Brothers", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "D46608970C6D47199701A2598DA42FC5", "paul-and-shark.jpg", false, "Level 7", "Paul And Shark", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "6D892B7306834A2A809DFCA0C16C60E3", "pfizer.jpg", false, "Level 7", "Pfizer", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "87C13488BE204FB29CBE1FEB550EC315", "piaggio.jpg", false, "Level 7", "Piaggio", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "368EAE7D8BE14B80A25063A7B9D30098", "rss.jpg", false, "Level 7", "RSS", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "B54B827D5C204ABF92F83A1F08C49FB9", "snapple.jpg", false, "Level 7", "Snapple", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "3C4782CF86334A7891602A5D2B0BE050", "stabilo.jpg", false, "Level 7", "Stabilo", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "3687AEEBA43443FD9CFB064424F562DF", "the-north-face.jpg", false, "Level 7", "The North Face", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "91AFCFADC6DE4F68941B742D74FE4719", "tomtom.jpg", false, "Level 7", "Tomtom", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "E78EC76783DA4E5682604A619A1A50B2", "unicef.jpg", false, "Level 7", "Unicef", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "1A1801A01E594B4EAEA3FCDDAD6825CB", "bugatti.jpg", false, "Level 8", "Bugatti", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "021A808A25354BBB835086EF40EA4907", "cat.jpg", false, "Level 8", "Cat", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "A0044FE0E1C548889936370E1BFE46CE", "enron.jpg", false, "Level 8", "Enron", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "CC2581F716C14BBCB232DDA1AA54031B", "estee-lauder.jpg", false, "Level 8", "Estee Lauder", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "0BD4227830004EB7A82D48E88CC4986A", "eurosport.jpg", false, "Level 8", "EuroSport", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "F6654309B46747DF9E6B02C1B1E9A271", "exxon.jpg", false, "Level 8", "Exxon", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "26B6696AA8F44E8F98A0550A73932326", "fender.jpg", false, "Level 8", "Fender", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "54B9573A71C84ACFA56AFBE5C2E8FC15", "emirates.jpg", false, "Level 7", "Emirates", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "94D6E35E9DA041219E15017F2C7C114F", "fendi.jpg", false, "Level 8", "Fendi", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "DED111161BF34CB5818BC482F2AA1322", "dupont.jpg", false, "Level 7", "Dupont", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "99485E0169F3485F96B803C694881B56", "total.jpg", false, "Level 7", "Total", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "41460B8D35B34C94823BA604BA6D7113", "compaq.jpg", false, "Level 6", "Compaq", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "D9F83A455EAA4D8EA0D85FA4AEA53713", "corona.jpg", false, "Level 6", "Corona", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "3A12165FF0DB4A2DB9E4E8F2BA958F81", "dreamworks.jpg", false, "Level 6", "Dreamworks", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "B69A2D08AE0F43B98DF138E6BB5CCF79", "fishermans-friend.jpg", false, "Level 6", "Fishermans Friend", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "1DD78E33FEA7487C93D54573506A828D", "fred-perry.jpg", false, "Level 6", "Fred Perry", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "38AA297C012E4F87AAB9D0DF1E169F84", "girl-scouts-of-america.jpg", false, "Level 6", "Girl Scouts Of America", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "ACCDB35DDB094945A3F05E6662BC61C9", "infiniti.jpg", false, "Level 6", "Infiniti", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "036A3F29AFFA44A5801CF0D0094F3446", "maggi.jpg", false, "Level 6", "Maggi", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "23DE09D2351D41B5899127A16CB5D989", "mastercard.jpg", false, "Level 6", "Mastercard", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "47A42816D1DF4A3B8779AA9A985AFE63", "mozilla.jpg", false, "Level 6", "Mozilla", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "F9D2443D9B584BB99C2E85503694B2BF", "oralb.jpg", false, "Level 6", "OralB", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "948869D65D0B401CAE71FE672CC6F38F", "quicktime.jpg", false, "Level 6", "QuickTime", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "6C8DC6E0522A44BC8CDBB1AE7FDF81B5", "roland-garros.jpg", false, "Level 6", "Roland Garros", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "22C79AA344C9491D800F9204F35A8356", "spar.jpg", false, "Level 6", "Spar", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "777D9DDE462D4DD8BC6413D1D863F181", "thai-airways.jpg", false, "Level 6", "Thai Airways", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "D967A1130EC54CBB8B3B880438DE06FB", "tissot.jpg", false, "Level 6", "Tissot", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "AD8F6AFA5DBC4600B9F9D73AAD716AE8", "usb.jpg", false, "Level 6", "USB", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "045060BA1E9946909156F10E4112CBA6", "usps.jpg", false, "Level 6", "USPS", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "41919E201D254D5F802B002E74FA4D94", "banana-boat.jpg", false, "Level 7", "Banana Boat", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "5F17298E04F544BFBF8FA4E8BD35A2F2", "bertolli.jpg", false, "Level 7", "Bertolli", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "63222E7923B8401BA59409A092254D0A", "danone.jpg", false, "Level 7", "Danone", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "107C562D9EC3453BB150E52F720DE31C", "delonghi.jpg", false, "Level 7", "Delonghi", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "3C05E67714204636AE80954CD14D59D0", "firebird.jpg", false, "Level 8", "Firebird", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "2FD16C1984B743F687B34F9D649C03DE", "firestone.jpg", false, "Level 8", "Firestone", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "181FB3A129B14DF7B54A8A0F98163D90", "fruit-of-the-loom.jpg", false, "Level 8", "Fruit Of The Loom", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "C0298D189AD14A9997FFE522EAAA5E7C", "uefa.jpg", false, "Level 9", "UEFA", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "067FCB89B29E44DEB46833643DC6344D", "whirlpool.jpg", false, "Level 9", "Whirlpool", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "1C9B25CC1D8F4633ACD83806ABF47BBA", "wilson.jpg", false, "Level 9", "Wilson", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "F97CC77D6B284051B6E34F4D83E26CBB", "burton.jpg", false, "Level 10", "Burton", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "8A907B2D310848D2830F5C60C381CBFF", "capcom.jpg", false, "Level 10", "Capcom", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "4661163756F14EA4ADC267DFF9FC3BDB", "dole.jpg", false, "Level 10", "Dole", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "814B35BA3328420DA761E0E92231CF35", "erricson.jpg", false, "Level 10", "Erricson", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "7BE834D43A2943349E6EAA40C654CB91", "huawei.jpg", false, "Level 10", "Huawei", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "4FE52184F1EC406D90A25EF05CC425FC", "icq.jpg", false, "Level 10", "Icq", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "909DA9BB8C834AEC91A98138BC2BEF19", "kyocera.jpg", false, "Level 10", "Kyocera", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "CBB50C2C5E5540FEA31B3CD7A36A0C38", "lancome.jpg", false, "Level 10", "Lancome", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "24263CCD5D994F0E91DD24EEA495D7B2", "lotto.jpg", false, "Level 10", "Lotto", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "1195E0D63BB5407997CA804AD77EC533", "lucent.jpg", false, "Level 10", "Lucent", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "A144E48B473244A38856ED18F92D4415", "massey-ferguson.jpg", false, "Level 10", "Massey Ferguson", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "0B7E05B026D245C5B5BC16CD9F2F69FE", "ncr.jpg", false, "Level 10", "Ncr", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "9E00E3198B4B4CA89DE2A067BB253805", "nortel.jpg", false, "Level 10", "Nortel", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "45D10F08072A4DBA84DFBA5AA1F705EF", "nvidia.jpg", false, "Level 10", "Nvidia", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "A9BE592A26EB4DD0BCA55E1918A5369D", "pelikan.jpg", false, "Level 10", "Pelikan", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "4DB859C6EDEE4E27AAECE3DCC7B21C65", "sap.jpg", false, "Level 10", "SAP", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "22EFCD61B0E84E4E8CABD9019F782A62", "tata.jpg", false, "Level 10", "Tata", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "47A42E57BAB747A4895FBA90B85F6B7A", "texas-instruments.jpg", false, "Level 10", "Texas Instruments", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "B9E66F1BE24B4C9A810AD56002B4DBA2", "topgun.jpg", false, "Level 9", "TopGun", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "D074EF3CDD434FC8A77809232069C03C", "tdk.jpg", false, "Level 9", "Tdk", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "668D45AF827045DA81790D708AAA4E28", "suzuki.jpg", false, "Level 9", "Suzuki", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "32FB28D7B80147CEBA226E3635FEE5BA", "Subaru.jpg", false, "Level 9", "Subaru", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "ADBC1D7BED324E34B0F4C30AD4291A08", "fujitsu.jpg", false, "Level 8", "Fujitsu", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "6D93596AB3164217B7A1656B423761CC", "gatorade.jpg", false, "Level 8", "Gatorade", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "F78ADD863B324D3596B6A34230AF2C10", "hot-wheels.jpg", false, "Level 8", "Hot Wheels", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "C3279669A6034477A30CC1FCA3125E79", "hsbc.jpg", false, "Level 8", "Hsbc", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "6C154A64973D473898259971C943FB5C", "kenwood.jpg", false, "Level 8", "Kenwood", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "30F8FFC519DC4F6EA4339D2008D59817", "linkin-park.jpg", false, "Level 8", "Linkin Park", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "4A44531B3CA543059EA40731F2842A9C", "logitech.jpg", false, "Level 8", "Logitech", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "9F896FE68F8C4A47863202C3847F3748", "lufthansa.jpg", false, "Level 8", "Lufthansa", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "9CA972F8F20B4ED5A1FAFA0EC580FE20", "mont-blanc.jpg", false, "Level 8", "Mont Blanc", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "85B655360D014A19AE51E3F9FEED725C", "akzo-nobel.jpg", false, "Level 9", "Akzo Nobel", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "B1CFA916D1AB43B2A1207F94DB421F0B", "champion.jpg", false, "Level 6", "Champion", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "F6F07C9688C74585A45D8762922D918C", "allianz.jpg", false, "Level 9", "Allianz", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "E864F7C45A084D0BAFE770771960A200", "bad-religion.jpg", false, "Level 9", "Bad Religion", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "299E3A0E82B84231BD4E97A589BE6D76", "bat.jpg", false, "Level 9", "Bat", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "CE0A998507AA4AF2827743010283D344", "billabong.jpg", false, "Level 9", "Billabong", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "D041980F6AA841EFA27D77443B16B964", "metallica.jpg", false, "Level 9", "Metallica", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "DCC3409093FB45C2AF02F6D0615EBB64", "minecraft.jpg", false, "Level 9", "Minecraft", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "063D63EE5DB647909E3953B9F89E1E29", "nandos.jpg", false, "Level 9", "Nandos", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "4B202AC354E540ACAED752CEE949BCCF", "novartis.jpg", false, "Level 9", "Novartis", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "E7956279F3654C4994B019C8A517E874", "pearl-jam.jpg", false, "Level 9", "Pearl Jam", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "D5BF5B6F7A654A74B7D1AE027093281C", "quaker-oats.jpg", false, "Level 9", "Quaker Oats", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "2C34082DCF6746BD9103EA2125F67DB1", "sanyo.jpg", false, "Level 9", "Sanyo", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "F7E6EAE956A442AA95E00A21F5CB5436", "asics.jpg", false, "Level 9", "Asics", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "84A0CBF14155441089C1AB35BC7CD39F", "the-ramones.jpg", false, "Level 10", "The Ramones", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "8F5C577CBE2C48E4A8C00AD77DCDE31B", "bridgestone.jpg", false, "Level 6", "Bridgestone", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "10AE4176C52D44058FAC41E06DE73CFE", "tictac.jpg", false, "Level 5", "Tictac", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "3D63BBA59E6046B9A9F5BB3C0B3BDF06", "ariel.jpg", false, "Level 2", "Ariel", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "6CEF2D2A4D2245F1B53FFC2139122841", "bank-of-america.jpg", false, "Level 2", "Bank Of America", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "E385777B335B4FFAA708BAE6AB05DDD8", "bbc.jpg", false, "Level 2", "BBC", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "751520030B924A3C93D3369A46FD9CEC", "bluetooth.jpg", false, "Level 2", "Bluetooth", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "B6AB5D8A1193416ABF6F360E40B51271", "burger-king.jpg", false, "Level 2", "Burger King", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "34A037DEC7D54296AE479ED80B519BA4", "crocs.jpg", false, "Level 2", "Crocs", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "F406307EC17A4284B2B7872EFB404788", "diesel.jpg", false, "Level 2", "Diesel", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "EF30DF689154464C82E09DB69B91375F", "ghostbusters.jpg", false, "Level 2", "Ghostbusters", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "7B1219E19BA0489991CCFFD814512EAD", "glaxosmithklein.jpg", false, "Level 2", "Glaxosmithklein", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "CBAF3F2172FE4D878D6DC58862298033", "kodak.jpg", false, "Level 2", "Kodak", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "408FBA834A8E42C8AE8D091D5C1763F1", "lacoste.jpg", false, "Level 2", "Lacoste", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "DD56BC4470634F5782325F433DFD9482", "milka.jpg", false, "Level 2", "Milka", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "D2CDD951B2F74C09AF7B4E3931E27E9E", "nickelodeon.jpg", false, "Level 2", "Nickelodeon", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "A8A624FB51A647838B02EDEE6508FB31", "nike.jpg", false, "Level 2", "Nike", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "B8DE549E3D284594A2820802355938B2", "penguin.jpg", false, "Level 3", "Penguin", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "A751B3A7E9C642C3B03A64A4D72F1155", "pringles.jpg", false, "Level 3", "Pringles", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "5FFEC23E022A4364922FED7FCBD0DAEA", "rolls-royce.jpg", false, "Level 3", "Rolls Royce", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "B08A9608C0D0492394C47F2C36D4B6A6", "twitter.jpg", false, "Level 3", "Twitter", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "424069B62B1F4EAA9BD880A0D70D0CCC", "goodyear.jpg", false, "Level 3", "Goodyear", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "39D4D18CC1A84D2AB3AC665DA5D5CCC5", "harry-potter.jpg", false, "Level 3", "Harry Potter", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "32EF804E68834148BCF4249F1CF00592", "hello-kitty.jpg", false, "Level 3", "Hello Kitty", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "2DF8FEB1630840799BF10990475599B6", "apple.jpg", false, "Level 2", "Apple", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "3C719475CCC54B3BBFF200A839F6060D", "hm.jpg", false, "Level 3", "HM", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "B2899EED3BB24324B3FEDC69651BB4E9", "american-airlines.jpg", false, "Level 2", "American Airlines", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "00268E2059F140A384E0B7F81574787D", "adidas.jpg", false, "Level 2", "Adidas", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "1DFF44ACEAF54E2A89B84AA5CABAE291", "baskin-robbins.jpg", false, "Level 1", "Baskin Robbins", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "D20BE09757B5475DBC7370BFDE41BE0E", "budget.jpg", false, "Level 1", "Budget", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "0472D95445F14F5F90E343126A7E0F20", "carlsberg.jpg", false, "Level 1", "Carlsberg", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "55B29D7C2CEB409987CCFEB21BAF574E", "dunkin-donuts.jpg", false, "Level 1", "Dunkin Donuts", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "B9F385FAFF6F4B28884AC65AE1A1CF42", "facebook.jpg", false, "Level 1", "Facebook", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "EF229C0338144FC0BACCFB253AAA60CB", "fedex.jpg", false, "Level 1", "Fedex", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "6090AA4EB12B4A01B18E2A5674C280CE", "holiday-inn.jpg", false, "Level 1", "Holiday inn", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "1DDD220455174CE8AEC5D995D32BD3E5", "jaguar.jpg", false, "Level 1", "Jaguar", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "997D51A2E01E4F4084862ECDA42DA79D", "kfc.jpg", false, "Level 1", "Kfc", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "45F49AB9FE8C40568AFAF20D62F9AFAC", "knorr.jpg", false, "Level 1", "Knorr", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "C4088080669A429EB9D116246A46E05A", "lexus.jpg", false, "Level 1", "Lexus", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "BF8F1ABE99534781B304EC38D7C25817", "mcdonalds.jpg", false, "Level 1", "McDonalds", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "E4D696C2AC384522A432A963D7680AE9", "pepsi.jpg", false, "Level 1", "Pepsi", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "865E5B4CD3F64FEBA046DBF9F5C3E6F4", "playboy.jpg", false, "Level 1", "Playboy", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "7133B90EE0B44821A5EABE9FABDE370A", "playstation.jpg", false, "Level 1", "PlayStation", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "8EDCB1EF9AE045EE8FBE28DD9D8DF775", "safeway.jpg", false, "Level 1", "Safeway", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "69B1FC49F0164994B1377C0EAB27F9C9", "the-body-shop.jpg", false, "Level 1", "The Body Shop", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "56B7D1D668CE4C30BD3AA4BD007ACEC8", "visa.jpg", false, "Level 1", "Visa", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "D3872929E64A48058ECF8E32AC5348E4", "yahoo.jpg", false, "Level 1", "Yahoo", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "F21896755A764C3AB5494C71F1D1F840", "20th-century-fox.jpg", false, "Level 2", "20th Century Fox", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "1164603623424F64A3897F5B2CD20FBF", "absolut.jpg", false, "Level 2", "Absolut", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "913C352577CE41C3BAF8A70F6F7DA2D0", "amazon.jpg", false, "Level 2", "Amazon", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "EE5AFDDFE8074C9BA2489B8C7F225AFF", "honda.jpg", false, "Level 3", "Honda", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "97C74E47016D4312B431D7EAB8B03EF0", "nikon.jpg", false, "Level 3", "Nikon", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "C58D0432C94D4AD7A0A6FDEBD04658B2", "pixar.jpg", false, "Level 3", "Pixar", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "2521420EBBDD4227940374EE34B1B29E", "malibu.jpg", false, "Level 4", "Malibu", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "6A5AAF28080D42438A8F3E22D7B15F04", "umbro.jpg", false, "Level 4", "Umbro", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "D76EBF718CE74152AEBCB10731C79D3C", "wifi.jpg", false, "Level 4", "Wifi", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "AC3ABC83D9D64DE89D49B896C39A7C4C", "air-jordan.jpg", false, "Level 5", "Air Jordan", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "ACE28AF355714900B75DBEF544E55D66", "android.jpg", false, "Level 5", "Android", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "D555E32A53894F55B89CA3B29F53883A", "asus.jpg", false, "Level 5", "Asus", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "8FE65C80E4FA4BC9A47080F7E5D56BD1", "atari.jpg", false, "Level 5", "Atari", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "E85B339692A1451F925455690D5D57E1", "avery.jpg", false, "Level 5", "Avery", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "7FFDEFE9F5A04539B3FFA25BA24875F2", "chiquita.jpg", false, "Level 5", "Chiquita", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "B64CC1A220984E4199652CCA721E856D", "chupa-chups.jpg", false, "Level 5", "Chupa Chups", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "3EEDDC590A624433AE9D9605FBBD4CC0", "delta.jpg", false, "Level 5", "Delta", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "C595350D0EB14CB9A1939533025F92A6", "fiat.jpg", false, "Level 5", "Fiat", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "6B139578A16744FDA06AC2AC15456595", "fsc.jpg", false, "Level 5", "Fsc", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "D3CA9A0586F541EC8B872C26D066F013", "lays.jpg", false, "Level 5", "Lays", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "BE418D9742DF41408F68D7F7F686AEBB", "nespresso.jpg", false, "Level 5", "Nespresso", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "C4B901949D09495A905B2826370106F4", "nestle.jpg", false, "Level 5", "Nestle", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "5F318089425A4700ABD3E7AAD7D9755D", "nivea.jpg", false, "Level 5", "Nivea", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "2CAE6AC58716446BA8E3B526D116B485", "pampers.jpg", false, "Level 5", "Pampers", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "1978F9CF8C9B4F3AAE07139CBCAA39B4", "sheraton.jpg", false, "Level 5", "Sheraton", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "8F61DBCB3A6D49B0B4A3D24565255E3A", "showtime.jpg", false, "Level 5", "Showtime", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "530027BD6557484C8DDC59424F5AAE49", "target.jpg", false, "Level 5", "Target", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "FDE39DAA70D14AA8BA27E9D2E9F18001", "linkedin.jpg", false, "Level 4", "Linkedin", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "31C7A01918714CCBA30EF47F233BC11B", "land-rover.jpg", false, "Level 4", "Land Rover", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "C258487CB3734DEAB96372DC420796E4", "kraft.jpg", false, "Level 4", "Kraft", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "491AED3B98E140079599352A783A4094", "kleenex.jpg", false, "Level 4", "Kleenex", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "51CAA0B3A9EA4C428CBCA1D77A62A010", "puma.jpg", false, "Level 3", "Puma", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "270F7705D4ED468399DA609D9E8D966B", "renault.jpg", false, "Level 3", "Renault", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "33290C8165D142EDBD01AD0736806914", "seat.jpg", false, "Level 3", "Seat", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "72C2CABA60E045CD8DAED7E3CFF9B7C6", "seven-eleven.jpg", false, "Level 3", "Seven Eleven", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "15366934C2274D24B06F3B1E932A1C2F", "tag-heuer.jpg", false, "Level 3", "Tag Heuer", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "DAC6FB043E9343FBABB9642859430CD4", "woolmark.jpg", false, "Level 3", "Woolmark", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "93A1BF352D6043798F7E8B16976F416F", "xbox.jpg", false, "Level 3", "Xbox", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "F9EC769AEE1C4F0CAF73620FECEB1AB5", "xerox.jpg", false, "Level 3", "Xerox", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "3EC33CBC6FA0485394D5BDDAD66F0ABD", "yellow-pages.jpg", false, "Level 3", "Yellow Pages", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "76839100E92D4C6982C84A3555E3C873", "acdc.jpg", false, "Level 4", "ACDC", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "CEE8D256987940568F7B4D8A79246158", "total.jpg", false, "Level 5", "Total", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "B2573489F8C34CC6BF0EF3459443EC50", "benetton.jpg", false, "Level 4", "Benetton", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "94401C4CEA504E1CAC657E11296ABDC0", "cartoon-network.jpg", false, "Level 4", "Cartoon Network", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "7AE5852403B846ADBB69F4B4D3C8F9DD", "cheerios.jpg", false, "Level 4", "Cheerios", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "69584144C4844708B98F0B4AD8770C73", "discovery.jpg", false, "Level 4", "Discovery", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "68ACE31F3DC1498E88273B766CA6723C", "dove.jpg", false, "Level 4", "Dove", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "A84ACACA328A4BBC9CED1F0A18CC4667", "durex.jpg", false, "Level 4", "Durex", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "4550EB736F6F4AE28FB8EF15C4BF5602", "fisherprice.jpg", false, "Level 4", "Fisherprice", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "101B229A2AC542E88338674E82B6CAD3", "fosters.jpg", false, "Level 4", "Fosters", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "647734A85B0F467D95463457ECFD940E", "illy.jpg", false, "Level 4", "Illy", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "A3D8F8F17C7A4B4AB562E09B3C687F23", "john-deere.jpg", false, "Level 4", "John Deere", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "0AD6460B4583487F9DD9EB9207701841", "kia.jpg", false, "Level 4", "Kia", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "F0377051A890410F952655BDF743AD25", "budweiser.jpg", false, "Level 4", "Budweiser", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "44AC081B22B948BFBA5F2D20D6E8479F", "wwe.jpg", false, "Level 10", "WWE", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logos");
        }
    }
}
