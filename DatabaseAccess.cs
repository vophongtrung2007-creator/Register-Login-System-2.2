using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Register_Login_System
{
    public static class DatabaseAccess
    {
        private const string ChuoiKetNoi = @"Server=localhost\SQLEXPRESS; Database=QuanLyNguoiDung; Trusted_Connection=True; TrustServerCertificate=True;";

        public static async Task<bool> KiemTraTonTaiAsync(string tenDangNhap)
        {
            const string sql = "SELECT COUNT(1) FROM Users WHERE TenDangNhap = @ten";
            using var conn = new SqlConnection(ChuoiKetNoi);
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;

            await conn.OpenAsync();
            int count = (int)await cmd.ExecuteScalarAsync();
            return count > 0;
        }

        public static async Task DangKyTaiKhoanAsync(string tenDangNhap, string matKhauBam, string salt, string hoTen, string email)
        {
            const string sql = "INSERT INTO Users (TenDangNhap, MatKhauBam, Salt, HoTen, Email) VALUES (@ten, @bam, @salt, @hoten, @email)";
            using var conn = new SqlConnection(ChuoiKetNoi);
            using var cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;
            cmd.Parameters.Add("@bam", SqlDbType.NVarChar, 64).Value = matKhauBam;
            cmd.Parameters.Add("@salt", SqlDbType.NVarChar, 32).Value = salt;
            cmd.Parameters.Add("@hoten", SqlDbType.NVarChar, 50).Value = hoTen;

            if (string.IsNullOrWhiteSpace(email))
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = DBNull.Value;
            else
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = email;

            await conn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
        }

        public static async Task<(string Salt, string MatKhauBam, string HoTen)?> LayThongTinDangNhapAsync(string tenDangNhap)
        {
            const string sql = "SELECT Salt, MatKhauBam, HoTen FROM Users WHERE TenDangNhap = @ten";
            using var conn = new SqlConnection(ChuoiKetNoi);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = tenDangNhap;

            await conn.OpenAsync();
            using var reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                string salt = reader.GetString(0);
                string bam = reader.GetString(1);
                string hoTen = reader.GetString(2);
                return (salt, bam, hoTen);
            }

            return null;
        }
    }
}