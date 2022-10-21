using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Dat[] _datlist = new Dat[50];
            Dat qln = new Dat();
            _datlist = new Dat[1000];
            int index = -1;
        Menu:
            Console.Clear();
            Console.WriteLine("1. Thêm giao dịch dat.");
            Console.WriteLine("2. In danh sách dat đã giao dịch.");
            Console.WriteLine("3. Tìm kiếm dat theo đặc điểm.");
            Console.WriteLine("4. Thoát.");
            Console.WriteLine("Chọn điều bạn muốn.");
            string so = Console.ReadLine();
            switch (so)
            {
                case "1":
                    Dat dat = new Dat();
                    index++;
                    dat.ThemDat();
                    _datlist[index] = dat;
                    goto Menu;
                case "2":
                    Console.WriteLine("Danh sách giao dich dat:");
                    Console.WriteLine("{0,-15}{1,-20}{2,-30}{3,-15}{4,-20}", "Mã giao dịch", "Ngày giao dịch", "Đơn giá (USD/Mét vuông)", "Loại dat", "Diện tích (Mét vuông)");
                    foreach (Dat s1 in _datlist)
                    {
                        if (s1 != null)
                        {
                            s1.InGiaoDichDat();
                        }
                    }
                    Console.ReadLine();
                    goto Menu;
                case "3":
                    Menu1:
                        Console.Clear();
                        Console.WriteLine("1. Tim kiem theo ma giao dich.");
                        Console.WriteLine("2. Tim kiem theo ngay giao dich.");
                        Console.WriteLine("3. Tìm kiếm theo gia ca.");
                        Console.WriteLine("4. Tìm kiếm theo loai dat.");
                        Console.WriteLine("5. Tìm kiếm theo dien tich.");
                        Console.WriteLine("6. Thoát.");
                        Console.WriteLine("Chọn điều bạn muốn.");
                        string so1 = Console.ReadLine();
                        switch (so1)
                        {
                            case "1":
                                int sum1 = 0;
                                Console.WriteLine("Nhap ma giao dich can tim:");
                                string magiaodich = Console.ReadLine();
                                Console.WriteLine("Danh sách giao dich dat:");
                                Console.WriteLine("{0,-15}{1,-20}{2,-30}{3,-15}{4,-20}", "Mã giao dịch", "Ngày giao dịch", "Đơn giá (USD/Mét vuông)", "Loại dat", "Diện tích (Mét vuông)");
                                foreach (Dat s1 in _datlist)
                                {
                                    if (s1 != null && s1.MaGiaoDich == magiaodich)
                                    {
                                        sum1++;
                                        s1.InGiaoDichDat();
                                    }
                                }
                                if (sum1 == 0) Console.WriteLine("Khong tim thay giao dich nao.");
                                Console.ReadLine();
                                goto Menu1;
                            case "2":
                                int sum2 = 0;
                                Console.WriteLine("Nhap ngay giao dich can tim:");
                                DateTime ngaygiaodich = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("Danh sách giao dich dat:");
                                Console.WriteLine("{0,-15}{1,-20}{2,-30}{3,-15}{4,-20}", "Mã giao dịch", "Ngày giao dịch", "Đơn giá (USD/Mét vuông)", "Loại dat", "Diện tích (Mét vuông)");
                                foreach (Dat s1 in _datlist)
                                {
                                    if (s1 != null && s1.NgayGiaoDich == ngaygiaodich)
                                    {
                                    sum2++;
                                        s1.InGiaoDichDat();
                                    }
                                }
                                if (sum2 == 0) Console.WriteLine("Khong tim thay giao dich nao.");
                                Console.ReadLine();
                                goto Menu1;
                            case "3":
                                int sum3 = 0;
                                Console.WriteLine("Nhap gia dat/m2 can tim:");
                                int gia = int.Parse(Console.ReadLine());
                                Console.WriteLine("Danh sách giao dich dat:");
                                Console.WriteLine("{0,-15}{1,-20}{2,-30}{3,-15}{4,-20}", "Mã giao dịch", "Ngày giao dịch", "Đơn giá (USD/Mét vuông)", "Loại dat", "Diện tích (Mét vuông)");
                                foreach (Dat s1 in _datlist)
                                {
                                    if (s1 != null && s1.DonGia == gia)
                                    {
                                        sum3++;
                                        s1.InGiaoDichDat();
                                    }
                                }
                                if (sum3 == 0) Console.WriteLine("Khong tim thay giao dich nao.");
                                Console.ReadLine();
                                goto Menu1;
                            case "4":
                                int sum4 = 0;
                                Console.WriteLine("Nhap loai dat can tim:");
                                string loaidat = Console.ReadLine();
                                Console.WriteLine("Danh sách giao dich dat:");
                                Console.WriteLine("{0,-15}{1,-20}{2,-30}{3,-15}{4,-20}", "Mã giao dịch", "Ngày giao dịch", "Đơn giá (USD/Mét vuông)", "Loại dat", "Diện tích (Mét vuông)");
                                foreach (Dat s1 in _datlist)
                                {
                                    if (s1 != null && s1.LoaiDat == loaidat)
                                    {
                                        sum4++;
                                        s1.InGiaoDichDat();
                                    }
                                }
                                if (sum4 == 0) Console.WriteLine("Khong tim thay giao dich nao.");
                                Console.ReadLine();
                                goto Menu1;
                            case "5":
                                int sum5 = 0;
                                Console.WriteLine("Nhap dien tich dat can tim:");
                                int dientich = int.Parse(Console.ReadLine());
                                Console.WriteLine("Danh sách giao dich dat:");
                                Console.WriteLine("{0,-15}{1,-20}{2,-30}{3,-15}{4,-20}", "Mã giao dịch", "Ngày giao dịch", "Đơn giá (USD/Mét vuông)", "Loại dat", "Diện tích (Mét vuông)");
                                foreach (Dat s1 in _datlist)
                                {
                                    if (s1 != null && s1.DienTich == dientich)
                                    {
                                        sum5++;
                                        s1.InGiaoDichDat();
                                    }
                                }
                                if (sum5 == 0) Console.WriteLine("Khong tim thay giao dich nao.");
                                Console.ReadLine();
                                goto Menu1;
                            case "6":
                                break;
                            default:
                                Console.WriteLine("Nhap sai so, chi nhap gia tri tu 1 den 6");
                                Console.ReadLine();
                            goto Menu;
                        }
                    goto Menu1;
                case "4":
                    break;
                default:
                    Console.WriteLine("Nhap sai so, chi nhap gia tri tu 1 den 5");
                    Console.ReadLine();
                    goto Menu;
            }
        }
    }
}
