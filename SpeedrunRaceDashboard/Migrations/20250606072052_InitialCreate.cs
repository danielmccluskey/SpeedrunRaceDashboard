using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpeedrunRaceDashboard.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StreamProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TwitchUsername = table.Column<string>(type: "TEXT", nullable: false),
                    TwitchDisplayName = table.Column<string>(type: "TEXT", nullable: false),
                    UserDisplayName = table.Column<string>(type: "TEXT", nullable: false),
                    TeamColour = table.Column<string>(type: "TEXT", nullable: false),
                    GameName = table.Column<string>(type: "TEXT", nullable: false),
                    CompletedTime = table.Column<string>(type: "TEXT", nullable: false),
                    PersonalBest = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreamProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StreamSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StreamTitle = table.Column<string>(type: "TEXT", nullable: false),
                    TimerStartedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsTimerRunning = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreamSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StreamSlots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ViewOrder = table.Column<int>(type: "INTEGER", nullable: false),
                    ShowLoading = table.Column<bool>(type: "INTEGER", nullable: false),
                    TeamColour = table.Column<string>(type: "TEXT", nullable: false),
                    ProfileId = table.Column<int>(type: "INTEGER", nullable: false),
                    Hidden = table.Column<bool>(type: "INTEGER", nullable: false),
                    Paused = table.Column<bool>(type: "INTEGER", nullable: false),
                    Muted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreamSlots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StreamSlots_StreamProfiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "StreamProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StreamSlots_ProfileId",
                table: "StreamSlots",
                column: "ProfileId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StreamSettings");

            migrationBuilder.DropTable(
                name: "StreamSlots");

            migrationBuilder.DropTable(
                name: "StreamProfiles");
        }
    }
}
