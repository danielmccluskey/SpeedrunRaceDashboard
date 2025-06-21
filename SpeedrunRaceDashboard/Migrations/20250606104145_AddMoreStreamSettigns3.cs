using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpeedrunRaceDashboard.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreStreamSettigns3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GoogleFontUrl",
                table: "StreamSettings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoogleFontUrl",
                table: "StreamSettings");
        }
    }
}
