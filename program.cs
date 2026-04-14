using System;

namespace tiket
{
    class Program
    {
        static void Main(String[] args)
        {
            // input data
            Console.Write("Masukkan nama user : ");
            string namaUser = Console.ReadLine();

            Console.Write("Jumlah Pembelian Tiket (1-5): ");
            int jumlahTiket = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sudah berapa kali transaksi sebelumnya: ");
            int jumlahTransaksi = Convert.ToInt32(Console.ReadLine());

            int hargaTiket = 35000;

            // Validasi jumlah tiket tetap di awal
            if (jumlahTiket < 1 || jumlahTiket > 5)
            {
                Console.WriteLine("Jumlah tiket salah!");
            }
            else
            {
                int total = jumlahTiket * hargaTiket;
                double diskon = 0;

                // Logika Diskon
                if (jumlahTiket == 5)
                {
                    diskon += 0.10;
                }

                if (jumlahTransaksi > 3)
                {
                    diskon += 0.05;
                }

                double totalBayar = total - (total * diskon);

                // CEK STATUS TRANSAKSI
                // Jika lebih dari 5, tampilkan peringatan tapi TETAP lanjut ke output bawah
                if (jumlahTransaksi > 5)
                {
                    Console.WriteLine("\n--- PERINGATAN: Transaksi ini sudah melebihi batas (5x)! ---");
                }

                // OUTPUT (Tetap muncul apapun jumlah transaksinya)
                Console.WriteLine("\n========== STRUK PEMBAYARAN ==========");
                Console.WriteLine("Nama                   : " + namaUser);
                Console.WriteLine("Jumlah pembelian tiket : " + jumlahTiket);
                Console.WriteLine("Total Awal             : Rp " + total);
                Console.WriteLine("Diskon                 : " + (diskon * 100).ToString("0") + "%");
                Console.WriteLine("Total yang harus dibayar: Rp " + totalBayar);
                Console.WriteLine("======================================");
            }
        }
    }
}
