using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Scraper.Migrations
{
    public partial class CreateCarAdvertisement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarAdvertisements",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    ExternalId = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    KM = table.Column<decimal>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Gear = table.Column<string>(nullable: true),
                    Door = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Info = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Phones = table.Column<string>(nullable: true),
                    AuthorType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarAdvertisements", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarAdvertisements");
        }
    }
}
