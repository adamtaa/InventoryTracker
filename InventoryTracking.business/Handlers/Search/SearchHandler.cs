using InventoryTracker.Data.Repositories;
using InventoryTracking.business.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryTracking.business.Handlers.Search
{
    public class SearchHandler : IRequestHandler<SearchRequest, List<InventoryItemModel>>
    {
        protected readonly IInventoryItemRepository _inventoryItemRepository;
        public SearchHandler(IInventoryItemRepository inventoryItemRepository)
        {
            _inventoryItemRepository = inventoryItemRepository;
        }

        public async Task<List<InventoryItemModel>> Handle(SearchRequest request, CancellationToken cancellationToken)
        {
            string filter = null;
            return new List<InventoryItemModel>(await _inventoryItemRepository.Search(filter));
        }

    }

    
}
