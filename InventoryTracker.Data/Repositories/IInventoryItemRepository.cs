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
        //IEnumerable<InventoryItem> GetAll();

        Task<InventoryItem> GetByName(string itemName);
        //InventoryItem GetByName(string itemName);

        Task<InventoryItem> CreateInventoryItem(InventoryItem inventoryItem);
        //InventoryItem Create(InventoryItem item);

        Task<InventoryItem> UpdateInventoryItem(InventoryItem inventoryItem);
        //void Update(InventoryItem item);

        Task<InventoryItem> DeleteByName(string itemName);
        //void Delete(string itemName);

        Task<IEnumerable<InventoryItem>> Search(string filter);
    }


}
