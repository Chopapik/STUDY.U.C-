using System;
using System.Collections.Generic;

namespace Warehouse
{
    public class TWarehouse
    {
        public List<TProduct> Products = new List<TProduct>();
        public List<TWarehouseOperation> Operations = new List<TWarehouseOperation>();
        public int AvailableProductCount { get; set; }
        public FileOperations fileOperations = new FileOperations();
        private int id;


        public TWarehouse()
        {
            fileOperations.warehouse = this;
            fileOperations.LoadFromFile();
            id = Products.Max(p => p.Id);
            id++;
        }

        public void AddProduct()
        {
            Console.WriteLine("Podaj nazwę:");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj EanCode:");
            int eanCode = Convert.ToInt32(Console.ReadLine());

            Products.Add(new TProduct(id, name, eanCode));
            id++;

            fileOperations.SaveToFile();

        }

        
        public void ShowProducts(){

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("| ID |          Nazwa         |          EanCode         |");
            Console.WriteLine("----------------------------------------------------------");

            foreach (var product in Products)
            {
                Console.WriteLine($"| {product.Id,-2} | {product.Name,-22} | {product.EanCode,-24} |");
            }

            Console.WriteLine("----------------------------------------------------------");
        }

        public void RemoveProduct(){
            Console.WriteLine("Podaj Id produktu do usunięcia: ");
            int idToRemove = Convert.ToInt32(Console.ReadLine());
            TProduct productToRemove = Products.Find(p => p.Id == idToRemove);

            Products.Remove(productToRemove);
        }
        
    }
}
