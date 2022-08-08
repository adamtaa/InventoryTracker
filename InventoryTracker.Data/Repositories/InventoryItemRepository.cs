using InventoryTracker.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventoryTracker.Data.Repositories
{
    public class InventoryItemRepository : IInventoryItemRepository
    {
        Task<InventoryItem> IInventoryItemRepository.CreateInventoryItem(InventoryItem inventoryItem)
        {
            throw new NotImplementedException();
        }

        Task<InventoryItem> IInventoryItemRepository.DeleteByName(string itemName)
        {
            throw new NotImplementedException();
        }

        Task<InventoryItem> IInventoryItemRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<InventoryItem> IInventoryItemRepository.GetByName(string itemName)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<InventoryItem>> IInventoryItemRepository.Search(string filter)
        {
            throw new NotImplementedException();
        }

        Task<InventoryItem> IInventoryItemRepository.UpdateInventoryItem(InventoryItem inventoryItem)
        {
            throw new NotImplementedException();
        }
    }
}
