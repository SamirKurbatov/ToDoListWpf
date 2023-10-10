using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoList.Migrations
{
    /// <inheritdoc />
    public partial class Notes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4151), "Low" });

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
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4161), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4163), "Low" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4175), "High" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4178), "Medium" });

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
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4182), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4183), "High" });

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
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4187), "Low" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4190), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4191), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4193), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4195), "High" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4198), "Medium" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4203), "Low" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4210), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4212), "Low" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4215), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4217), "High" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4222), "Medium" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4228), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4314), "High" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4318), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4320), "Low" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4324), "High" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4329), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4331), "Low" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4337), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4338), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4340), "High" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4347), "Medium" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4351), "Medium" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4354), "Medium" });

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
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4358), "Medium" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4361), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4362), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4364), "Medium" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4370), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4371), "Low" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4376), "Medium" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4379), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4381), "High" });

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
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4388), "Low" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4391), "Medium" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4401), "Low" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4405), "Low" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 12, 59, 19, 457, DateTimeKind.Utc).AddTicks(4408), "High" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Приоритет Medium" });
        }
    }
}
