using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaBox.Storing.Migrations
{
    public partial class Updating_Store_Info : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cursts",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "Name",
                value: "thick");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "DateModified",
                value: new DateTime(2021, 1, 20, 10, 0, 12, 957, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "EntityId",
                keyValue: 2L,
                column: "DateModified",
                value: new DateTime(2021, 1, 20, 10, 0, 12, 983, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "Name",
                value: "Dominos");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 2L,
                column: "Name",
                value: "Pizz Hut");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 3L,
                column: "Name",
                value: "Papa John's");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cursts",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "Name",
                value: "stuffed");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "DateModified",
                value: new DateTime(2021, 1, 19, 21, 26, 27, 314, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "EntityId",
                keyValue: 2L,
                column: "DateModified",
                value: new DateTime(2021, 1, 19, 21, 26, 27, 344, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 1L,
                column: "Name",
                value: "Texas");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 2L,
                column: "Name",
                value: "Maryland");

            migrationBuilder.UpdateData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: 3L,
                column: "Name",
                value: "Florida");
        }
    }
}
