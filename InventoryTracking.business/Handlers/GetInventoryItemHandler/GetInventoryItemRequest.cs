using InventoryTracking.business.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryTracking.business.Handlers.GetInventoryItemHandler
{
    public class GetInventoryItemRequest : InventoryItemModel, IRequest<GetInventoryItemResponse>
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public DateTime createdOn { get; set; }
    }
}
