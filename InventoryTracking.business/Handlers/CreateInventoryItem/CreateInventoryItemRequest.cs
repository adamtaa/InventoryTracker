using InventoryTracker.Data.Entities;
using InventoryTracking.business.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryTracking.business.Handlers.CreateInventoryItem
{
    public class CreateInventoryItemRequest : InventoryItemModel, IRequest<CreateInventoryItemResponse>
    {
    }
}
