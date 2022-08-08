using InventoryTracker.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTracker.Data.Repositories
{
    public interface IInventoryItemRepository
    {
        Task<InventoryItem> GetAll();
        

        Task<InventoryItem> GetByName(string itemName);
       

        Task<InventoryItem> CreateInventoryItem(InventoryItem inventoryItem);
        

        Task<InventoryItem> UpdateInventoryItem(InventoryItem inventoryItem);
        

        Task<string> Delete(string itemName);
        

        Task<IEnumerable<InventoryItem>> Search(string filter);
    }


}
