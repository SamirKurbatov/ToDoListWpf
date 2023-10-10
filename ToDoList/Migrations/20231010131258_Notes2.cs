using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoList.Migrations
{
    /// <inheritdoc />
    public partial class Notes2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9456), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9462), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9464), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9466) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9468), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9470), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9472), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9548), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9551), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9554), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9557), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9560), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9566), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9567), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9569), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9572), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9577), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9581), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9583), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9586), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9588), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9590), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9593), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9595), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9599), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9601), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9604), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9606), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9607), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9611), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9612), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9614), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9617), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9621), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9623), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9625), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9628), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9629), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9636), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9638), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9639), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9642), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9644), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9648), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9651), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9653), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9655), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9658) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9661), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9663), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9665), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9666), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9669), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9671), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9674), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9679), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9681), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9719), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9721) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9722), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9726), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9727), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9729), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9731), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9732), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9734), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9736), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9739), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9741), "Low" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4151), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4159), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4161), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4165), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4166), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4168), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4170), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4172), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4174), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4177), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4180), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4185), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4187), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4188), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4191), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4196), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4199), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4201), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4205), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4207), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4208), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4212), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4213), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4215) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4219), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4220), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4223), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4225), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4226), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4314), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4316), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4318), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4322), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4326), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4327), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4329), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4333), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4335), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4342), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4343), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4345), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4347) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4348), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4349), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4353), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4356), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4358), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4359), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4365), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4367), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4368), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4370), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4373), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4374), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4378), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4383), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4385), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4386), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4389), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4393), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4394), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4396), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4398), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4400), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4401), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4403), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4406), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4408), "High" });
        }
    }
}
