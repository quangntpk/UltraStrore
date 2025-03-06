﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UltraStrore.Data;
using UltraStrore.Models.ViewModels;
using UltraStrore.Repository;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace UltraStrore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommetServices _commetServices;

        public CommentController(ICommetServices commetServices)
        {
            _commetServices = commetServices;
        }

        // Liệt kê tất cả danh sách bình luận
        [HttpGet("list")]
        public async Task<ActionResult<List<BinhLuanView>>> ListBinhLuan()
        {
            var binhLuans = await _commetServices.ListBinhLuan();
            if (binhLuans == null || binhLuans.Count == 0)
            {
                return NotFound("Không tìm thấy bình luận nào.");
            }
            return Ok(binhLuans);
        }

        // Thêm bình luận mới
        [HttpPost("add")]
        public async Task<ActionResult<BinhLuan>> AddBinhLuan([FromBody] BinhLuan binhLuan)
        {
            if (binhLuan == null)
            {
                return BadRequest("Dữ liệu bình luận không hợp lệ.");
            }

            var addedBinhLuan = await _commetServices.AddBinhLuan(binhLuan);
            return CreatedAtAction(nameof(ListBinhLuan), new { ma = addedBinhLuan.MaSanPham }, addedBinhLuan);
        }

        // Sửa bình luận
        [HttpPut("update/{maBinhLuan}")]
        public async Task<ActionResult<BinhLuan>> UpdateBinhLuan(string maBinhLuan, [FromBody] BinhLuan binhLuan)
        {
            if (binhLuan == null || maBinhLuan != binhLuan.MaBinhLuan)
            {
                return BadRequest("Dữ liệu bình luận không hợp lệ.");
            }

            var updatedBinhLuan = await _commetServices.UpdateBinhLuan(maBinhLuan, binhLuan);
            if (updatedBinhLuan == null)
            {
                return NotFound("Không tìm thấy bình luận để cập nhật.");
            }

            return Ok(updatedBinhLuan);
        }

        // Xóa bình luận
        [HttpDelete("delete/{maBinhLuan}")]
        public async Task<ActionResult> DeleteBinhLuan(string maBinhLuan)
        {
            var result = await _commetServices.DeleteBinhLuan(maBinhLuan);
            if (!result)
            {
                return NotFound("Không tìm thấy bình luận để xóa.");
            }

            return Ok("Xóa bình luận thành công.");
        }
    }
}