using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpeedrunRaceDashboard.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreStreamSettigns2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SidebarImageUrl",
                table: "StreamSettings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SidebarImageUrl",
                table: "StreamSettings");
        }
    }
}
