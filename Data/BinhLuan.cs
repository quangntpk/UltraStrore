﻿using System;
using System.Collections.Generic;

namespace UltraStrore.Data;

public partial class BinhLuan
{
    public int MaBinhLuan { get; set; }

    public string? MaSanPham { get; set; }

    public string? MaNguoiDung { get; set; }

    public string? NoiDungBinhLuan { get; set; }

    public int? SoBinhLuan { get; set; }

    public double? DanhGia { get; set; }

    public virtual ICollection<HinhAnh> HinhAnhs { get; set; } = new List<HinhAnh>();

    public virtual SanPham? MaSanPhamNavigation { get; set; }
    public int TrangThai { get; set; }
    public DateTime NgayBinhLuan { get; set; }
}
