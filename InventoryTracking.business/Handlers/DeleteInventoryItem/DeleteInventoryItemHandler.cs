using InventoryTracker.Data.Repositories;
using InventoryTracking.business.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryTracking.business.Handlers.DeleteInventoryItem
{
    public class DeleteInventoryItemHandler : IRequestHandler<DeleteInventoryItemRequest, string>
    {
        private readonly IInventoryItemRepository _inventoryItemRepository;

        public DeleteInventoryItemHandler(IInventoryItemRepository inventoryItemRepository)
        {
            _inventoryItemRepository = inventoryItemRepository;
        }

        async Task<string> IRequestHandler<DeleteInventoryItemRequest, string>.Handle(DeleteInventoryItemRequest request, CancellationToken cancellationToken)
        {
            var InventoryItemToDelete = await _inventoryItemRepository.GetByName(request.ItemName);

            if(InventoryItemToDelete == null)
            {
                return request.ItemName;
            }
            
            try
            {
                var deletedName = _inventoryItemRepository.Delete(request.ItemName);

                return deletedName.ToString();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        
    }
}
