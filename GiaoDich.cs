using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class GiaoDich
    {
        private string maGiaoDich;
        private DateTime ngayGiaoDich;
        private int donGia;
        private float dienTich;

        public string MaGiaoDich
        {
            get => maGiaoDich;
            set => maGiaoDich = value;
        }

        public DateTime NgayGiaoDich
        {
            get => ngayGiaoDich;
            set => ngayGiaoDich = value;
        }

        public int DonGia
        {
            get => donGia;
            set => donGia = value;
        }

        public float DienTich
        {
            get => dienTich;
            set => dienTich = value;
        }

        public void Them()
        {
            Console.Write("Mã giao dịch:");
            MaGiaoDich = Console.ReadLine();
            Boolean KT = false;
            while (KT == false)
            {
                Console.Write("Ngày giao dịch:");
                try
                {
                    NgayGiaoDich = Convert.ToDateTime(Console.ReadLine());
                    while (NgayGiaoDich > DateTime.Now)
                    {
                        Console.WriteLine("Ngày gian giao dịch không lớn hơn ngày hiện tại.");
                        Console.Write("Nhập lại ngày giao dịch:");
                        NgayGiaoDich = DateTime.Parse(Console.ReadLine());
                    }
                    KT = true;
                }
                catch
                {
                    Console.WriteLine("Nhập sai định dạng ngày! Mời nhập lại.");
                }
            }
            Console.Write("Đơn giá (USD/Mét vuông):");
            DonGia = int.Parse(Console.ReadLine());
            while (DonGia < 0)
            {
                Console.WriteLine("Đơn giá phải lớn hơn 0.");
                Console.Write("Nhập lại đơn giá:");
                DonGia = int.Parse(Console.ReadLine());
            }
            Console.Write("Diện tích (Mét vuông):");
            DienTich = float.Parse(Console.ReadLine());
        }
    }
}
