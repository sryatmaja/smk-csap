using System;
using System.Collections;

namespace Buku
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();

            do
            {
                Console.WriteLine("====================PERPUSTAKAAN====================");
                Console.WriteLine("1. Tambah Buku");
                Console.WriteLine("2. Hapus Buku");
                Console.WriteLine("3. Cari Buku Nama Buku");
                Console.WriteLine("4. Insert Buku");
                Console.WriteLine("5. Lihat Daftar Buku /n");
                Console.WriteLine("====================================================");
                Console.WriteLine("Pilih Menu : ");
                int menu = int.Parse(Console.ReadLine());

                /*ERROR
                 
                try
                {
                    int menu1 = menu;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nilai Input Salah! Harus Berupa Integer");
                }

                */

                Console.WriteLine("====================================================");
                switch (menu)
                {
                    //Tambah
                    case 1:
                        Console.Write("Masukkan Judul Buku : ");
                        string a = Console.ReadLine();
                        arr.Add(a);
                        {
                            Console.WriteLine(a + " Berhasil Ditambahkan.");
                        }
                        break;
                    //Hapus
                    case 2:
                        Console.WriteLine("1. Hapus Buku berdasarkan Nama Buku");
                        Console.WriteLine("2. Hapus Semua Buku /n");
                        Console.WriteLine("====================================================");
                        Console.WriteLine("Pilih Menu : ");
                        int pilih = int.Parse(Console.ReadLine());
                        Console.WriteLine("====================================================");

                        switch (pilih)
                        {
                            //Hapus 1
                            case 1:
                                foreach (string j in arr)
                                {
                                    Console.WriteLine("- " + j);
                                }
                                Console.WriteLine("Masukkan Nama Buku yang akan dihapus : ");
                                string buku = Console.ReadLine();
                                if (arr.Contains(buku))
                                {
                                    Console.WriteLine(" ");
                                    Console.WriteLine("Apakah Anda Yakin akan menghapus " + buku + " [ Y / N ]");
                                    string c = Console.ReadLine();
                                    if (c == "Y")
                                    {
                                        Console.WriteLine(" ");
                                        arr.Remove(buku);
                                        Console.WriteLine(buku + "Berhasil Dihapus");
                                    }
                                    else
                                    {
                                        Console.WriteLine(" ");
                                        Console.WriteLine("Operasi Dibatalkan");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(buku + " Tidak Ditemukan");
                                }
                                break;
                            //Hapus Semua
                            case 2:
                                Console.WriteLine("Anda Yakin Menghapus Semua Buku ? [Y/N]");
                                string e = Console.ReadLine();
                                if (e == "Y")
                                {
                                    arr.Clear();
                                    foreach (string f in arr)
                                    {
                                        Console.WriteLine(f + " ");
                                    }
                                    Console.WriteLine("Buku Berhasil Terhapus");
                                }
                                else
                                {
                                    Console.WriteLine("Operasi Dibatalkan");
                                }
                                break;
                        }
                        break;
                    //Cari
                    case 3:
                        Console.WriteLine("Cari Nama Buku : ");
                        string g = Console.ReadLine();
                        if (arr.Contains(g))
                        {
                            Console.WriteLine(g + " Telah Ditemukan");
                        }
                        else
                        {

                            Console.WriteLine("Buku Tidak Ditemukan");
                        }
                        break;
                    //Insert
                    case 4:
                        Console.Write("Masukkan Nama Buku yang akan Disisipkan : ");
                        string h = Console.ReadLine();
                        Console.Write("Pada Urutan Ke : ");
                        int numb = int.Parse(Console.ReadLine());
                        arr.Insert(numb, h);
                        foreach (string i in arr)
                        {
                            Console.WriteLine("");
                            Console.WriteLine(i + " ");
                            Console.WriteLine("");
                        }
                        break;
                    //Lihat
                    case 5:
                        foreach (string j in arr)
                        {
                            Console.WriteLine("====================Daftar Buku=====================");
                            Console.WriteLine("");
                            Console.WriteLine(j + ",");
                            Console.WriteLine("");
                            Console.WriteLine("====================================================");
                        }
                        break;

                }

                Console.WriteLine("==============Tekan Enter Untuk Keluar==============");
                Console.ReadLine();
                Console.Clear();

            } while (true);
        }
    }
}