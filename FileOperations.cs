using System;
using System.Collections.Generic;
using System.IO;

namespace Warehouse
{
    public class FileOperations
    {
        string FilePath = @"C:\Users\krzys\Desktop\Pojekten\c#\Warehouse\products.txt"; 
        public TWarehouse warehouse;  

        public void SaveToFile()
        {
            using (StreamWriter sw = new StreamWriter(FilePath))
            {
                foreach (var product in warehouse.Products)
                {
                    sw.WriteLine($"{product.Id},{product.Name},{product.EanCode}");
                }
            }
        }

        public void LoadFromFile()
        {
            using (StreamReader sr = new StreamReader(FilePath))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(',');

                    int id = int.Parse(data[0]);
                    string name = data[1];
                    int eanCode = int.Parse(data[2]);

                    warehouse.Products.Add(new TProduct(id, name, eanCode));
                }
            }
        }
    }
}