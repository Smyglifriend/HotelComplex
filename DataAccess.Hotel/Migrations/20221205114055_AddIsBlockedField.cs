using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Hotel.Migrations
{
    public partial class AddIsBlockedField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBlocked",
                table: "Room",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBlocked",
                table: "Room");
        }
    }
}
