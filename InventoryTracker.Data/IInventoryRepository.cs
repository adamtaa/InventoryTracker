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
        InventoryItem Create(InventoryItem item);

        Task<InventoryItem> UpdateInventoryItem(InventoryItem inventoryItem);
        Task<string> Delete(InventoryItem inventoryItem);
        
        Task<IEnumerable<InventoryItem>> Search();

    }
}
