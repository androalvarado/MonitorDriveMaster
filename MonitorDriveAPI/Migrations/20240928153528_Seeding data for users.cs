using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MonitorDriveAPI.Migrations
{
    /// <inheritdoc />
    public partial class Seedingdataforusers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created_at", "Email", "Image", "Name", "Password", "Update_at" },
                values: new object[,]
                {
                    { new Guid("3e7be918-25ea-4407-9fcc-a6c0608b71af"), new DateTime(2024, 9, 28, 11, 35, 27, 860, DateTimeKind.Local).AddTicks(6100), "sara@email.com", "https://images.pexels.com/photos/3779760/pexels-photo-3779760.jpeg?auto=compress&cs=tinysrgb&w=600", "Sara", "V4Z9!yQUG!k", new DateTime(2024, 9, 28, 11, 35, 27, 860, DateTimeKind.Local).AddTicks(6101) },
                    { new Guid("d68c8b1d-2cf4-4f16-8dab-f6b49a5fce47"), new DateTime(2024, 9, 28, 11, 35, 27, 860, DateTimeKind.Local).AddTicks(6045), "andrew@email.com", "https://images.pexels.com/photos/697509/pexels-photo-697509.jpeg?auto=compress&cs=tinysrgb&w=600", "Andrew", "d*fTcq9w%qJ", new DateTime(2024, 9, 28, 11, 35, 27, 860, DateTimeKind.Local).AddTicks(6092) },
                    { new Guid("e4eb9db7-793d-41cf-803f-755e7a495ab5"), new DateTime(2024, 9, 28, 11, 35, 27, 860, DateTimeKind.Local).AddTicks(6105), "roger@email.com", "https://images.pexels.com/photos/3760260/pexels-photo-3760260.jpeg?auto=compress&cs=tinysrgb&w=600", "Roger", "Fr5XQvQ&gbT", new DateTime(2024, 9, 28, 11, 35, 27, 860, DateTimeKind.Local).AddTicks(6106) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e7be918-25ea-4407-9fcc-a6c0608b71af"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d68c8b1d-2cf4-4f16-8dab-f6b49a5fce47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4eb9db7-793d-41cf-803f-755e7a495ab5"));
        }
    }
}
