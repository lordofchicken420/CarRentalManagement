using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMakeSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 41, 14, 287, DateTimeKind.Local).AddTicks(5694), new DateTime(2024, 11, 18, 16, 41, 14, 287, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 41, 14, 287, DateTimeKind.Local).AddTicks(5705), new DateTime(2024, 11, 18, 16, 41, 14, 287, DateTimeKind.Local).AddTicks(5706) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 41, 14, 287, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 11, 18, 16, 41, 14, 287, DateTimeKind.Local).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Name" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 41, 14, 287, DateTimeKind.Local).AddTicks(5832), new DateTime(2024, 11, 18, 16, 41, 14, 287, DateTimeKind.Local).AddTicks(5833), "Toyota" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 41, 14, 287, DateTimeKind.Local).AddTicks(5883), new DateTime(2024, 11, 18, 16, 41, 14, 287, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 41, 14, 287, DateTimeKind.Local).AddTicks(5884), new DateTime(2024, 11, 18, 16, 41, 14, 287, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 41, 14, 287, DateTimeKind.Local).AddTicks(5886), new DateTime(2024, 11, 18, 16, 41, 14, 287, DateTimeKind.Local).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 41, 14, 287, DateTimeKind.Local).AddTicks(5887), new DateTime(2024, 11, 18, 16, 41, 14, 287, DateTimeKind.Local).AddTicks(5888) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4694), new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4706), new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4855), new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "Name" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4857), new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4857), "BMW" });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4924), new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4926), new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4927), new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4928), new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4929) });
        }
    }
}
