using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 43, 49, 614, DateTimeKind.Local).AddTicks(217), new DateTime(2025, 11, 24, 11, 43, 49, 614, DateTimeKind.Local).AddTicks(236), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 43, 49, 614, DateTimeKind.Local).AddTicks(238), new DateTime(2025, 11, 24, 11, 43, 49, 614, DateTimeKind.Local).AddTicks(239), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 43, 49, 614, DateTimeKind.Local).AddTicks(468), new DateTime(2025, 11, 24, 11, 43, 49, 614, DateTimeKind.Local).AddTicks(469), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 43, 49, 614, DateTimeKind.Local).AddTicks(472), new DateTime(2025, 11, 24, 11, 43, 49, 614, DateTimeKind.Local).AddTicks(472), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 11, 43, 49, 614, DateTimeKind.Local).AddTicks(560), new DateTime(2025, 11, 24, 11, 43, 49, 614, DateTimeKind.Local).AddTicks(561), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 11, 43, 49, 614, DateTimeKind.Local).AddTicks(563), new DateTime(2025, 11, 24, 11, 43, 49, 614, DateTimeKind.Local).AddTicks(563), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 11, 43, 49, 614, DateTimeKind.Local).AddTicks(565), new DateTime(2025, 11, 24, 11, 43, 49, 614, DateTimeKind.Local).AddTicks(566), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 11, 43, 49, 614, DateTimeKind.Local).AddTicks(567), new DateTime(2025, 11, 24, 11, 43, 49, 614, DateTimeKind.Local).AddTicks(568), "Blue", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
