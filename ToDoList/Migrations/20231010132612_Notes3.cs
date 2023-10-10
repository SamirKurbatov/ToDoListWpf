using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoList.Migrations
{
    /// <inheritdoc />
    public partial class Notes3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3009), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3011), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3013), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3015), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3019), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3022), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3024), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3028), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3031), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3033), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3034), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3037), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3039), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3041), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3044), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3046), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3052), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3053), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3055), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3057), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3061), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3066), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3068), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3069), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3070), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3117), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3119), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3121), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3125), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3127) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3128), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3130), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3131), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3133), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3135), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3136), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3139), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3141), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3142), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3147), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3157), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3159), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3164), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3167), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3168), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3172), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3173), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3175), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3176), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3178), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3181) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3187), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3190), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3191), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3193), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3195), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3197), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3200), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3208), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3210), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 13, 26, 12, 490, DateTimeKind.Utc).AddTicks(3213), "Medium" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9456) });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9466), "Low" });

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
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9470) });

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
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9548) });

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
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9555) });

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
                column: "CreatedDate",
                value: new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9559));

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9562), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9564), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9566) });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9571), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9574), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9576), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9577) });

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
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9581) });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9584), "Low" });

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
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9590) });

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
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9595) });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9598), "High" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9603), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9604) });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9609), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9614), "High" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9619), "High" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9625), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9626), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9628) });

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
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9631), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9632), "Low" });

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
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9636) });

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
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9639) });

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
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 6, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9642) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9644) });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9650), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9653) });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9658), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 10, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9660), "Medium" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9663), "High" });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9666), "Low" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9668), "Low" });

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
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 9, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9671) });

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
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9674) });

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
                column: "CreatedDate",
                value: new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9677));

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
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 7, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9681) });

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
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9721), "Low" });

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
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9724), "Medium" });

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
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9727) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedDate", "Priority" },
                values: new object[] { new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9729), "High" });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 3, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 5, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9732) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 4, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9734) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 8, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "Notes",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CategoryId", "CreatedDate", "Priority" },
                values: new object[] { 2, new DateTime(2023, 10, 10, 13, 12, 57, 891, DateTimeKind.Utc).AddTicks(9738), "Low" });

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
    }
}
