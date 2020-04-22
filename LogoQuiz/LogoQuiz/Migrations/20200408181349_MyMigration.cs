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
                    Hint = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Logos",
                columns: new[] { "Id", "Hint", "ImageUrl", "Name" },
                values: new object[] { "B1A51DB237914F29986F192006CC9777", "*m*", "BMW.jpg", "Bmw" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logos");
        }
    }
}
