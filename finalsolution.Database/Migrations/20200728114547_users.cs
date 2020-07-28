using Microsoft.EntityFrameworkCore.Migrations;

namespace finalsolution.Database.Migrations
{
    public partial class users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "MyUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyUsers",
                table: "MyUsers",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MyUsers",
                table: "MyUsers");

            migrationBuilder.RenameTable(
                name: "MyUsers",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }
    }
}
