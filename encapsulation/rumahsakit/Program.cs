using System;
using System.Data.Common;

namespace rumahsakit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------");
            //objek pasien
            pasien pasien1 = new pasien();
            pasien1.nama = "Paisen";
            Console.WriteLine("Nama Pasien    : " + pasien1.nama);
            //memanggil bio pasyen
            Console.WriteLine(pasien1.biodataPasien());

            //objek dokter
            dokter doktor = new dokter();
            doktor.nama = "Dr. Jiwa";
            Console.WriteLine("Nama Dokter    : " + doktor.nama);
            //memanggil bio dokter
            Console.WriteLine(doktor.biodataDokter());

            //memanggil data internal user
            user kamar = new user();
            kamar.bangsal = "Tiga Puluh Satu Dua Juta Enam Ratus Lantai Tujuh";
            Console.WriteLine(kamar.bangsal);
        }
    }
}