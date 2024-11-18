using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

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
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "d7cf9ba2-819b-40c3-a4c1-ba9f0e3dd024", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEBpdnGVb0TPXXYCIKV4BZYIULAwnwHgoTyiR44clp6OSg/kF4pNUs885QCA4xTpJEg==", null, false, "11e3354b-03cc-41bc-abb9-39187d235d3f", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 37, 8, 760, DateTimeKind.Local).AddTicks(4091), new DateTime(2024, 11, 18, 17, 37, 8, 760, DateTimeKind.Local).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 37, 8, 760, DateTimeKind.Local).AddTicks(4103), new DateTime(2024, 11, 18, 17, 37, 8, 760, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 37, 8, 760, DateTimeKind.Local).AddTicks(4254), new DateTime(2024, 11, 18, 17, 37, 8, 760, DateTimeKind.Local).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 37, 8, 760, DateTimeKind.Local).AddTicks(4256), new DateTime(2024, 11, 18, 17, 37, 8, 760, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 37, 8, 760, DateTimeKind.Local).AddTicks(4316), new DateTime(2024, 11, 18, 17, 37, 8, 760, DateTimeKind.Local).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 37, 8, 760, DateTimeKind.Local).AddTicks(4318), new DateTime(2024, 11, 18, 17, 37, 8, 760, DateTimeKind.Local).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 37, 8, 760, DateTimeKind.Local).AddTicks(4320), new DateTime(2024, 11, 18, 17, 37, 8, 760, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 37, 8, 760, DateTimeKind.Local).AddTicks(4321), new DateTime(2024, 11, 18, 17, 37, 8, 760, DateTimeKind.Local).AddTicks(4321) });

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
                values: new object[] { new DateTime(2024, 11, 18, 17, 12, 43, 303, DateTimeKind.Local).AddTicks(5444), new DateTime(2024, 11, 18, 17, 12, 43, 303, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 12, 43, 303, DateTimeKind.Local).AddTicks(5456), new DateTime(2024, 11, 18, 17, 12, 43, 303, DateTimeKind.Local).AddTicks(5457) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 12, 43, 303, DateTimeKind.Local).AddTicks(5602), new DateTime(2024, 11, 18, 17, 12, 43, 303, DateTimeKind.Local).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 12, 43, 303, DateTimeKind.Local).AddTicks(5604), new DateTime(2024, 11, 18, 17, 12, 43, 303, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 12, 43, 303, DateTimeKind.Local).AddTicks(5667), new DateTime(2024, 11, 18, 17, 12, 43, 303, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 12, 43, 303, DateTimeKind.Local).AddTicks(5669), new DateTime(2024, 11, 18, 17, 12, 43, 303, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 12, 43, 303, DateTimeKind.Local).AddTicks(5671), new DateTime(2024, 11, 18, 17, 12, 43, 303, DateTimeKind.Local).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 17, 12, 43, 303, DateTimeKind.Local).AddTicks(5672), new DateTime(2024, 11, 18, 17, 12, 43, 303, DateTimeKind.Local).AddTicks(5672) });
        }
    }
}
