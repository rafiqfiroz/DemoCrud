using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoCrud.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "LastName", "Name" },
                values: new object[] { 1, 34, "Ahmed", "Rafiq" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "LastName", "Name" },
                values: new object[] { 2, 33, "Ahmed", "Shamim" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Age", "LastName", "Name" },
                values: new object[] { 3, 23, "Ahmed", "Marium" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
