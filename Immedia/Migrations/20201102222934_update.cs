using Microsoft.EntityFrameworkCore.Migrations;

namespace Immedia.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JsonDatas");

            migrationBuilder.DropColumn(
                name: "ImageIdentity",
                table: "RootImages");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "RootImages");

            migrationBuilder.AddColumn<string>(
                name: "ResponseData",
                table: "RootImages",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResponseData",
                table: "RootImages");

            migrationBuilder.AddColumn<string>(
                name: "ImageIdentity",
                table: "RootImages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "RootImages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "JsonDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Json = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsonDatas", x => x.Id);
                });
        }
    }
}
