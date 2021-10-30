using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcApp2.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Name", "Year" },
                values: new object[,]
                {
                    { 1, "Damien Chazelle", "Whiplash", 2014 },
                    { 2, "Quentin Tarantino", "Pulp Fiction", 1994 },
                    { 3, "Sergio Leone", "The Good, the Bad and the Ugly", 1966 },
                    { 4, "Sidney Lumet", "12 Angry Men", 1957 },
                    { 5, "Michel Gondry", "Eternal Sunshine of the Spotless Mind", 2004 },
                    { 6, "Milos Forman", "One Flew Over the Cuckoo's Nest", 1975 },
                    { 7, "Frank Darabont", "The Green Mile", 1999 },
                    { 8, "Roberto Benigni", "Life Is Beautiful", 1997 },
                    { 9, "Jean-Pierre Jeunet", "Amélie", 2001 },
                    { 10, "Luc Besson", "Léon: The Professional", 1994 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
