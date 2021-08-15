using System;
using System.Collections.Generic;
using System.Text;

namespace rumahsakit
{
    class pasien : user
    {
        private string blank;

        public string biodataPasien()
        {
            nomorhp = "0811";
            Console.WriteLine("Nomor HP       : " + nomorhp);
            nomorID = "A0001";
            Console.WriteLine("Nomor ID       : " + nomorID);
            riwayatPasien = "Bingung";
            Console.WriteLine("Riwayat Pasien : " + riwayatPasien);
            bangsal = "Dua";
            Console.WriteLine("Bangsal        : " + bangsal);
            blank = " ";
            Console.WriteLine(blank);
            return blank;
        }
    }
}
