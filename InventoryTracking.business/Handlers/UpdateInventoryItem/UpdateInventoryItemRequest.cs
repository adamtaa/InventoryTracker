using InventoryTracking.business.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryTracking.business.Handlers.UpdateInventoryItem
{
    public class UpdateInventoryItemRequest : IRequest<List<InventoryItemModel>>
    {
        public List<InventoryItemModel> InventoryItems { get; set; }
    }
}
