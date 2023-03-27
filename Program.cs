using OOPsProblemStatement.InventoryManagement;
using System;

namespace OOPsProblemStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            InventoryOperation inventory = new InventoryOperation();
            inventory.ReadJsonFile(@"D:\class\BL_.net_Exercise\OOPsProgramStatement\OOPsProblemStatement\inventory.json");

            InventoryDataManagement dataManagement = new InventoryDataManagement();
            dataManagement.ReadJsonFile(@"D:\class\BL_.net_Exercise\OOPsProgramStatement\OOPsProblemStatement\InventoryManagement\inventoryDetails.json");
        }
    }
}
