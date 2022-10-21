using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    public class Dat:GiaoDich
    {
        private string loaiDat;

        public Dat()
        {
            
        }

        public string LoaiDat 
        { 
            get => loaiDat; 
            set => loaiDat = value; 
        }


        public void ThemDat()
        {
            base.Them();
            Console.WriteLine("Loại dat:");
        Menu:
            Console.WriteLine("1. Loại A");
            Console.WriteLine("2. Loại B");
            Console.WriteLine("3. Loại C");
            Console.Write("Chọn loại dat:");
            string so = Console.ReadLine();
            switch (so)
            {
                case "1":
                    LoaiDat = "A";
                    break;
                case "2":
                    LoaiDat = "B";
                    break;
                case "3":
                    LoaiDat = "C";
                    break;
                default:
                    Console.WriteLine("Nhập sai, chỉ được nhập từ 1-3");
                    Console.ReadLine();
                    goto Menu;
            }
        }
        public void InGiaoDichDat()
        {
            Console.WriteLine("{0,-15}{1,-20}{2,-30}{3,-15}{4,-20}", base.MaGiaoDich, base.NgayGiaoDich.ToString("dd/MM/yyyy"), base.DonGia, LoaiDat, base.DienTich);
        }
    }
}
