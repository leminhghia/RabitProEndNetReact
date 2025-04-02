using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Data.Migrations
{
    /// <inheritdoc />
    public partial class ThuongHieu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SanPham_ThuongHieu_ThuongHieuId",
                table: "SanPham");

            migrationBuilder.DropIndex(
                name: "IX_SanPham_ThuongHieuId",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "ThuongHieuId",
                table: "SanPham");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ThuongHieuId",
                table: "SanPham",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_ThuongHieuId",
                table: "SanPham",
                column: "ThuongHieuId");

            migrationBuilder.AddForeignKey(
                name: "FK_SanPham_ThuongHieu_ThuongHieuId",
                table: "SanPham",
                column: "ThuongHieuId",
                principalTable: "ThuongHieu",
                principalColumn: "ThuongHieuId");
        }
    }
}
