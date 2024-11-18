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
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Customer_CustomerId",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_CustomerId",
                table: "Booking");

            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4694), new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4704), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4706), new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4706), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4855), new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4855), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4857), new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4857), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4924), new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4924), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4926), new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4926), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4927), new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4927), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4928), new DateTime(2024, 11, 18, 16, 31, 46, 968, DateTimeKind.Local).AddTicks(4929), "C-HR", "System" }
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

            migrationBuilder.CreateIndex(
                name: "IX_Booking_CustomerId",
                table: "Booking",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Customer_CustomerId",
                table: "Booking",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
