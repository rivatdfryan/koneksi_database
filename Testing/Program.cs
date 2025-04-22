using System;

namespace koneksi_database.Testing
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
                Console.WriteLine("4. Exit");
                Console.Write("Pilih menu (1-4): ");
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
                        return;
                    default:
                        Console.WriteLine("Pilihan tidak valid.");
                        break;
                }
            }
        }
    }
}
