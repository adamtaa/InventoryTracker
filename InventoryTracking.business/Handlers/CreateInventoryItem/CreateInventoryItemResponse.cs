using InventoryTracking.business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryTracking.business.Handlers.CreateInventoryItem
{
    public class CreateInventoryItemResponse : GenericResponse
    {
        public string InventoryItemName { get; set; }
    }
}
