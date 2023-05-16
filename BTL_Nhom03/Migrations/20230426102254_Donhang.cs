using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTLNhom03.Migrations
{
    /// <inheritdoc />
    public partial class Donhang : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donhang",
                columns: table => new
                {
                    MaDonHang = table.Column<string>(type: "TEXT", nullable: false),
                    MaKhachHang = table.Column<string>(type: "TEXT", nullable: false),
                    MaSP = table.Column<string>(type: "TEXT", nullable: false),
                    GiaTien = table.Column<decimal>(type: "TEXT", nullable: false),
                    NgayBan = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donhang", x => x.MaDonHang);
                    table.ForeignKey(
                        name: "FK_Donhang_Khachhang_MaKhachHang",
                        column: x => x.MaKhachHang,
                        principalTable: "Khachhang",
                        principalColumn: "MaKhachHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donhang_Sanpham_MaSP",
                        column: x => x.MaSP,
                        principalTable: "Sanpham",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Donhang_MaKhachHang",
                table: "Donhang",
                column: "MaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_Donhang_MaSP",
                table: "Donhang",
                column: "MaSP");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donhang");
        }
    }
}
