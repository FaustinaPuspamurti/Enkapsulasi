using rumahsakit;
using System;
using System.Runtime.InteropServices;
namespace RumahSakit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dokter");
            User user = new User();
            user.Nama = "Adifa Lusiandi";
            Console.WriteLine("Nama : " + user.Nama);
            user.noID = 2105;
            Console.WriteLine("NomorID : " + user.noID);
            User user1 = new User();
            Console.WriteLine("Nomor HP : " + user1.getNumber());
            User user2 = new User();
            Console.WriteLine("Nomor HP : " + user2.nomorHp);
            Dokter dokter = new Dokter();
            Console.WriteLine("Riwayat Pasien = " + dokter.biodataDokter());
            User user3 = new User();
            user3.bangsal = "IGD";
            Console.WriteLine("Dokter Adifa Lusiandi berada di Bangsal " + user3.bangsal);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Pasien");
            User pasien = new User();
            pasien.Nama = "Ida Sulistiyani";
            Console.WriteLine("Nama : " + pasien.Nama);
            pasien.noID = 2004;
            Console.WriteLine("NomorID : " + pasien.noID);
            User pasien1 = new User();
            Console.WriteLine("Nomor HP : " + pasien1.getNomer());
            User pasien2 = new User();
            Console.WriteLine("Nomor HP : " + pasien2.nomerHP);
            Pasien pasien4 = new Pasien();
            Console.WriteLine("Riwayat Pasien = " + pasien4.biodataPasien());
            User pasien3 = new User();
            pasien3.bangsal= "Cempaka";
            Console.WriteLine("Pasien atas nama Ida  Sulistiyani berada di Bangsal " + pasien3.bangsal);
        }
    }
}