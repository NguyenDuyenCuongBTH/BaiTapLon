using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BTL_Nhom03;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BTL_Nhom03.Nhanvien> Nhanvien { get; set; } = default!;

        public DbSet<BTL_Nhom03.Khachhang> Khachhang { get; set; } = default!;

        public DbSet<BTL_Nhom03.Nhacungcap> Nhacungcap { get; set; } = default!;

        public DbSet<BTL_Nhom03.Sanpham> Sanpham { get; set; } = default!;

        public DbSet<BTL_Nhom03.Donhang> Donhang { get; set; } = default!;
    }
