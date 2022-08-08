using InventoryTracking.business;
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

        InventoryItem IInventoryRepository.Create(InventoryItem item)
        {
            throw new NotImplementedException();
        }

        void IInventoryRepository.Delete(string itemName)
        {
            throw new NotImplementedException();
        }

        IEnumerable<InventoryItem> IInventoryRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        InventoryItem IInventoryRepository.GetByName(string itemName)
        {
            throw new NotImplementedException();
        }

        void IInventoryRepository.Update(InventoryItem item)
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> Search() 
        { 
        }
    }
}
