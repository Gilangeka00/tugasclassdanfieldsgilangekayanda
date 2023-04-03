using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classdanobject03
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil1 = new classdanobject03.Mobil
            {
                Nama = "saya",
                Warna = "Putih",
                Merek = "Mitsubishi",
                Model = "Xpander",
                Tahun = 2017,
                Jmlpintu = 4
            };

            mobil1.Gas(170);
            mobil1.Klakson("Tut-tut-tut");
            mobil1.TampilkanInfo();

            Console.WriteLine("Tekan enter untuk keluar . . .");
            Console.ReadKey();
        }
    }
}