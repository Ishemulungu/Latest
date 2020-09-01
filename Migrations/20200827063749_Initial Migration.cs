using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DeviceAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppDeviceData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Index = table.Column<int>(nullable: false),
                    Dmac = table.Column<string>(nullable: true),
                    Refpower = table.Column<int>(nullable: false),
                    Uuid = table.Column<string>(nullable: true),
                    MajorID = table.Column<int>(nullable: false),
                    Rssi = table.Column<int>(nullable: false),
                    MinorID = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppDeviceData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppDeviceData");
        }
    }
}
