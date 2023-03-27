using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace OOPsProblemStatement.InventoryManagement
{
    public class InventoryDataManagement
    {
        public void ReadJsonFile(string filePath)
        {
            var data = File.ReadAllText(filePath);
            var result = JsonConvert.DeserializeObject<InventoryList>(data);
            List<InventoryData> riceList = result.RiceList;
            Display(riceList);
            List<InventoryData> wheatList = result.WheatList;
            Display(wheatList);
            List<InventoryData> pulsesList = result.PulsesList;
            Display(pulsesList);

        }

        public void Display(List<InventoryData> list)
        {
            foreach (var inventory in list)
            {
                Console.WriteLine(inventory.Name + "\t" + inventory.Weight + "\t"
                      + inventory.PricePerKg + "\t" + inventory.Weight * inventory.PricePerKg);
            }
        }
        public void AddInventory()
        {
            Console.WriteLine("Enter in which list new inventory need to added");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Inventory Data");
            InventoryData data = new InventoryData();
            data.Name = Console.ReadLine();
            data.Weight = Convert.ToDouble(Console.ReadLine());
            data.PricePerKg = Convert.ToDouble(Console.ReadLine());
            if (name.ToLower().Equals("rice"))
            {
                riceList.Add(data);
            }
            if (name.ToLower().Equals("Wheat"))
            {
                wheatList.Add(data);
            }
            if (name.ToLower().Equals("pulses"))
            {
                pulsesList.Add(data);
            }
        }
        
        
    }
}
