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
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Ean Code: ");
            double eanCode = Double.Parse(Console.ReadLine());
            Console.WriteLine("Production Date (YYYY,MM,DD): ");
            
            string input = Console.ReadLine();
        
            DateTime productionDate;
            if (DateTime.TryParse(input, out productionDate))
            {
                Console.WriteLine("Production Date: " + productionDate);
            }
            else
            {
                Console.WriteLine("Invalid date format.");
            }

            Console.WriteLine("Unit Cost: ");
            double unitCost = Double.Parse(Console.ReadLine());

            Products.Add(new TProduct(id, name, eanCode,productionDate,unitCost));
            id++;

            fileOperations.SaveToFile();

        }

        
        public void ShowProducts(){

            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("| ID |           Nazwa           |          EanCode         |    Production date   |");
            Console.WriteLine("------------------------------------------------------------------------------------");

            foreach (var product in Products)
            {
                Console.WriteLine($"| {product.Id,-2} | {product.Name,-25} | {product.EanCode,-24} | {product.ProductionDate,-20} |");
            }

            Console.WriteLine("------------------------------------------------------------------------------------");
        }

        public void RemoveProduct(){
            Console.WriteLine("Podaj Id produktu do usunięcia: ");
            int idToRemove = int.Parse(Console.ReadLine());
            TProduct productToRemove = Products.Find(p => p.Id == idToRemove);

            Products.Remove(productToRemove);
        }
        

    }
}
