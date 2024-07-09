using System;

namespace Warehouse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TWarehouse warehouse = new TWarehouse();

            bool a = true;
            while (a)
            {
                Console.WriteLine("\n\n1. Dodaj produkt");
                Console.WriteLine("2. Usuń produkt");
                 Console.WriteLine("3. Wyświetl listę produktów");
                 Console.WriteLine("4. Wyjście\n\n");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        warehouse.AddProduct();
                        break;
                    case 2:
                        warehouse.RemoveProduct();
                        break;
                    case 3:
                        warehouse.ShowProducts();
                    break;
                    case 4:
                        a = false;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór. Wybierz ponownie.");
                        break;
                }
            }
        }
    }
}