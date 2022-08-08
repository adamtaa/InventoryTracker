using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryTracking.business.Handlers.DeleteInventoryItem
{
    public class DeleteInventoryItemRequest:IRequest<string>
    {
        public string ItemName { get; set; }
    }
}
