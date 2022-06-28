using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JuniorTemplate.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Updated = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("20da3a9c-b034-405d-8c63-c8e9aad46a64"), new DateTime(2022, 6, 28, 10, 41, 7, 609, DateTimeKind.Utc).AddTicks(9838), "Big Sur Tea", 25m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("349ffc08-d6e0-412a-8bec-f0e977f9a84c"), new DateTime(2022, 6, 28, 10, 41, 7, 609, DateTimeKind.Utc).AddTicks(9853), "Chaga Chai Mushroom Tea", 20m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("35eebc22-1d9c-4381-97ee-dbeee1bb0f7d"), new DateTime(2022, 6, 28, 10, 41, 7, 609, DateTimeKind.Utc).AddTicks(9833), "Rose Tea", 20m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("8389a749-f167-4521-8d33-a7330d72629f"), new DateTime(2022, 6, 28, 10, 41, 7, 609, DateTimeKind.Utc).AddTicks(9835), "English Breakfast Tea", 18m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("8aae270e-1dfc-40d9-b117-a895a3e84931"), new DateTime(2022, 6, 28, 10, 41, 7, 609, DateTimeKind.Utc).AddTicks(9840), "Dragonwell", 30m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("b983e730-ace9-42b8-9cec-959e0804551a"), new DateTime(2022, 6, 28, 10, 41, 7, 609, DateTimeKind.Utc).AddTicks(9839), "Jasmine Pearls", 41m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("c68b898d-8357-4c72-a53b-80dbd940dcea"), new DateTime(2022, 6, 28, 10, 41, 7, 609, DateTimeKind.Utc).AddTicks(9837), "Big Sur Tea", 25m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("e48cebea-f7e7-4e67-8e8c-9e434e2662ed"), new DateTime(2022, 6, 28, 10, 41, 7, 609, DateTimeKind.Utc).AddTicks(9168), "Earl Gray", 20m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("ed10c4da-466c-4339-9e44-c05bf651d613"), new DateTime(2022, 6, 28, 10, 41, 7, 609, DateTimeKind.Utc).AddTicks(9854), "Naked Pu-erh Tea", 27m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("f2fcdcdb-132a-463a-becd-315e2116bed2"), new DateTime(2022, 6, 28, 10, 41, 7, 609, DateTimeKind.Utc).AddTicks(9851), "Vanilla Berry Tea", 21m, null });

            migrationBuilder.InsertData(
                table: "Teas",
                columns: new[] { "Id", "Created", "Name", "Price", "Updated" },
                values: new object[] { new Guid("ff3169d8-10f9-4908-b7a4-70cce6a70568"), new DateTime(2022, 6, 28, 10, 41, 7, 609, DateTimeKind.Utc).AddTicks(9850), "White Peach Tea", 29m, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teas");
        }
    }
}
