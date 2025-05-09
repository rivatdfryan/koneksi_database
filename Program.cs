﻿using koneksi_database.fitur;
using System;

namespace koneksi_database
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n=== MENU CRUD ===");
                Console.WriteLine("1. Insert Data");
                Console.WriteLine("2. Delete Data");
                Console.WriteLine("3. Update Data");
                Console.WriteLine("4. Tampilkan Table")
                Console.WriteLine("5. Exit");
                Console.Write("Pilih menu (1-5): ");
                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        InsertData.Execute();
                        break;
                    case "2":
                        DeleteData.Execute();
                        break;
                    case "3":
                        UpdateData.Execute();
                        break;
                    case "4":
                        TampilkanData.Execute();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Pilihan tidak valid.");
                        break;
                }
            }
        }
    }
}
