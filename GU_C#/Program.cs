using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Nhập ngày tháng năm sinh của bạn (theo định dạng dd/MM/yyyy):");
            string input = Console.ReadLine();

            DateTime ngaySinh;
            if (!DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out ngaySinh))
            {
                Console.WriteLine("Định dạng ngày tháng không hợp lệ.");
                return;
            }

            DateTime ngayHienTai = DateTime.Today;
            DateTime sinhNhatNamNay = new DateTime(ngayHienTai.Year, ngaySinh.Month, ngaySinh.Day);

            if (sinhNhatNamNay < ngayHienTai)
            {
                sinhNhatNamNay = sinhNhatNamNay.AddYears(1); // Nếu sinh nhật đã qua trong năm nay, chuyển sang năm sau
            }

            int soNgayConLai = (sinhNhatNamNay - ngayHienTai).Days;

            Console.WriteLine("Số ngày còn lại đến sinh nhật tiếp theo: " + soNgayConLai);
            Console.ReadLine();

        }
    }
}
