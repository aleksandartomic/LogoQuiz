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
                values: new object[] { "CDAD889AE72F4DB7A58AE778B4C427E0", "A*p***", "APPLE.png", false, "Level 1", "Apple", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "CE823A60773849058541ABA774D04188", "Fa*e**o*", "FACEBOOK.png", false, "Level 1", "Facebook", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "DBCCB202A0CE4CFDB2EF3F5248724414", "G**gl* C***me", "GOOGLECHROME.png", false, "Level 2", "Google Chrome", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "B74B052F9A1F4A0CB05151605FA3D4C5", "H****i", "HUAWEI.png", false, "Level 1", "Huawei", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "071B4C0A35684F25B7DCA3F0D537F476", "I***ag**m", "INSTAGRAM.png", false, "Level 1", "Instagram", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "C25DA2E15F0B418D9DCFF1B3060456B9", "M***e**s", "MERCEDES.png", false, "Level 1", "Mercedes", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "C16684964C424EE19CEB63D376DB1B10", "*a***ng", "SAMSUNG.png", false, "Level 2", "Samsung", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "DDFEE56CA8864BD687D2AC32C32D21D2", "Sk**e", "SKYPE.png", false, "Level 2", "Skype", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "8AD2F5DC072244AC8C3A90812C7BD37F", "*****er", "TWITTER.png", false, "Level 2", "Twitter", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "E17F096E70EF47788CB828EA7E0D984C", "Y*u*T***", "YOUTUBE.png", false, "Level 2", "YouTube", 0 });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "IsSucceed", "Level", "Name", "Point" },
                values: new object[] { "9A265275C8F449A9A388CFFE6A270D70", "BMW", "BMW.jpg", false, "Level 1", "BMW", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logos");
        }
    }
}
