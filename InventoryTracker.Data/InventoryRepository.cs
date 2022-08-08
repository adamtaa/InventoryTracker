using InventoryTracker.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTracker.Data
{
    public class InventoryRepository : IInventoryRepository
    {
        //break this out into config file
        private string jsonFile = @"C:\Users\adamt\source\repos\InventoryTracker\InventoryTracker\Resources\itemList.json";

        Task<InventoryItem> IInventoryRepository.CreateInventoryItem(InventoryItem inventoryItem)
        {
            throw new NotImplementedException();
        }

        Task<InventoryItem> IInventoryRepository.Delete(InventoryItem inventoryItem)
        {
            throw new NotImplementedException();
        }

        IEnumerable<InventoryItem> IInventoryRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<InventoryItem> IInventoryRepository.GetByName(string itemName)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<InventoryItem>> IInventoryRepository.Search()
        {
            throw new NotImplementedException();
        }

        Task<InventoryItem> IInventoryRepository.UpdateInventoryItem(InventoryItem inventoryItem)
        {
            throw new NotImplementedException();
        }
    }
}
