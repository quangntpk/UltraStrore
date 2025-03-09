﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UltraStrore.Data;

#nullable disable

namespace UltraStrore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250307141158_sdfj")]
    partial class sdfj
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UltraStrore.Data.BinhLuan", b =>
                {
                    b.Property<int>("MaBinhLuan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ma_binh_luan");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaBinhLuan"));

                    b.Property<double?>("DanhGia")
                        .HasColumnType("float")
                        .HasColumnName("danh_gia");

                    b.Property<string>("MaNguoiDung")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("ma_nguoi_dung");

                    b.Property<string>("MaSanPham")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("ma_san_pham");

                    b.Property<string>("NoiDungBinhLuan")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("noi_dung_binh_luan");

                    b.Property<int?>("SoTimBinhLuan")
                        .HasColumnType("int")
                        .HasColumnName("so_tim_binh_luan");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("MaBinhLuan")
                        .HasName("PK__BINH_LUA__300DD2D899CEB418");

                    b.HasIndex(new[] { "MaSanPham" }, "IX_BINH_LUAN_ma_san_pham");

                    b.ToTable("BINH_LUAN", (string)null);
                });

            modelBuilder.Entity("UltraStrore.Data.ChiTietComBo", b =>
                {
                    b.Property<int>("MaChiTietComBo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ma_chi_tiet_com_bo");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaChiTietComBo"));

                    b.Property<int?>("MaComBo")
                        .HasColumnType("int")
                        .HasColumnName("ma_com_bo");

                    b.Property<string>("MaSanPham")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("ma_san_pham");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int")
                        .HasColumnName("so_luong");

                    b.HasKey("MaChiTietComBo")
                        .HasName("PK__CHI_TIET__1B885A91D07009B0");

                    b.HasIndex(new[] { "MaComBo" }, "IX_CHI_TIET_COM_BO_ma_com_bo");

                    b.HasIndex(new[] { "MaSanPham" }, "IX_CHI_TIET_COM_BO_ma_san_pham");

                    b.ToTable("CHI_TIET_COM_BO", (string)null);
                });

            modelBuilder.Entity("UltraStrore.Data.ChiTietDonHang", b =>
                {
                    b.Property<int>("MaCtdh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ma_ctdh");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaCtdh"));

                    b.Property<int?>("Gia")
                        .HasColumnType("int")
                        .HasColumnName("gia");

                    b.Property<int?>("MaCombo")
                        .HasColumnType("int")
                        .HasColumnName("ma_combo");

                    b.Property<string>("MaDonHang")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("ma_don_hang");

                    b.Property<string>("MaSanPham")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("ma_san_pham");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int")
                        .HasColumnName("so_luong");

                    b.Property<int?>("ThanhTien")
                        .HasColumnType("int")
                        .HasColumnName("thanh_tien");

                    b.HasKey("MaCtdh")
                        .HasName("PK__CHI_TIET__5AE49D8E95395895");

                    b.HasIndex(new[] { "MaCombo" }, "IX_CHI_TIET_DON_HANG_ma_combo");

                    b.ToTable("CHI_TIET_DON_HANG", (string)null);
                });

            modelBuilder.Entity("UltraStrore.Data.ChiTietGioHang", b =>
                {
                    b.Property<int>("MaCtgh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ma_ctgh");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaCtgh"));

                    b.Property<int?>("Gia")
                        .HasColumnType("int")
                        .HasColumnName("gia");

                    b.Property<int?>("MaCombo")
                        .HasColumnType("int")
                        .HasColumnName("ma_combo");

                    b.Property<int?>("MaGioHang")
                        .HasColumnType("int")
                        .HasColumnName("ma_gio_hang");

                    b.Property<string>("MaSanPham")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("ma_san_pham");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int")
                        .HasColumnName("so_luong");

                    b.Property<int?>("ThanhTien")
                        .HasColumnType("int")
                        .HasColumnName("thanh_tien");

                    b.HasKey("MaCtgh")
                        .HasName("PK__CHI_TIET__5AE495EDA6F2A925");

                    b.HasIndex(new[] { "MaCombo" }, "IX_CHI_TIET_GIO_HANG_ma_combo");

                    b.HasIndex(new[] { "MaGioHang" }, "IX_CHI_TIET_GIO_HANG_ma_gio_hang");

                    b.HasIndex(new[] { "MaSanPham" }, "IX_CHI_TIET_GIO_HANG_ma_san_pham");

                    b.ToTable("CHI_TIET_GIO_HANG", (string)null);
                });

            modelBuilder.Entity("UltraStrore.Data.ComBoSanPham", b =>
                {
                    b.Property<int>("MaComBo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ma_com_bo");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaComBo"));

                    b.Property<string>("MoTa")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("mo_ta");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int")
                        .HasColumnName("so_luong");

                    b.Property<string>("TenComBo")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ten_com_bo");

                    b.Property<string>("TenHinhAnh")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ten_hinh_anh");

                    b.Property<double?>("TongGia")
                        .HasColumnType("float")
                        .HasColumnName("tong_gia");

                    b.Property<bool?>("TrangThai")
                        .HasColumnType("bit")
                        .HasColumnName("trang_thai");

                    b.HasKey("MaComBo")
                        .HasName("PK__COM_BO_S__AF6434A35D0F47EB");

                    b.ToTable("COM_BO_SAN_PHAM", (string)null);
                });

            modelBuilder.Entity("UltraStrore.Data.DanhSachDiaChi", b =>
                {
                    b.Property<int>("MaDiaChi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ma_dia_chi");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaDiaChi"));

                    b.Property<string>("DiaChi")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("dia_chi");

                    b.Property<string>("HoTen")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ho_ten");

                    b.Property<string>("MaNguoiDung")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ma_nguoi_dung");

                    b.Property<string>("MoTa")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("mo_ta");

                    b.Property<string>("Sdt")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("sdt");

                    b.Property<bool?>("TrangThai")
                        .HasColumnType("bit")
                        .HasColumnName("trang_thai");

                    b.HasKey("MaDiaChi")
                        .HasName("PK__DANH_SAC__80439859B4824340");

                    b.HasIndex(new[] { "MaNguoiDung" }, "IX_DANH_SACH_DIA_CHI_ma_nguoi_dung");

                    b.ToTable("DANH_SACH_DIA_CHI", (string)null);
                });

            modelBuilder.Entity("UltraStrore.Data.DonHang", b =>
                {
                    b.Property<int>("MaDonHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ma_don_hang");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaDonHang"));

                    b.Property<string>("DiaChi")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("dia_chi");

                    b.Property<string>("LyDoHuy")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("ly_do_huy");

                    b.Property<string>("MaNguoiDung")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ma_nguoi_dung");

                    b.Property<string>("MaNhanVien")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ma_nhan_vien");

                    b.Property<DateTime?>("NgayDat")
                        .HasColumnType("date")
                        .HasColumnName("ngay_dat");

                    b.Property<string>("Sdt")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("sdt");

                    b.Property<string>("TenNguoiNhan")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ten_nguoi_nhan");

                    b.Property<string>("TrangThaiDonHang")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("trang_thai_don_hang");

                    b.Property<string>("TrangThaiHang")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("trang_thai_hang");

                    b.HasKey("MaDonHang")
                        .HasName("PK__DON_HANG__0246C5EAB291F99F");

                    b.HasIndex(new[] { "MaNguoiDung" }, "IX_DON_HANG_ma_nguoi_dung");

                    b.HasIndex(new[] { "MaNhanVien" }, "IX_DON_HANG_ma_nhan_vien");

                    b.ToTable("DON_HANG", (string)null);
                });

            modelBuilder.Entity("UltraStrore.Data.GioHang", b =>
                {
                    b.Property<int>("MaGioHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ma_gio_hang");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaGioHang"));

                    b.Property<string>("MaNguoiDung")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ma_nguoi_dung");

                    b.HasKey("MaGioHang")
                        .HasName("PK__GIO_HANG__6C00DDA3D3ED86DE");

                    b.HasIndex(new[] { "MaNguoiDung" }, "IX_GIO_HANG_ma_nguoi_dung");

                    b.ToTable("GIO_HANG", (string)null);
                });

            modelBuilder.Entity("UltraStrore.Data.HinhAnh", b =>
                {
                    b.Property<int>("MaHinhAnh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ma_hinh_anh");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaHinhAnh"));

                    b.Property<int?>("MaBinhLuan")
                        .HasColumnType("int")
                        .HasColumnName("ma_binh_luan");

                    b.Property<string>("MaSanPham")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("ma_san_pham");

                    b.Property<string>("TenHinhAnh")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ten_hinh_anh");

                    b.HasKey("MaHinhAnh")
                        .HasName("PK__HINH_ANH__5AE49D8E2E189F36");

                    b.HasIndex(new[] { "MaBinhLuan" }, "IX_HINH_ANH_ma_binh_luan");

                    b.HasIndex(new[] { "MaSanPham" }, "IX_HINH_ANH_ma_san_pham");

                    b.ToTable("HINH_ANH", (string)null);
                });

            modelBuilder.Entity("UltraStrore.Data.LoaiSanPham", b =>
                {
                    b.Property<int>("MaLoaiSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ma_loai_san_pham");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaLoaiSanPham"));

                    b.Property<string>("TenLoaiSanPham")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ten_loai_san_pham");

                    b.HasKey("MaLoaiSanPham")
                        .HasName("PK__LOAI_SAN__7FEA3693092D4574");

                    b.ToTable("LOAI_SAN_PHAM", (string)null);
                });

            modelBuilder.Entity("UltraStrore.Data.NguoiDung", b =>
                {
                    b.Property<string>("MaNguoiDung")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ma_nguoi_dung");

                    b.Property<string>("Cccd")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("cccd");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("dia_chi");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("HinhAnh")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("hinh_anh");

                    b.Property<string>("HoTen")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ho_ten");

                    b.Property<string>("MatKhau")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("mat_khau");

                    b.Property<string>("MoTa")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("mo_ta");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("date")
                        .HasColumnName("ngay_sinh");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("date")
                        .HasColumnName("ngay_tao");

                    b.Property<string>("Sdt")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("sdt");

                    b.Property<string>("TaiKhoan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("trang_thai");

                    b.Property<int?>("VaiTro")
                        .HasColumnType("int");

                    b.HasKey("MaNguoiDung")
                        .HasName("PK__NGUOI_DU__19C32CF72B9CA41E");

                    b.ToTable("NGUOI_DUNG", (string)null);
                });

            modelBuilder.Entity("UltraStrore.Data.SanPham", b =>
                {
                    b.Property<string>("MaSanPham")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("ma_san_pham");

                    b.Property<string>("ChatLieu")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("chat_lieu");

                    b.Property<int?>("Gia")
                        .HasColumnType("int")
                        .HasColumnName("gia");

                    b.Property<string>("KichThuoc")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("kich_thuoc")
                        .IsFixedLength();

                    b.Property<string>("MaComBo")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("ma_com_bo");

                    b.Property<int?>("MaLoaiSanPham")
                        .HasColumnType("int")
                        .HasColumnName("ma_loai_san_pham");

                    b.Property<int?>("MaThuongHieu")
                        .HasColumnType("int")
                        .HasColumnName("ma_thuong_hieu");

                    b.Property<string>("MoTa")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("mo_ta");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("date")
                        .HasColumnName("ngay_tao");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int")
                        .HasColumnName("so_luong");

                    b.Property<string>("TenSanPham")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ten_san_pham");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("trang_thai");

                    b.HasKey("MaSanPham")
                        .HasName("PK__SAN_PHAM__9D25990C2713A687");

                    b.HasIndex(new[] { "MaLoaiSanPham" }, "IX_SAN_PHAM_ma_loai_san_pham");

                    b.HasIndex(new[] { "MaThuongHieu" }, "IX_SAN_PHAM_ma_thuong_hieu");

                    b.ToTable("SAN_PHAM", (string)null);
                });

            modelBuilder.Entity("UltraStrore.Data.ThuongHieu", b =>
                {
                    b.Property<int>("MaThuongHieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ma_thuong_hieu");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaThuongHieu"));

                    b.Property<string>("TenThuongHieu")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ten_thuong_hieu");

                    b.HasKey("MaThuongHieu")
                        .HasName("PK__THUONG_H__C4FB3F32AE837BB2");

                    b.ToTable("THUONG_HIEU", (string)null);
                });

            modelBuilder.Entity("UltraStrore.Data.Video", b =>
                {
                    b.Property<int>("MaVideo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ma_video");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaVideo"));

                    b.Property<string>("MaSanPham")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("ma_san_pham");

                    b.Property<string>("TenVideo")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ten_video");

                    b.HasKey("MaVideo")
                        .HasName("PK__VIDEO__946AD5B8DC15860F");

                    b.HasIndex(new[] { "MaSanPham" }, "IX_VIDEO_ma_san_pham");

                    b.ToTable("VIDEO", (string)null);
                });

            modelBuilder.Entity("UltraStrore.Data.Voucher", b =>
                {
                    b.Property<string>("MaVoucher")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("ma_voucher");

                    b.Property<decimal?>("DieuKien")
                        .HasColumnType("decimal(18, 0)")
                        .HasColumnName("dieu_kien");

                    b.Property<double?>("GiamGia")
                        .HasColumnType("float")
                        .HasColumnName("giam_gia");

                    b.Property<string>("MoTa")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("mo_ta");

                    b.Property<DateTime?>("NgayBatDau")
                        .HasColumnType("date")
                        .HasColumnName("ngay_bat_dau");

                    b.Property<DateTime?>("NgayKetThuc")
                        .HasColumnType("date")
                        .HasColumnName("ngay_ket_thuc");

                    b.Property<int?>("SoLuong")
                        .HasColumnType("int")
                        .HasColumnName("so_luong");

                    b.Property<string>("TenVoucher")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ten_voucher");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int")
                        .HasColumnName("trang_thai");

                    b.HasKey("MaVoucher")
                        .HasName("PK__VOUCHER__466D17BE6217DC60");

                    b.ToTable("VOUCHER", (string)null);
                });

            modelBuilder.Entity("UltraStrore.Data.YeuThich", b =>
                {
                    b.Property<int>("MaYeuThich")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ma_yeu_thich");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaYeuThich"));

                    b.Property<string>("MaNguoiDung")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ma_nguoi_dung");

                    b.Property<string>("MaNguoiDungNavigationMaNguoiDung")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaSanPham")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("ma_san_pham");

                    b.Property<DateTime?>("NgayYeuThich")
                        .HasColumnType("date")
                        .HasColumnName("ngay_yeu_thich");

                    b.Property<int?>("SoLuongYeuThich")
                        .HasColumnType("int")
                        .HasColumnName("so_luong_yeu_thich");

                    b.HasKey("MaYeuThich")
                        .HasName("PK__YEU_THIC__6427C4C6C61640D4");

                    b.HasIndex("MaNguoiDungNavigationMaNguoiDung");

                    b.HasIndex(new[] { "MaSanPham" }, "IX_YEU_THICH_ma_san_pham");

                    b.ToTable("YEU_THICH", (string)null);
                });

            modelBuilder.Entity("UltraStrore.Data.BinhLuan", b =>
                {
                    b.HasOne("UltraStrore.Data.SanPham", "MaSanPhamNavigation")
                        .WithMany("BinhLuans")
                        .HasForeignKey("MaSanPham")
                        .HasConstraintName("FK_BINH_LUAN_SAN_PHAM");

                    b.Navigation("MaSanPhamNavigation");
                });

            modelBuilder.Entity("UltraStrore.Data.ChiTietComBo", b =>
                {
                    b.HasOne("UltraStrore.Data.ComBoSanPham", "MaComBoNavigation")
                        .WithMany("ChiTietComBos")
                        .HasForeignKey("MaComBo")
                        .HasConstraintName("FK_CHI_TIET_COM_BO_COM_BO_SAN_PHAM");

                    b.HasOne("UltraStrore.Data.SanPham", "MaSanPhamNavigation")
                        .WithMany("ChiTietComBos")
                        .HasForeignKey("MaSanPham")
                        .HasConstraintName("FK_CHI_TIET_COM_BO_SAN_PHAM");

                    b.Navigation("MaComBoNavigation");

                    b.Navigation("MaSanPhamNavigation");
                });

            modelBuilder.Entity("UltraStrore.Data.ChiTietDonHang", b =>
                {
                    b.HasOne("UltraStrore.Data.ComBoSanPham", "MaComboNavigation")
                        .WithMany("ChiTietDonHangs")
                        .HasForeignKey("MaCombo")
                        .HasConstraintName("FK_CHI_TIET_DON_HANG_COM_BO_SAN_PHAM");

                    b.Navigation("MaComboNavigation");
                });

            modelBuilder.Entity("UltraStrore.Data.ChiTietGioHang", b =>
                {
                    b.HasOne("UltraStrore.Data.ComBoSanPham", "MaComboNavigation")
                        .WithMany("ChiTietGioHangs")
                        .HasForeignKey("MaCombo")
                        .HasConstraintName("FK_CHI_TIET_GIO_HANG_COM_BO_SAN_PHAM");

                    b.HasOne("UltraStrore.Data.GioHang", "MaGioHangNavigation")
                        .WithMany("ChiTietGioHangs")
                        .HasForeignKey("MaGioHang")
                        .HasConstraintName("FK_CHI_TIET_GIO_HANG_GIO_HANG");

                    b.HasOne("UltraStrore.Data.SanPham", "MaSanPhamNavigation")
                        .WithMany("ChiTietGioHangs")
                        .HasForeignKey("MaSanPham")
                        .HasConstraintName("FK_CHI_TIET_GIO_HANG_SAN_PHAM");

                    b.Navigation("MaComboNavigation");

                    b.Navigation("MaGioHangNavigation");

                    b.Navigation("MaSanPhamNavigation");
                });

            modelBuilder.Entity("UltraStrore.Data.DanhSachDiaChi", b =>
                {
                    b.HasOne("UltraStrore.Data.NguoiDung", "MaNguoiDungNavigation")
                        .WithMany("DanhSachDiaChis")
                        .HasForeignKey("MaNguoiDung")
                        .HasConstraintName("FK_DANH_SACH_DIA_CHI_NGUOI_DUNG");

                    b.Navigation("MaNguoiDungNavigation");
                });

            modelBuilder.Entity("UltraStrore.Data.DonHang", b =>
                {
                    b.HasOne("UltraStrore.Data.NguoiDung", "MaNguoiDungNavigation")
                        .WithMany("DonHangMaNguoiDungNavigations")
                        .HasForeignKey("MaNguoiDung")
                        .HasConstraintName("FK_DON_HANG_NGUOI_DUNG1");

                    b.HasOne("UltraStrore.Data.NguoiDung", "MaNhanVienNavigation")
                        .WithMany("DonHangMaNhanVienNavigations")
                        .HasForeignKey("MaNhanVien")
                        .HasConstraintName("FK_DON_HANG_NGUOI_DUNG2");

                    b.Navigation("MaNguoiDungNavigation");

                    b.Navigation("MaNhanVienNavigation");
                });

            modelBuilder.Entity("UltraStrore.Data.GioHang", b =>
                {
                    b.HasOne("UltraStrore.Data.NguoiDung", "MaNguoiDungNavigation")
                        .WithMany("GioHangs")
                        .HasForeignKey("MaNguoiDung")
                        .HasConstraintName("FK_GIO_HANG_NGUOI_DUNG");

                    b.Navigation("MaNguoiDungNavigation");
                });

            modelBuilder.Entity("UltraStrore.Data.HinhAnh", b =>
                {
                    b.HasOne("UltraStrore.Data.BinhLuan", "MaBinhLuanNavigation")
                        .WithMany("HinhAnhs")
                        .HasForeignKey("MaBinhLuan")
                        .HasConstraintName("FK_HINH_ANH_BINH_LUAN");

                    b.HasOne("UltraStrore.Data.SanPham", "MaSanPhamNavigation")
                        .WithMany("HinhAnhs")
                        .HasForeignKey("MaSanPham")
                        .HasConstraintName("FK_HINH_ANH_SAN_PHAM");

                    b.Navigation("MaBinhLuanNavigation");

                    b.Navigation("MaSanPhamNavigation");
                });

            modelBuilder.Entity("UltraStrore.Data.SanPham", b =>
                {
                    b.HasOne("UltraStrore.Data.LoaiSanPham", "MaLoaiSanPhamNavigation")
                        .WithMany("SanPhams")
                        .HasForeignKey("MaLoaiSanPham")
                        .HasConstraintName("FK_SAN_PHAM_LOAI_SAN_PHAM");

                    b.HasOne("UltraStrore.Data.ThuongHieu", "MaThuongHieuNavigation")
                        .WithMany("SanPhams")
                        .HasForeignKey("MaThuongHieu")
                        .HasConstraintName("FK_SAN_PHAM_THUONG_HIEU");

                    b.Navigation("MaLoaiSanPhamNavigation");

                    b.Navigation("MaThuongHieuNavigation");
                });

            modelBuilder.Entity("UltraStrore.Data.Video", b =>
                {
                    b.HasOne("UltraStrore.Data.SanPham", "MaSanPhamNavigation")
                        .WithMany("Videos")
                        .HasForeignKey("MaSanPham")
                        .HasConstraintName("FK_VIDEO_SAN_PHAM");

                    b.Navigation("MaSanPhamNavigation");
                });

            modelBuilder.Entity("UltraStrore.Data.YeuThich", b =>
                {
                    b.HasOne("UltraStrore.Data.NguoiDung", "MaNguoiDungNavigation")
                        .WithMany()
                        .HasForeignKey("MaNguoiDungNavigationMaNguoiDung");

                    b.HasOne("UltraStrore.Data.SanPham", "MaSanPhamNavigation")
                        .WithMany("YeuThichs")
                        .HasForeignKey("MaSanPham")
                        .HasConstraintName("FK_YEU_THICH_SAN_PHAM");

                    b.Navigation("MaNguoiDungNavigation");

                    b.Navigation("MaSanPhamNavigation");
                });

            modelBuilder.Entity("UltraStrore.Data.BinhLuan", b =>
                {
                    b.Navigation("HinhAnhs");
                });

            modelBuilder.Entity("UltraStrore.Data.ComBoSanPham", b =>
                {
                    b.Navigation("ChiTietComBos");

                    b.Navigation("ChiTietDonHangs");

                    b.Navigation("ChiTietGioHangs");
                });

            modelBuilder.Entity("UltraStrore.Data.GioHang", b =>
                {
                    b.Navigation("ChiTietGioHangs");
                });

            modelBuilder.Entity("UltraStrore.Data.LoaiSanPham", b =>
                {
                    b.Navigation("SanPhams");
                });

            modelBuilder.Entity("UltraStrore.Data.NguoiDung", b =>
                {
                    b.Navigation("DanhSachDiaChis");

                    b.Navigation("DonHangMaNguoiDungNavigations");

                    b.Navigation("DonHangMaNhanVienNavigations");

                    b.Navigation("GioHangs");
                });

            modelBuilder.Entity("UltraStrore.Data.SanPham", b =>
                {
                    b.Navigation("BinhLuans");

                    b.Navigation("ChiTietComBos");

                    b.Navigation("ChiTietGioHangs");

                    b.Navigation("HinhAnhs");

                    b.Navigation("Videos");

                    b.Navigation("YeuThichs");
                });

            modelBuilder.Entity("UltraStrore.Data.ThuongHieu", b =>
                {
                    b.Navigation("SanPhams");
                });
#pragma warning restore 612, 618
        }
    }
}
