﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BTLNhom03.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230426095849_Sanpham")]
    partial class Sanpham
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("BTL_Nhom03.Khachhang", b =>
                {
                    b.Property<string>("MaKhachHang")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Sdt")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenKhachHang")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaKhachHang");

                    b.ToTable("Khachhang");
                });

            modelBuilder.Entity("BTL_Nhom03.Nhacungcap", b =>
                {
                    b.Property<string>("MaNCC")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sdt")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenNCC")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaNCC");

                    b.ToTable("Nhacungcap");
                });

            modelBuilder.Entity("BTL_Nhom03.Nhanvien", b =>
                {
                    b.Property<string>("MaNhanVien")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Sdt")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenNhanVien")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaNhanVien");

                    b.ToTable("Nhanvien");
                });

            modelBuilder.Entity("BTL_Nhom03.Sanpham", b =>
                {
                    b.Property<string>("MaSP")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("GiaTien")
                        .HasColumnType("TEXT");

                    b.Property<string>("MauSac")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Size")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("SoLuong")
                        .HasColumnType("TEXT");

                    b.Property<string>("TenSP")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaSP");

                    b.ToTable("Sanpham");
                });
#pragma warning restore 612, 618
        }
    }
}
