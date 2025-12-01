using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 11, 28, 492, DateTimeKind.Local).AddTicks(3776), new DateTime(2025, 11, 26, 10, 11, 28, 492, DateTimeKind.Local).AddTicks(3798) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 11, 28, 492, DateTimeKind.Local).AddTicks(3803), new DateTime(2025, 11, 26, 10, 11, 28, 492, DateTimeKind.Local).AddTicks(3805) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 11, 28, 492, DateTimeKind.Local).AddTicks(4135), new DateTime(2025, 11, 26, 10, 11, 28, 492, DateTimeKind.Local).AddTicks(4136) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 11, 28, 492, DateTimeKind.Local).AddTicks(4140), new DateTime(2025, 11, 26, 10, 11, 28, 492, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 11, 28, 492, DateTimeKind.Local).AddTicks(4286), new DateTime(2025, 11, 26, 10, 11, 28, 492, DateTimeKind.Local).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 11, 28, 492, DateTimeKind.Local).AddTicks(4290), new DateTime(2025, 11, 26, 10, 11, 28, 492, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 11, 28, 492, DateTimeKind.Local).AddTicks(4294), new DateTime(2025, 11, 26, 10, 11, 28, 492, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 11, 28, 492, DateTimeKind.Local).AddTicks(4298), new DateTime(2025, 11, 26, 10, 11, 28, 492, DateTimeKind.Local).AddTicks(4299) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 35, 85, DateTimeKind.Local).AddTicks(5287), new DateTime(2025, 11, 26, 9, 30, 35, 85, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 35, 85, DateTimeKind.Local).AddTicks(5304), new DateTime(2025, 11, 26, 9, 30, 35, 85, DateTimeKind.Local).AddTicks(5305) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 35, 85, DateTimeKind.Local).AddTicks(5508), new DateTime(2025, 11, 26, 9, 30, 35, 85, DateTimeKind.Local).AddTicks(5509) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 35, 85, DateTimeKind.Local).AddTicks(5511), new DateTime(2025, 11, 26, 9, 30, 35, 85, DateTimeKind.Local).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 35, 85, DateTimeKind.Local).AddTicks(5605), new DateTime(2025, 11, 26, 9, 30, 35, 85, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 35, 85, DateTimeKind.Local).AddTicks(5608), new DateTime(2025, 11, 26, 9, 30, 35, 85, DateTimeKind.Local).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 35, 85, DateTimeKind.Local).AddTicks(5610), new DateTime(2025, 11, 26, 9, 30, 35, 85, DateTimeKind.Local).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 30, 35, 85, DateTimeKind.Local).AddTicks(5612), new DateTime(2025, 11, 26, 9, 30, 35, 85, DateTimeKind.Local).AddTicks(5613) });
        }
    }
}
