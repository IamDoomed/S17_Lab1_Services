using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZombieParty.Migrations
{
    /// <inheritdoc />
    public partial class IsDisponible01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDisponible",
                table: "ZombieTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "ZombieTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsDisponible",
                value: false);

            migrationBuilder.UpdateData(
                table: "ZombieTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsDisponible",
                value: false);

            migrationBuilder.UpdateData(
                table: "ZombieTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsDisponible",
                value: false);

            migrationBuilder.UpdateData(
                table: "ZombieTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsDisponible",
                value: false);

            migrationBuilder.UpdateData(
                table: "ZombieTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsDisponible",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDisponible",
                table: "ZombieTypes");
        }
    }
}
