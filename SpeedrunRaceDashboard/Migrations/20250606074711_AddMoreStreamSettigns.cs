using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpeedrunRaceDashboard.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreStreamSettigns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccentColour",
                table: "StreamSettings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BackgroundColour",
                table: "StreamSettings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BackgroundImageUrl",
                table: "StreamSettings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "CompactMode",
                table: "StreamSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CustomCSS",
                table: "StreamSettings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FontFamily",
                table: "StreamSettings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HeaderImageUrl",
                table: "StreamSettings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HeaderTextColour",
                table: "StreamSettings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainBackgroundColour",
                table: "StreamSettings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "StreamSettings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ShowCommentaryBox",
                table: "StreamSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowFacts",
                table: "StreamSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowLeaderboard",
                table: "StreamSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowTeamBorders",
                table: "StreamSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SidebarBackgroundColour",
                table: "StreamSettings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SidebarTextColour",
                table: "StreamSettings",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "UseBackgroundImage",
                table: "StreamSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UseHeaderImage",
                table: "StreamSettings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccentColour",
                table: "StreamSettings");

            migrationBuilder.DropColumn(
                name: "BackgroundColour",
                table: "StreamSettings");

            migrationBuilder.DropColumn(
                name: "BackgroundImageUrl",
                table: "StreamSettings");

            migrationBuilder.DropColumn(
                name: "CompactMode",
                table: "StreamSettings");

            migrationBuilder.DropColumn(
                name: "CustomCSS",
                table: "StreamSettings");

            migrationBuilder.DropColumn(
                name: "FontFamily",
                table: "StreamSettings");

            migrationBuilder.DropColumn(
                name: "HeaderImageUrl",
                table: "StreamSettings");

            migrationBuilder.DropColumn(
                name: "HeaderTextColour",
                table: "StreamSettings");

            migrationBuilder.DropColumn(
                name: "MainBackgroundColour",
                table: "StreamSettings");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "StreamSettings");

            migrationBuilder.DropColumn(
                name: "ShowCommentaryBox",
                table: "StreamSettings");

            migrationBuilder.DropColumn(
                name: "ShowFacts",
                table: "StreamSettings");

            migrationBuilder.DropColumn(
                name: "ShowLeaderboard",
                table: "StreamSettings");

            migrationBuilder.DropColumn(
                name: "ShowTeamBorders",
                table: "StreamSettings");

            migrationBuilder.DropColumn(
                name: "SidebarBackgroundColour",
                table: "StreamSettings");

            migrationBuilder.DropColumn(
                name: "SidebarTextColour",
                table: "StreamSettings");

            migrationBuilder.DropColumn(
                name: "UseBackgroundImage",
                table: "StreamSettings");

            migrationBuilder.DropColumn(
                name: "UseHeaderImage",
                table: "StreamSettings");
        }
    }
}
