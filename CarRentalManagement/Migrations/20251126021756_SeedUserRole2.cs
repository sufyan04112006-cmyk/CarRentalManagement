using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "820b69c9-32f9-4356-adcc-f0d09de8296d", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMKEm5o9ClDT+YFMSyVGJAdJO7SjUOuFtC018HhHgr5Cnb6vwsAexqU+UoPao+s9fw==", null, false, "1953e9bb-d00a-47ce-bcde-b509d71dabc9", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 17, 55, 681, DateTimeKind.Local).AddTicks(7055), new DateTime(2025, 11, 26, 10, 17, 55, 681, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 17, 55, 681, DateTimeKind.Local).AddTicks(7076), new DateTime(2025, 11, 26, 10, 17, 55, 681, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 17, 55, 681, DateTimeKind.Local).AddTicks(7330), new DateTime(2025, 11, 26, 10, 17, 55, 681, DateTimeKind.Local).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 17, 55, 681, DateTimeKind.Local).AddTicks(7333), new DateTime(2025, 11, 26, 10, 17, 55, 681, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 17, 55, 681, DateTimeKind.Local).AddTicks(7441), new DateTime(2025, 11, 26, 10, 17, 55, 681, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 17, 55, 681, DateTimeKind.Local).AddTicks(7445), new DateTime(2025, 11, 26, 10, 17, 55, 681, DateTimeKind.Local).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 17, 55, 681, DateTimeKind.Local).AddTicks(7447), new DateTime(2025, 11, 26, 10, 17, 55, 681, DateTimeKind.Local).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 10, 17, 55, 681, DateTimeKind.Local).AddTicks(7450), new DateTime(2025, 11, 26, 10, 17, 55, 681, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

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
    }
}
