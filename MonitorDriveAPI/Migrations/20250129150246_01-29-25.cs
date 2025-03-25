using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonitorDriveAPI.Migrations
{
    /// <inheritdoc />
    public partial class _012925 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Miles = table.Column<float>(type: "real", nullable: false),
                    Percent_usage = table.Column<float>(type: "real", nullable: false),
                    Insurage = table.Column<float>(type: "real", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mpg = table.Column<float>(type: "real", nullable: false),
                    Autonomy = table.Column<float>(type: "real", nullable: false),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicles_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e7be918-25ea-4407-9fcc-a6c0608b71af"),
                columns: new[] { "Created_at", "Update_at" },
                values: new object[] { new DateTime(2025, 1, 29, 10, 2, 45, 823, DateTimeKind.Local).AddTicks(3307), new DateTime(2025, 1, 29, 10, 2, 45, 823, DateTimeKind.Local).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d68c8b1d-2cf4-4f16-8dab-f6b49a5fce47"),
                columns: new[] { "Created_at", "Update_at" },
                values: new object[] { new DateTime(2025, 1, 29, 10, 2, 45, 823, DateTimeKind.Local).AddTicks(3235), new DateTime(2025, 1, 29, 10, 2, 45, 823, DateTimeKind.Local).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4eb9db7-793d-41cf-803f-755e7a495ab5"),
                columns: new[] { "Created_at", "Update_at" },
                values: new object[] { new DateTime(2025, 1, 29, 10, 2, 45, 823, DateTimeKind.Local).AddTicks(3311), new DateTime(2025, 1, 29, 10, 2, 45, 823, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_DriverId",
                table: "Vehicles",
                column: "DriverId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3e7be918-25ea-4407-9fcc-a6c0608b71af"),
                columns: new[] { "Created_at", "Update_at" },
                values: new object[] { new DateTime(2024, 9, 28, 11, 35, 27, 860, DateTimeKind.Local).AddTicks(6100), new DateTime(2024, 9, 28, 11, 35, 27, 860, DateTimeKind.Local).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d68c8b1d-2cf4-4f16-8dab-f6b49a5fce47"),
                columns: new[] { "Created_at", "Update_at" },
                values: new object[] { new DateTime(2024, 9, 28, 11, 35, 27, 860, DateTimeKind.Local).AddTicks(6045), new DateTime(2024, 9, 28, 11, 35, 27, 860, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e4eb9db7-793d-41cf-803f-755e7a495ab5"),
                columns: new[] { "Created_at", "Update_at" },
                values: new object[] { new DateTime(2024, 9, 28, 11, 35, 27, 860, DateTimeKind.Local).AddTicks(6105), new DateTime(2024, 9, 28, 11, 35, 27, 860, DateTimeKind.Local).AddTicks(6106) });
        }
    }
}
