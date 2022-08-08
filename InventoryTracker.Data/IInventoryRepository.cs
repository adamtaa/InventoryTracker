using InventoryTracker.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTracker.Data
{
    public interface IInventoryRepository
    {
        IEnumerable<InventoryItem> GetAll();

        Task<InventoryItem> GetByName(string itemName);
        Task<InventoryItem> CreateInventoryItem(InventoryItem inventoryItem);
        Task<InventoryItem> UpdateInventoryItem(InventoryItem inventoryItem);
        Task<InventoryItem> Delete(InventoryItem inventoryItem);
        
        Task<IEnumerable<InventoryItem>> Search();

    }
}
